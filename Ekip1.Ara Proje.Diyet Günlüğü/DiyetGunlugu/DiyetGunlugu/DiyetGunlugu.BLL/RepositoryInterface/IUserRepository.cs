using DiyetGunlugu.MODEL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetGunlugu.BLL.RepositoryInterface
{
    public interface IUserRepository : IBaseRepository<User>
    {
        public User Login(string email, string sifre);
        public string RandomDigits(int digitCount);
        public bool MailSend(string mailAdresi, string aktivasyonKodu);
        public int userinfoID(User user);

    }
}
