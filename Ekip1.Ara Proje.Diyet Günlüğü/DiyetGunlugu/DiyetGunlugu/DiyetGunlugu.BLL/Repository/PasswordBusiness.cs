using DiyetGunlugu.BLL.RepositoryInterface;
using DiyetGunlugu.MODEL.Entity;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Resources;

namespace DiyetGunlugu.BLL.Repository
{
    public class PasswordBusiness : IPasswordBusiness
    {
        public static User loginUser;

        /// <summary>
        /// Şifre değiştirme kontrol metodu
        /// </summary>
        /// <param name="passwordChangeUser">Değiştirilmek istenen kullanıcı parametre olarak istenir</param>
        /// <param name="oldPassword">Şifresi değiştirilmek istenen kullanıcının eski şifresi istenir</param>
        /// <param name="newPassword">Şifresi değiştirlmek istenen kullanıcının yenş şifresi parametre olarak istenir</param>
        /// <exception cref="Exception"></exception>
        public void passwordChange(User passwordChangeUser, string oldPassword, string newPassword)
        {
            var user = passwordChangeUser;
            if (!(user.Password ==UnitOfWork.UnitofWork.Instance.PasswordChangeBusiness.SHA256Encode(oldPassword)))
            {
                throw new Exception("Mevcut şifreniz ile girdiğiniz şifre uyuşmuyor.");

            }
            if (!(passwordControl(newPassword).Eightcharacter && passwordControl(newPassword).UpperLowerCharacter && passwordControl(newPassword).SpecialCharacter))
            {
                throw new Exception("Gerekli kriterlere uygun şifre girilmedi!");
            }
            user.Password = SHA256Encode( newPassword);
        }
        /// <summary>
        /// Değiştirilecek şifrenin kontrolü
        /// </summary>
        /// <param name="oldPassword"></param>
        /// <param name="newPassword"></param>
        /// <exception cref="Exception"></exception>
        public void NewUser( string oldPassword, string newPassword)
        {
          
            if (!(oldPassword == newPassword))
            {
                throw new Exception("Girilen Şifreler Birbiriyle Uyumsuz");

            }
            if (!(passwordControl(newPassword).Eightcharacter && passwordControl(newPassword).UpperLowerCharacter && passwordControl(newPassword).SpecialCharacter))
            {
                throw new Exception("Gerekli kriterlere uygun şifre girilmedi!");
            }
        }
        /// <summary>
        /// Paralosını unutan kullanıcının kullanıcının şifreslerini kontrol edildiği metod
        /// </summary>
        /// <param name="user"></param>
        /// <param name="newPasswordAgain"></param>
        /// <param name="newPassword"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public User ForgotPasswordChange(User user, string newPasswordAgain, string newPassword)
        {
            
            if (!(newPassword == newPasswordAgain))
            {
                throw new Exception("Girilen Şifreler Birbiriyle Uyumsuz");

            }
            if (!(passwordControl(newPassword).Eightcharacter && passwordControl(newPassword).UpperLowerCharacter && passwordControl(newPassword).SpecialCharacter))
            {
                throw new Exception("Gerekli kriterlere uygun şifre girilmedi!");
            }
            user.Password = SHA256Encode(newPassword);
            return user;

        }
        /// <summary>
        /// Yeni şifrenin istenilen kriterlere uygun olup olmadığının kontrolünün yapıldığı metod
        /// </summary>
        /// <param name="newPassword"></param>
        /// <returns></returns>
        public (bool Eightcharacter, bool UpperLowerCharacter, bool SpecialCharacter) passwordControl(string newPassword)
        {
            bool Eightcharacter = true;
            bool UpperLowerCharacter = true;
            bool SpecialCharacter = true;
            // Şifre en az 8 karakterden oluşmalıdır.
            if (newPassword.Length <= 8)
            {
                Eightcharacter = false;
            }

            // Şifre en az bir büyük ve en az bir küçük harf içermelidir.
            if (!newPassword.Any(char.IsUpper) || !newPassword.Any(char.IsLower))
            {
                UpperLowerCharacter = false;
            }

            // Şifre en az bir özel karakter içermelidir.
            if (!newPassword.Any(IsSpecialCharacter))
            {
                SpecialCharacter = false;
            }
            return (Eightcharacter, UpperLowerCharacter, SpecialCharacter);
        }
        /// <summary>
        /// istenilen kriterlerde özel karakter kullanılıp kullanılmadığını kontrol eden metod
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        private bool IsSpecialCharacter(char c)
        {
            // Özel karakterlerin listesi.
            char[] specialCharacters = { '!', '@', '#', '$', '%', '^', '&', '*', '.', '+', '-', '/' };

            // Karakterin özel karakter listesinde olup olmadığının kontrolü.
            return specialCharacters.Contains(c);
        }
        /// <summary>
        /// Kullanıcının şifresini haslı şifreye dönüştüren metod
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public string SHA256Encode(string text)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(text);

            using (SHA256Managed sha256 = new SHA256Managed())
            {
                byte[] hashBytes = sha256.ComputeHash(bytes);
                StringBuilder builder = new StringBuilder();

                for (int i = 0; i < hashBytes.Length; i++)
                {
                    builder.Append(hashBytes[i].ToString("x2"));
                }

                return builder.ToString();
            }
        }
       
    }
}
