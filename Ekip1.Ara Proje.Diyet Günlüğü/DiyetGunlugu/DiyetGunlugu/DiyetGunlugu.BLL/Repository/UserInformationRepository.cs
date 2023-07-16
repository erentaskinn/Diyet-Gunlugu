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
    public class UserInformationRepository : BaseRepository<UserInformation>, IUserInformationRepository
    {
        /// <summary>
        /// Kullanıcının yaşının hesaplandığı metod
        /// </summary>
        /// <param name="birthDate"></param>
        /// <returns></returns>
        public int CalculateAge(DateTime birthDate)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - birthDate.Year;

            if (today < birthDate.AddYears(age))
            {
                age--;
            }

            return age;
        }
        /// <summary>
        /// Kullanıcının alması gereken kalaronin hesabının yapıldığı metod.
        /// </summary>
        /// <param name="userinfo"></param>
        /// <returns></returns>
        int IUserInformationRepository.coloriNeed(UserInformation userinfo)
        {

            double calory;
            if (userinfo.Gender)
            {
                calory = 66.5 + (13.75 * UnitofWork.Instance.WeightChangeRepository.GetAll().Where(x => x.UserInformationID == userinfo.ID).Last().weight) + (5 * userinfo.Height) - (6.77 * UnitofWork.Instance.UserInformation.CalculateAge(userinfo.DateOfBirth));
            }
            else
            {
                calory = 665.1 + (9.5 * UnitofWork.Instance.WeightChangeRepository.GetAll().Where(x => x.UserInformationID == userinfo.ID).Last().weight) + (1.8 * userinfo.Height) - (4.67 * UnitofWork.Instance.UserInformation.CalculateAge(userinfo.DateOfBirth));
            }
            if (userinfo.ActivityLevel == MODEL.Enums.ActivityLevel.Sedantary)
            {
                calory = calory * 1.25;
            }
            else if (userinfo.ActivityLevel == MODEL.Enums.ActivityLevel.Light)
            {
                calory = calory * 1.5;
            }
            else if (userinfo.ActivityLevel == MODEL.Enums.ActivityLevel.Moderate)
            {
                calory = calory * 1.75;
            }
            else
            {
                calory = calory * 2.25;
            }
            if (userinfo.TargetWeight > UnitofWork.Instance.WeightChangeRepository.GetAll().Where(x => x.UserInformationID == userinfo.ID).Last().weight)
            {
                return (int)calory + 500;
            }
            else if(userinfo.TargetWeight == UnitofWork.Instance.WeightChangeRepository.GetAll().Where(x => x.UserInformationID == userinfo.ID).Last().weight)
            {
                return (int)calory;
            }
            else
            {
                return (int)calory - 500;
            }


        }
       
       /// <summary>
       /// Kullanıcının günlük yemiş olduğu yemekleri user panel formadaki tabloya getiren metod.
       /// </summary>
       /// <param name="userID">Aktif kullanıcının belirli olması için ıd parametre olarak verilir.</param>
       /// <returns></returns>
       public IEnumerable<object> Foodtodayfill(int userID)
        {

            var query = UnitofWork.Instance.EatingMeal.GetAll().Where(x => x.EatingMealTime.ToShortDateString() == DateTime.Now.ToShortDateString() && x.UserInformationID == userID)
          .Join(UnitofWork.Instance.Serving.GetAll(),
                eatingMeal => eatingMeal.ServingID,
                serving => serving.ID,
                (eatingMeal, serving) => new { eatingMeal, serving })
          .Join(UnitofWork.Instance.Foods.GetAll(),
                x => x.serving.FoodID, food => food.ID,
                (x, food) => new
                {
                    x.eatingMeal,
                    x.serving,
                    food
                })
          .Select(x => new
          {
              ID = x.eatingMeal.ID,
              Yiyecekadı = x.food.FoodName,
              porsiyon_turu =(MeasurementTypes)x.serving.MeasurementType + $"({x.serving.ServingGrams*x.eatingMeal.Piece})",
              Karbonhidart = (x.food.Carbohydrate * x.serving.ServingGrams) * x.eatingMeal.Piece,
              Yağ = (x.food.Fat*x.serving.ServingGrams)*x.eatingMeal.Piece,
              Protein = (x.food.Protein * x.serving.ServingGrams) * x.eatingMeal.Piece,
              Resim = x.food.FoofPicture,
              Calory = (int)(((x.food.Carbohydrate * 4) + (x.food.Fat * 9) + (x.food.Protein * 4)) * x.eatingMeal.Piece * x.serving.ServingGrams)
          });
            return query;
        }
        /// <summary>
        /// En son kullacıyı getiren metod
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public int LastuserinfoID(User user)
        {
            var userinfoID = UnitofWork.Instance.UserInformation.GetAll()
                 .Join(UnitofWork.Instance.User.GetAll(),
                     ui => ui.UserID,
                     u => u.ID,
                     (ui, u) => new { UserInfo = ui, User = u }).Where(x => x.User.ID == user.ID).Last();
            return userinfoID.UserInfo.ID;
        }
    }
}
