using DiyetGunlugu.MODEL.Entity;
using DiyetGunlugu.MODEL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetGunlugu.BLL.RepositoryInterface
{
    public interface IFoodsRepostory:IBaseRepository<Foods>
    {
        public IEnumerable<object> DgwFoodListFill(Mealstime mealstime, DateTime datetime, int userID);
        public IEnumerable<object> dgwFill(int eatingMealID);
    }
}
