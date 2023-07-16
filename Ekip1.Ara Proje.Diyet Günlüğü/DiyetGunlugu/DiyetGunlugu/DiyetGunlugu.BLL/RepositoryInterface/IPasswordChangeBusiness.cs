using DiyetGunlugu.MODEL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetGunlugu.BLL.RepositoryInterface
{
    public interface IPasswordBusiness
    {
        /// <summary>
        /// Mevcut Kullanıcının Şifresini Değiştirmesi İçin Kullanılan Metot
        /// </summary>
        /// <param name="sifredegistirecekUser">Şifresini değiştirecek kullanıcıyı alır</param>
        /// <param name="eskiSifre">Şifresini değiştirecek kullanıcının mevcut şifresini ister</param>
        /// <param name="yeniSifre">Şifresini değiştirecek kullanıcının yeni şifresini ister</param>
        public void passwordChange(User sifredegistirecekUser, string eskiSifre, string yeniSifre);

        /// <summary>
        /// Mevcut Kullanıcının Girdiği Şifrenin Güvenlik Kurallarına Uygunluğunu Kontrol eden Metot
        /// </summary>
        /// <param name="yeniSifre"></param>
        /// <returns></returns>
        public (bool Eightcharacter, bool UpperLowerCharacter, bool SpecialCharacter) passwordControl(string newPassword);

        public void NewUser(string oldPassword, string newPassword);

        public User ForgotPasswordChange(User user, string newPasswordAgain, string newPassword);
        public string SHA256Encode(string text);
    }
}
