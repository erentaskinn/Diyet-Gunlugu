using DiyetGunlugu.BLL.UnitOfWork;
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
    public partial class ForgotPasswordForm : Form
    {
        private MODEL.Entity.User? user { get; set; }
        public ForgotPasswordForm()
        {
            InitializeComponent();
        }

        private void brn_NewPassword_Click(object sender, EventArgs e)
        {
            try
            {
                var person = UnitofWork.Instance.User.GetAll().FirstOrDefault(x => x.Email == txt_Email.Text);
                user = person;
                if (person != null)
                {
                    var newActivation = UnitofWork.Instance.User.RandomDigits(8);
                    if (UnitofWork.Instance.User.MailSend(txt_Email.Text, newActivation))
                    {
                        person.ActivationCode = newActivation;
                        UnitofWork.Instance.User.Update(person);
                        MessageBox.Show("Aktivasyon Kodunuz gönderildi");
                        txt_ActivationCode.Visible = true;
                        btn_ActivationCode.Visible = true;
                        lbl_ActivationCode.Visible = true;
                        btn_Newactivekod.Enabled = false;

                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void btn_ActivationCode_Click(object sender, EventArgs e)
        {
            if (user.ActivationCode == txt_ActivationCode.Text)
            {
                var ForgotPasswordChange = new ForgotPasswordChange(user);

                this.Hide();
                ForgotPasswordChange.ShowDialog();
                this.Close();

            }
            else
            {
                MessageBox.Show("Aktivasyon Kodu Yanlıştır");
            }
        }
    }
}
