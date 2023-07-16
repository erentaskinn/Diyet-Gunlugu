using DiyetGunlugu.BLL.UnitOfWork;
using DiyetGunlugu.MODEL.Entity;
using DiyetGunlugu.UI.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiyetGunlugu.UI
{
    public partial class LoginForm : Form
    {
      
        public bool SifreGorunurMu { get; set; }
        public LoginForm()
        {

            InitializeComponent();
        }

        private void btn_SignIn_Click(object sender, EventArgs e)
        {
            //PasswordChangeForm passwordChangeForm = new PasswordChangeForm();
            //this.Hide();
            //passwordChangeForm.ShowDialog();
            var NewUserForm = new NewUserForm();
            this.Hide();
            NewUserForm.ShowDialog();
            this.Show();
        }


        private void link_ForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var ForgotPasswordForm = new ForgotPasswordForm();
            this.Hide();
            ForgotPasswordForm.ShowDialog();
            this.Show();




        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            var loginUser = UnitofWork.Instance.User.GetAll().FirstOrDefault(x => x.Email == txt_Username.Text && x.Password == UnitofWork.Instance.PasswordChangeBusiness.SHA256Encode(txt_Password.Text));
            if (loginUser != null && loginUser.FirstLogin == false)
            {
                MessageBox.Show("Giriş Yapıldı");
                this.Hide();
                var UserPanelForm = new UserPanelForm(loginUser);
                UserPanelForm.ShowDialog();
                this.Show();
            }
            else if (loginUser != null && loginUser.FirstLogin)
            {
                MessageBox.Show("Giriş Yapıldı");
                var UserInformationForm = new UserInformationAddorChangeForm(loginUser);
                this.Hide();
                UserInformationForm.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (SifreGorunurMu)
            {
                // Şifreyi gizle
                txt_Password.PasswordChar = '*';
                pictureBox1.Image = Resources.Kapali_Goz_Icon;

            }
            else
            {
                // Şifreyi göster
                txt_Password.PasswordChar = '\0';
                pictureBox1.Image = Resources.Acik_Goz_Icon;
            }

            // Durumu tersine çevir
            SifreGorunurMu = !SifreGorunurMu;
        }
    }
}
