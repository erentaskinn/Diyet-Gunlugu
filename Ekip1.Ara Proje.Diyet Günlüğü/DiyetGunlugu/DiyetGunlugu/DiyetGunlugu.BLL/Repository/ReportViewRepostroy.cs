using DiyetGunlugu.BLL.RepositoryInterface;
using DiyetGunlugu.MODEL.Entity;
using DiyetGunlugu.MODEL.ReportVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetGunlugu.BLL.Repository
{
    internal class ReportViewRepostroy : IReportViewRepostroy
    {
        /// <summary>
        /// Gunlük rapor tablosunu dolduran metod.
        /// </summary>
        /// <param name="userInformationId"></param>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public IEnumerable<object> FıllDgvDailyReport(int userInformationId, DateTime dateTime)
        {
            var result = UnitOfWork.UnitofWork.Instance.EatingMeal.GetAll()
                         .Join(UnitOfWork.UnitofWork.Instance.Serving.GetAll(), e => e.ServingID, s => s.ID, (e, s) => new { EatingMeal = e, Serving = s })
                         .Join(UnitOfWork.UnitofWork.Instance.Foods.GetAll(), es => es.Serving.FoodID, f => f.ID, (es, f) => new { es.EatingMeal, es.Serving, Food = f })
                         .Join(UnitOfWork.UnitofWork.Instance.UserInformation.GetAll(), esf => esf.EatingMeal.UserInformationID, u => u.ID, (esf, u) => new { esf.EatingMeal, esf.Serving, esf.Food, UserInformation = u })
                         .Where(x => x.UserInformation.ID == userInformationId && x.EatingMeal.EatingMealTime.ToShortDateString() == dateTime.ToShortDateString())
                         .GroupBy(e => new { Date = e.EatingMeal.EatingMealTime.Date, e.EatingMeal.MealTime, e.UserInformation.NameSurname })
                         .Select(g => new
                         {
                             g.Key.MealTime,
                             EatingMealTime = g.Key.Date,
                             KALORI = g.Sum(e => ((e.Food.Fat * 9) + (e.Food.Protein * 4) + (e.Food.Carbohydrate * 4)) * e.EatingMeal.Piece * e.Serving.ServingGrams)

                         }).ToList();
            return result;

        }
        /// <summary>
        /// Haftalık toplam günlük aldığı kalorileri gösteren tabloyu dolduran metod
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public IEnumerable<object> FıllDgvWeekRepor(int UserinfoID, DateTime dateTime)
        {
            DateTime startDate = dateTime.AddDays(-6); // Bugünden 6 gün önce
            DateTime endDate = dateTime.Date;

            var result = UnitOfWork.UnitofWork.Instance.EatingMeal.GetAll()
                         .Join(UnitOfWork.UnitofWork.Instance.Serving.GetAll(),
                               e => e.ServingID,
                               s => s.ID,
                               (e, s) => new { EatingMeal = e, Serving = s })
                         .Join(UnitOfWork.UnitofWork.Instance.Foods.GetAll(),
                               es => es.Serving.FoodID,
                               f => f.ID,
                               (es, f) => new { es.EatingMeal, es.Serving, Food = f })
                         .Join(UnitOfWork.UnitofWork.Instance.UserInformation.GetAll(),
                               esf => esf.EatingMeal.UserInformationID,
                               u => u.ID,
                               (esf, u) => new { esf.EatingMeal, esf.Serving, esf.Food, UserInformation = u })
                         .Where(e => e.EatingMeal.EatingMealTime.Date >= startDate && e.EatingMeal.EatingMealTime.Date <= endDate) // Zaman aralığı koşulu
                         .GroupBy(e => new { GroupStartDate = startDate, e.UserInformation.NameSurname, e.UserInformation.ID })
                         .Select(g => new Reportview
                         {
                             UserinfoID = g.Key.ID,
                             NameSurname = g.Key.NameSurname,
                             EatingMealTime = g.Key.GroupStartDate,
                             KALORI = g.Sum(e => ((e.Food.Fat * 9) + (e.Food.Protein * 4) + (e.Food.Carbohydrate * 4)) * e.EatingMeal.Piece * e.Serving.ServingGrams),
                             ORTALAMA = 0 // ORTALAMA değeri için başlangıç olarak 0 atanıyor
                         })
                         .ToList();

            var totalCalories = result.Sum(r => r.KALORI);
            var totalPeopleCount = result.Select(r => r.UserinfoID).Distinct().Count();

            var averageCalories = totalCalories / totalPeopleCount;

            foreach (var item in result)
            {
                item.ORTALAMA = (int)averageCalories;
            }


            return result.Where(x => x.UserinfoID == UserinfoID);

        }
        /// <summary>
        /// Haftalık yiyeycek kategorisine göre aldığı kaloriyi gösteren tabloyu dolduran metod 
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public IEnumerable<object> ReportByFoodCategoryWeek(int UserinfoID, DateTime dateTime)
        {
            DateTime startDate = dateTime.AddDays(-6); // Bugünden 6 gün önceki tarih
            DateTime endDate = dateTime.Date;

            var result = UnitOfWork.UnitofWork.Instance.EatingMeal.GetAll()
                         .Join(UnitOfWork.UnitofWork.Instance.Serving.GetAll(),
                               e => e.ServingID,
                               s => s.ID,
                               (e, s) => new { EatingMeal = e, Serving = s })
                         .Join(UnitOfWork.UnitofWork.Instance.Foods.GetAll(),
                               es => es.Serving.FoodID,
                               f => f.ID,
                               (es, f) => new { es.EatingMeal, es.Serving, Food = f })
                         .Join(UnitOfWork.UnitofWork.Instance.UserInformation.GetAll(),
                               esf => esf.EatingMeal.UserInformationID,
                               u => u.ID,
                               (esf, u) => new { esf.EatingMeal, esf.Serving, esf.Food, UserInformation = u })
                         .Join(UnitOfWork.UnitofWork.Instance.TypeOfFoodsRepostroy.GetAll(),
                               esfu => esfu.Food.TypeOfFoodsID,
                               t => t.ID,
                               (esfu, t) => new { esfu.EatingMeal, esfu.Serving, esfu.Food, esfu.UserInformation, TypeOfFood = t })
                         .Where(e => e.EatingMeal.EatingMealTime >= startDate && e.EatingMeal.EatingMealTime <= endDate)
                         .GroupBy(e => new { GroupStartDate = startDate, e.UserInformation.NameSurname, e.TypeOfFood.TypeOfFood, e.UserInformation.ID })
                         .Select(g => new ReportViewsCategories
                         {
                             UserinfoID = g.Key.ID,
                             TypeOfFood = g.Key.TypeOfFood,
                             Protein = g.Sum(e => (e.Food.Protein) * e.Serving.ServingGrams),
                             Yağ = g.Sum(e => (e.Food.Fat) * e.Serving.ServingGrams),
                             Karbonhidrat = g.Sum(e => (e.Food.Carbohydrate) * e.Serving.ServingGrams),
                             NameSurname = g.Key.NameSurname,
                             EatingMealTime = g.Key.GroupStartDate,
                             KALORI = g.Sum(e => ((e.Food.Fat * 9) + (e.Food.Protein * 4) + (e.Food.Carbohydrate * 4)) * e.EatingMeal.Piece * e.Serving.ServingGrams),
                             Ortalama = 0
                         }).ToList();

            var groupedResult = result.GroupBy(r =>new { r.TypeOfFood}).ToList();
            foreach (var group in groupedResult)
            {
                var groupDistinctPeopleCount = group.Select(r => r.UserinfoID).Distinct().Count();
                var groupTotalCalories = group.Sum(r => r.KALORI);
                var groupAverageCalories = groupTotalCalories / groupDistinctPeopleCount;

                foreach (var item in group)
                {
                    item.Ortalama = (int)groupAverageCalories;
                }
            }

            var filteredResult = result.Where(x => x.UserinfoID == UserinfoID);

            return filteredResult;

        }
        /// <summary>
        /// Aylık aldığı kalorileri,bir aylık her günü veren tabloyu dolduran metod
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>

        public IEnumerable<object> FıllDgvMounthReport(int UserinfoID, DateTime dateTime)
        {
            DateTime startDate = dateTime.AddDays(-30); // Bugünden 30 gün önce
            DateTime endDate = dateTime;
            var result = UnitOfWork.UnitofWork.Instance.EatingMeal.GetAll()
                        .Join(UnitOfWork.UnitofWork.Instance.Serving.GetAll(),
                              e => e.ServingID,
                              s => s.ID,
                              (e, s) => new { EatingMeal = e, Serving = s })
                        .Join(UnitOfWork.UnitofWork.Instance.Foods.GetAll(),
                              es => es.Serving.FoodID,
                              f => f.ID,
                              (es, f) => new { es.EatingMeal, es.Serving, Food = f })
                        .Join(UnitOfWork.UnitofWork.Instance.UserInformation.GetAll(),
                              esf => esf.EatingMeal.UserInformationID,
                              u => u.ID,
                              (esf, u) => new { esf.EatingMeal, esf.Serving, esf.Food, UserInformation = u })
                        .Where(e => e.EatingMeal.EatingMealTime.Date >= startDate && e.EatingMeal.EatingMealTime.Date <= endDate) // Zaman aralığı koşulu
                        .GroupBy(e => new { GroupStartDate = startDate, e.UserInformation.NameSurname, e.UserInformation.ID })
                        .Select(g => new Reportview
                        {
                            UserinfoID = g.Key.ID,
                            NameSurname = g.Key.NameSurname,
                            EatingMealTime = g.Key.GroupStartDate,
                            KALORI = g.Sum(e => ((e.Food.Fat * 9) + (e.Food.Protein * 4) + (e.Food.Carbohydrate * 4)) * e.EatingMeal.Piece * e.Serving.ServingGrams),
                            ORTALAMA = 0 // ORTALAMA değeri için başlangıç olarak 0 atanıyor
                        })
                        .ToList();

            var totalCalories = result.Sum(r => r.KALORI);
            var totalPeopleCount = result.Select(r => r.UserinfoID).Distinct().Count();

            var averageCalories = totalCalories / totalPeopleCount;

            foreach (var item in result)
            {
                item.ORTALAMA = (int)averageCalories;
            }


            return result.Where(x => x.UserinfoID == UserinfoID);
        }
        /// <summary>
        /// Aylık olarak yediği yiyecekleri kategorisine göre vren tablonun verilerini dolduran metod 
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public IEnumerable<object> ReportByFoodCategoryMounth(int UserinfoID, DateTime dateTime)
        {
            DateTime startDate = dateTime.AddDays(-30); // Bugünden 30 gün önceki tarih
            DateTime endDate = dateTime; // Bugünün tarihi

            var result = UnitOfWork.UnitofWork.Instance.EatingMeal.GetAll()
                        .Join(UnitOfWork.UnitofWork.Instance.Serving.GetAll(),
                              e => e.ServingID,
                              s => s.ID,
                              (e, s) => new { EatingMeal = e, Serving = s })
                        .Join(UnitOfWork.UnitofWork.Instance.Foods.GetAll(),
                              es => es.Serving.FoodID,
                              f => f.ID,
                              (es, f) => new { es.EatingMeal, es.Serving, Food = f })
                        .Join(UnitOfWork.UnitofWork.Instance.UserInformation.GetAll(),
                              esf => esf.EatingMeal.UserInformationID,
                              u => u.ID,
                              (esf, u) => new { esf.EatingMeal, esf.Serving, esf.Food, UserInformation = u })
                        .Join(UnitOfWork.UnitofWork.Instance.TypeOfFoodsRepostroy.GetAll(),
                              esfu => esfu.Food.TypeOfFoodsID,
                              t => t.ID,
                              (esfu, t) => new { esfu.EatingMeal, esfu.Serving, esfu.Food, esfu.UserInformation, TypeOfFood = t })
                        .Where(e => e.EatingMeal.EatingMealTime >= startDate && e.EatingMeal.EatingMealTime <= endDate)
                        .GroupBy(e => new { GroupStartDate = startDate, e.UserInformation.NameSurname, e.TypeOfFood.TypeOfFood, e.UserInformation.ID })
                        .Select(g => new ReportViewsCategories
                        {
                            UserinfoID = g.Key.ID,
                            TypeOfFood = g.Key.TypeOfFood,
                            Protein = g.Sum(e => (e.Food.Protein) * e.Serving.ServingGrams),
                            Yağ = g.Sum(e => (e.Food.Fat) * e.Serving.ServingGrams),
                            Karbonhidrat = g.Sum(e => (e.Food.Carbohydrate) * e.Serving.ServingGrams),
                            NameSurname = g.Key.NameSurname,
                            EatingMealTime = g.Key.GroupStartDate,
                            KALORI = g.Sum(e => ((e.Food.Fat * 9) + (e.Food.Protein * 4) + (e.Food.Carbohydrate * 4)) * e.EatingMeal.Piece * e.Serving.ServingGrams),
                            Ortalama = 0
                        }).ToList();

            var groupedResult = result.GroupBy(r => r.TypeOfFood).ToList();
            foreach (var group in groupedResult)
            {
                var groupDistinctPeopleCount = group.Select(r => r.UserinfoID).Distinct().Count();
                var groupTotalCalories = group.Sum(r => r.KALORI);
                var groupAverageCalories = groupTotalCalories / groupDistinctPeopleCount;

                foreach (var item in group)
                {
                    item.Ortalama = (int)groupAverageCalories;
                }
            }

            var filteredResult = result.Where(x => x.UserinfoID == UserinfoID);

            return filteredResult;
        }
        /// <summary>
        /// Kategorilere göre en çok yenilen yemekleri gösteren tabloyu dolduran metod
        /// </summary>
        /// <returns></returns>
        public IEnumerable<object> FıllDgvTheMostEatenFoodTypeOf()
        {
            var result = UnitOfWork.UnitofWork.Instance.EatingMeal.GetAll()
                        .Join(UnitOfWork.UnitofWork.Instance.Serving.GetAll(),
                              e => e.ServingID,
                              s => s.ID,
                              (e, s) => new { EatingMeal = e, Serving = s })
                        .Join(UnitOfWork.UnitofWork.Instance.Foods.GetAll(),
                              es => es.Serving.FoodID,
                              f => f.ID,
                              (es, f) => new { es.EatingMeal, es.Serving, Food = f })
                        .Join(UnitOfWork.UnitofWork.Instance.UserInformation.GetAll(),
                              esf => esf.EatingMeal.UserInformationID,
                              u => u.ID,
                              (esf, u) => new { esf.EatingMeal, esf.Serving, esf.Food, UserInformation = u })
                        .Join(UnitOfWork.UnitofWork.Instance.TypeOfFoodsRepostroy.GetAll(),
                              esfu => esfu.Food.TypeOfFoodsID,
                              t => t.ID,
                              (esfu, t) => new { esfu.EatingMeal, esfu.Serving, esfu.Food, esfu.UserInformation, TypeOfFood = t })
                        .GroupBy(e => new { e.Food.FoodName, e.EatingMeal.MealTime })
                        .Select(g => new
                        {
                            MealTime = g.Key.MealTime,
                            FoodName = g.Key.FoodName,
                            Total = g.Sum(e => e.EatingMeal.Piece)
                        }).ToList().OrderByDescending(x => x.Total);
            return result;
        }
        /// <summary>
        /// En çok yenen yemkeleri gösteren tabloyu dolduran metod.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<object> FıllTheMostEatenFood()
        {
            var result = UnitOfWork.UnitofWork.Instance.EatingMeal.GetAll()
                         .Join(UnitOfWork.UnitofWork.Instance.Serving.GetAll(),
                               e => e.ServingID,
                               s => s.ID,
                               (e, s) => new { EatingMeal = e, Serving = s })
                         .Join(UnitOfWork.UnitofWork.Instance.Foods.GetAll(),
                               es => es.Serving.FoodID,
                               f => f.ID,
                               (es, f) => new { es.EatingMeal, es.Serving, Food = f })
                         .Join(UnitOfWork.UnitofWork.Instance.UserInformation.GetAll(),
                               esf => esf.EatingMeal.UserInformationID,
                               u => u.ID,
                               (esf, u) => new { esf.EatingMeal, esf.Serving, esf.Food, UserInformation = u })
                         .GroupBy(e => e.Food.FoodName)
                         .Select(g => new
                         {
                             FoodName = g.Key,
                             Total = g.Sum(e => e.EatingMeal.Piece)
                         })
                         .OrderByDescending(g => g.Total)
                         .ToList();
            return result;

        }


    }
}
