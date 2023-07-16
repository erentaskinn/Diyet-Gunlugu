using DiyetGunlugu.BLL.RepositoryInterface;
using DiyetGunlugu.BLL.UnitOfWork;
using DiyetGunlugu.MODEL.Entity;
using DiyetGunlugu.MODEL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetGunlugu.BLL.Repository
{
    public class FoodsRepostroy : BaseRepository<Foods>, IFoodsRepostory
    {
        /// <summary>
        /// Belilri tarihteki aktif kullanıcının belli öğünlerde yediği yiyecekleri datagridviewe atma metodu
        /// </summary>
        /// <param name="mealstime">Öğün belirlemek için</param>
        /// <param name="datetime">Tarih belirlemek için</param>
        /// <param name="userİnfoId">Aktif kullanıcıyı bilmek için</param>
        /// <returns></returns>
        public IEnumerable<object> DgwFoodListFill(Mealstime mealstime, DateTime datetime, int userİnfoId)
        {
            var query = UnitofWork.Instance.EatingMeal.GetAll().Where(x => x.EatingMealTime.ToShortDateString() == datetime.ToShortDateString() && x.MealTime == mealstime && userİnfoId == x.UserInformationID)
           .Join(UnitofWork.Instance.Serving.GetAll(), eatingMeal => eatingMeal.ServingID, serving => serving.ID, (eatingMeal, serving) => new { eatingMeal, serving })
           .Join(UnitofWork.Instance.Foods.GetAll(), x => x.serving.FoodID, food => food.ID, (x, food) => new { x.eatingMeal, x.serving, food })
           .Select(x => new
           {
               ID = x.eatingMeal.ID,
               Yiyecekadı = x.food.FoodName,
               porsiyon_turu = (MeasurementTypes)x.serving.MeasurementType,
               Adet = x.eatingMeal.Piece,
               Karbonhidart = (int)(x.food.Carbohydrate * x.serving.ServingGrams * x.eatingMeal.Piece),
               Yağ = (int)(x.food.Fat * x.serving.ServingGrams*x.eatingMeal.Piece),
               Protein = (int)(x.food.Protein * x.serving.ServingGrams * x.eatingMeal.Piece),
               Resim = x.food.FoofPicture,
               Kalori = (int)(((x.food.Carbohydrate * 4) + (x.food.Fat * 9) + (x.food.Protein * 4)) * x.serving.ServingGrams*x.eatingMeal.Piece)

           });


            return query;

        }
        /// <summary>
        /// Eating meal ıd ye göre yiyecekleri getiren metod
        /// </summary>
        /// <param name="eatingMealID"></param>
        /// <returns></returns>
        public IEnumerable<object> dgwFill(int eatingMealID)
        {
            var query = UnitofWork.Instance.EatingMeal.GetAll().Where(x => x.ID == eatingMealID)
           .Join(UnitofWork.Instance.Serving.GetAll(), eatingMeal => eatingMeal.ServingID, serving => serving.ID, (eatingMeal, serving) => new { eatingMeal, serving })
           .Join(UnitofWork.Instance.Foods.GetAll(), x => x.serving.FoodID, food => food.ID, (x, food) => new { x.eatingMeal, x.serving, food })
           .Select(x => new
           {
               ID = x.eatingMeal.ID,
               Yemek_adı = x.eatingMeal.Serving.Food.FoodName,
               ADET = x.eatingMeal.Piece,
               PORSİYONTÜRÜ = (MeasurementTypes)x.serving.MeasurementType + " " + x.serving.ServingGrams,
               Resim = x.food.FoofPicture
           });

            return query;
        }

    }
}

