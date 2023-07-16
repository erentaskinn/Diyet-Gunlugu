using DiyetGunlugu.BLL.RepositoryInterface;
using DiyetGunlugu.BLL.UnitOfWork;
using DiyetGunlugu.MODEL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace DiyetGunlugu.BLL.Repository
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        /// <summary>
        /// Kullanıcı e mail şifre giriş yapılırken kontrolünü yapan metod.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="sifre"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public User Login(string email, string sifre)
        {
            var kullanici = GetAll().Where(x => x.Email == email && x.Password == sifre).FirstOrDefault();
            if (kullanici != null)
            {
                return kullanici;
            }
            else
                throw new Exception("Email veya şifre yanlış");
        }
        /// <summary>
        /// Kullanıcının şifresini unuttuğunda e-mailine gönderilen aktivasyon koduyla şifresinisi değiştiren metod.
        /// </summary>
        /// <param name="mailAdresi"></param>
        /// <param name="aktivasyonKodu"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public bool MailSend( string mailAdresi, string aktivasyonKodu)
        {
            try
            {
                // E-posta ayarlarını yapın
                string smtpServer = "smtp-mail.outlook.com";
                int smtpPort = 587;
                string senderEmail = "teamacar2023@hotmail.com";
                string senderPassword = "Alitopluhoca";

                // E-posta gövdesini HTML formatında oluşturun
                string emailBody = $"<html><body><p>Merhaba,</p><p>Hesabınızı etkinleştirmek için aşağıdaki aktivasyon kodunu kullanın:</p><p><strong>{aktivasyonKodu}</strong></p><p>İyi günler.</p></body></html>";

                // MailMessage oluşturun ve ayarlarını yapın
                MailMessage mailMessage = new MailMessage();
                mailMessage.From = new MailAddress(senderEmail);
                mailMessage.To.Add(mailAdresi);
                mailMessage.Subject = "Şifre Değişim Aktivasyonu";
                mailMessage.Body = emailBody;
                mailMessage.BodyEncoding = Encoding.UTF8;
                mailMessage.IsBodyHtml = true;

                // SmtpClient oluşturun ve e-postayı gönderin
                SmtpClient smtpClient = new SmtpClient(smtpServer, smtpPort);
                smtpClient.EnableSsl = true;
                smtpClient.Credentials = new NetworkCredential(senderEmail, senderPassword);
                smtpClient.Send(mailMessage);

                return true; // E-posta başarıyla gönderildi
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
           
        }
        /// <summary>
        /// Rastgele 8 haneli aktivasyon kodunu oluşturan metod.
        /// </summary>
        /// <param name="digitCount"></param>
        /// <returns></returns>
        public string RandomDigits(int digitCount)
        {
            Random random = new Random();
            string randomDigits = "";

            for (int i = 0; i < digitCount; i++)
            {
                int digit = random.Next(0, 10);
                randomDigits += digit.ToString();
            }

            return randomDigits;
        }
        /// <summary>
        /// En son giriş yapan kullanıcının ıd sini dödüren metod
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public int userinfoID(User user)
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
