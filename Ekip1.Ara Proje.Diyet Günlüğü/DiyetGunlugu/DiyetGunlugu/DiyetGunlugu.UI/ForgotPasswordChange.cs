using DiyetGunlugu.BLL.UnitOfWork;
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
    public partial class ForgotPasswordChange : Form
    {
        public bool SifreGorunurMu { get; set; }
        private MODEL.Entity.User? user { get; set; }
        public ForgotPasswordChange(MODEL.Entity.User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void btn_ChangePassword_Click(object sender, EventArgs e)
        {
            try
            {
              var  user = UnitofWork.Instance.PasswordChangeBusiness.ForgotPasswordChange(this.user, txt_Password.Text, txt_PasswordAgain.Text);
                if (user.Password!=this.user.Password)
                {
                    UnitofWork.Instance.User.Update(user);
                }
                MessageBox.Show("Şifre Değiştirildi Yeni Şifre İle Giriş Yapmalısınız");
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            };
        }

        private void txt_Password_TextChanged(object sender, EventArgs e)
        {

            pb_EightCharacter.Visible = UnitofWork.Instance.PasswordChangeBusiness.passwordControl(txt_Password.Text).Eightcharacter;
            pb_UpperLowerCharacter.Visible = UnitofWork.Instance.PasswordChangeBusiness.passwordControl(txt_Password.Text).UpperLowerCharacter;
            pb_SpecialCharacter.Visible = UnitofWork.Instance.PasswordChangeBusiness.passwordControl(txt_Password.Text).SpecialCharacter;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (SifreGorunurMu)
            {
                // Şifreyi gizle
                txt_Password.PasswordChar = '*';
                txt_PasswordAgain.PasswordChar = '*';
                pictureBox1.Image = Resources.Kapali_Goz_Icon;

            }
            else
            {
                // Şifreyi göster
                txt_Password.PasswordChar = '\0';
                txt_PasswordAgain.PasswordChar = '\0';
                pictureBox1.Image = Resources.Acik_Goz_Icon;
            }

            // Durumu tersine çevir
            SifreGorunurMu = !SifreGorunurMu;
        }
    }
}
