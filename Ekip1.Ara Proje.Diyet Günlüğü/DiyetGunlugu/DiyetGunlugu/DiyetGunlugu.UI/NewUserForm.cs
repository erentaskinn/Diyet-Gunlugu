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
using static System.Net.Mime.MediaTypeNames;

namespace DiyetGunlugu.UI
{
    public partial class NewUserForm : Form
    {
        public bool SifreGorunurMu { get; set; }

        public NewUserForm()
        {
            InitializeComponent();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            try
            {

                var person = UnitofWork.Instance.User.GetAll().FirstOrDefault(x => x.Email == txt_Email.Text);
                UnitofWork.Instance.PasswordChangeBusiness.NewUser(txt_Password.Text, txt_PasswordAgain.Text);
                if (person == null)
                {
                    var newuser = new MODEL.Entity.User()
                    {
                        Email = txt_Email.Text,
                        Password = UnitofWork.Instance.PasswordChangeBusiness.SHA256Encode(txt_Password.Text),
                    };
                    UnitofWork.Instance.User.Add(newuser);
                    MessageBox.Show("Kullanıcı Başarıyla eklendi");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Mevcut Personel Sistemde Kayıtlıdır");
                }
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

        private void txt_Password_TextChanged(object sender, EventArgs e)
        {
            pb_EightCharacter.Visible = UnitofWork.Instance.PasswordChangeBusiness.passwordControl(txt_Password.Text).Eightcharacter;
            pb_UpperLowerCharacter.Visible = UnitofWork.Instance.PasswordChangeBusiness.passwordControl(txt_Password.Text).UpperLowerCharacter;
            pb_SpecialCharacter.Visible = UnitofWork.Instance.PasswordChangeBusiness.passwordControl(txt_Password.Text).SpecialCharacter;
        }
    }
}
