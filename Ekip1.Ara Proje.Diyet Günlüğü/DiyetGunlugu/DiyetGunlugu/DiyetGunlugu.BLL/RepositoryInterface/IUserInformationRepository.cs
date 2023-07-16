using DiyetGunlugu.MODEL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetGunlugu.BLL.RepositoryInterface
{
    public interface IUserInformationRepository : IBaseRepository<UserInformation>
    {
        public int CalculateAge(DateTime birthDate);
       
        public int coloriNeed(UserInformation userinfo);
        public IEnumerable<object> Foodtodayfill(int userID);
        public int LastuserinfoID(User user);
    }
}
