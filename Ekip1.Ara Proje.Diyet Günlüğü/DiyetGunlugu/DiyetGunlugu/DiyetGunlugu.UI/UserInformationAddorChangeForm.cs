using DiyetGunlugu.BLL.UnitOfWork;
using DiyetGunlugu.MODEL.Entity;
using DiyetGunlugu.MODEL.Enums;
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
    public partial class UserInformationAddorChangeForm : Form
    {
        private User user { get; set; }
        private int userInformationID { get; set; }
        public UserInformationAddorChangeForm(User user)
        {
            InitializeComponent();
            cmbActivityLevel.DataSource = Enum.GetValues(typeof(ActivityLevel));
            this.user = user;
            btn_Update.Visible = false;
        }
        public UserInformationAddorChangeForm(int userInformationID)
        {
            InitializeComponent();
            cmbActivityLevel.DataSource = Enum.GetValues(typeof(ActivityLevel));
            btn_ProfileSave.Visible = false;
            this.userInformationID = userInformationID;
            InformationFill();
        }

        private void btn_ProfileSave_Click(object sender, EventArgs e)
        {
            try
            {
                var newWeight = new WeightChange()
                {
                    Time = DateTime.Now,
                    weight = (int)nud_Wieght.Value
                };
                var newUserInformation = new UserInformation()
                {
                    TargetWeight = (byte)nud_TargetWeight.Value,
                    UserID = user.ID,
                    NameSurname = txt_NameSurname.Text,
                    Height = Convert.ToByte(nud_Height.Value),
                    DateOfBirth = dtpDateofbirth.Value,
                    ActivityLevel = (ActivityLevel)cmbActivityLevel.SelectedItem,
                    Gender = rdbMan.Checked ? true : false
                };
                user.FirstLogin = false;
                UnitofWork.Instance.UserInformation.Add(newUserInformation);
                newWeight.UserInformationID = UnitofWork.Instance.UserInformation.GetAll().Last().ID;
                UnitofWork.Instance.WeightChangeRepository.Add(newWeight);
                UnitofWork.Instance.User.Update(user);
                MessageBox.Show("TEŞEKKÜRLER");
                var UserPanelForm = new UserPanelForm(user);
                this.Hide();
                UserPanelForm.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message); ;
            }
        }
        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                var newWeight = new WeightChange()
                {
                    UserInformationID = this.userInformationID,
                    Time = DateTime.Now,
                    weight = (int)nud_Wieght.Value
                };
                UnitofWork.Instance.WeightChangeRepository.Add(newWeight);
                var userinfo = UnitofWork.Instance.UserInformation.GetById(userInformationID);
                userinfo.NameSurname = txt_NameSurname.Text;
                userinfo.ActivityLevel = (ActivityLevel)cmbActivityLevel.SelectedItem;
                userinfo.TargetWeight = (byte)nud_TargetWeight.Value;
                userinfo.Height = Convert.ToByte(nud_Height.Value);
                userinfo.Gender = rdbMan.Checked ? true : false;
                userinfo.DateOfBirth = dtpDateofbirth.Value;
                UnitofWork.Instance.UserInformation.Update(userinfo);
                MessageBox.Show("bilgiler güncellendi");
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message); ;
            }
        }
        /// <summary>
        /// Kullanıcının bilgilerinin doldurulduğu metod.
        /// </summary>
        void InformationFill()
        {
            var userinfo = UnitofWork.Instance.UserInformation.GetById(userInformationID);
            txt_NameSurname.Text = userinfo.NameSurname;
            cmbActivityLevel.SelectedItem = userinfo.ActivityLevel;
            nud_TargetWeight.Value = Convert.ToByte(userinfo.TargetWeight);
            nud_Height.Value = Convert.ToByte(userinfo.Height);
            rdbMan.Checked = userinfo.Gender;
            rdbWoman.Checked = !userinfo.Gender;
            dtpDateofbirth.Value = userinfo.DateOfBirth;
            var wieght = UnitofWork.Instance.WeightChangeRepository.GetAll().Where(x => x.UserInformationID == userInformationID).Last();
            nud_Wieght.Value = (decimal)wieght.weight;
        }
    }
}
