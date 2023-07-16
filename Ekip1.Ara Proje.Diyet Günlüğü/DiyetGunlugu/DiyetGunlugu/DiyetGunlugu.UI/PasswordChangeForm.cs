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

    public partial class PasswordChangeForm : Form
    {
        public bool SifreGorunurMu { get; set; }
        public User activeUser { get; set; }
        public PasswordChangeForm(User user)
        {
            InitializeComponent();
            activeUser = user;
        }

        private void btn_Degistir_Click(object sender, EventArgs e)
        {
            try
            {
                UnitofWork.Instance.PasswordChangeBusiness.passwordChange(activeUser, txt_PresentPassword.Text, txt_NewPassword.Text);
                MessageBox.Show("Şifre değiştirildi");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (SifreGorunurMu)
            {
                // Şifreyi gizle
                txt_PresentPassword.PasswordChar = '*';
                txt_NewPasswordAgain.PasswordChar = '*';
                txt_NewPassword.PasswordChar = '*';
                pictureBox1.Image = Resources.Kapali_Goz_Icon;

            }
            else
            {
                // Şifreyi göster
                txt_PresentPassword.PasswordChar = '\0';
                txt_NewPasswordAgain.PasswordChar = '\0';
                txt_NewPassword.PasswordChar = '\0';
                pictureBox1.Image = Resources.Acik_Goz_Icon;
            }

            // Durumu tersine çevir
            SifreGorunurMu = !SifreGorunurMu;
        }

        private void txt_YeniSifre_TextChanged(object sender, EventArgs e)
        {
            pb_EightCharacter.Visible = UnitofWork.Instance.PasswordChangeBusiness.passwordControl(txt_NewPassword.Text).Eightcharacter;
            pb_UpperLowerCharacter.Visible = UnitofWork.Instance.PasswordChangeBusiness.passwordControl(txt_NewPassword.Text).UpperLowerCharacter;
            pb_SpecialCharacter.Visible = UnitofWork.Instance.PasswordChangeBusiness.passwordControl(txt_NewPassword.Text).SpecialCharacter;
        }
    }
}

