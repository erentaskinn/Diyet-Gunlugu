using DiyetGunlugu.BLL.UnitOfWork;
using DiyetGunlugu.MODEL.Entity;
using FormOgunGosterim;
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
    public partial class UserPanelForm : Form
    {
        private User _user;
        private int userInformationID { get; set; }
        public UserPanelForm(MODEL.Entity.User user)
        {
            InitializeComponent();
            _user = user;
            userInformationID = UnitofWork.Instance.User.userinfoID(user);
            dgv_foodtodayfill();
            progresbarFill();
            pb_Calory.BackColor = Color.SeaShell;
        }
        /// <summary>
        /// Günlükmyediği yemekleri gösteren tabloyu dolduran metod
        /// </summary>
        void dgv_foodtodayfill()
        {
            var query = UnitofWork.Instance.UserInformation.Foodtodayfill(userInformationID).ToList();
            dgv_foodtoday.DataSource = query;
            if (query.Count > 0)
            {
                dgv_foodtoday.Columns["ID"].Visible = false;
                dgv_foodtoday.Columns["porsiyon_turu"].HeaderText = "Porsiyon Türü";
            }

        }
        private void btn_FoodAdd_Click(object sender, EventArgs e)
        {
            var FoodListForm = new FoodListForm(userInformationID);
            this.Hide();
            FoodListForm.ShowDialog();
            this.Show();
            dgv_foodtodayfill();
            progresbarFill();
        }
        /// <summary>
        /// Toplam günlükm aldığı kalori metodu
        /// </summary>
        /// <returns></returns>
        int totalTodayCalory()
        {
            int total = 0;
            for (int i = 0; i < dgv_foodtoday.Rows.Count; i++)
            {
                int value = Convert.ToInt32(dgv_foodtoday.Rows[i].Cells["Calory"].Value);
                total += value;
            }
            return total;
        }
        /// <summary>
        /// Progres barın durumunu gösteren metod.Aldığı kaloriye göre progres barın dolumunu gösteren metod.
        /// </summary>
        void progresbarFill()
        {
            var ColoriNeed = UnitofWork.Instance.UserInformation.coloriNeed(UnitofWork.Instance.UserInformation.GetById(userInformationID));
            pb_Calory.Maximum = ColoriNeed;
            lbl_NeedMaxcalory.Text = ColoriNeed.ToString();
            if (totalTodayCalory() > pb_Calory.Maximum)
            {
                pb_Calory.Value = pb_Calory.Maximum;
                pb_Calory.ForeColor = Color.Red;
            }
            else
            {
                pb_Calory.Value = totalTodayCalory();
                pb_Calory.ForeColor = Color.Green;
            }

            lbl_TodayCalory.Text = totalTodayCalory().ToString();
        }


        private void şifreDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var PasswordChangeForm = new PasswordChangeForm(_user);
            PasswordChangeForm.ShowDialog();
            progresbarFill();
            this.Show();
        }

        private void kullanıcıBilgileriniDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var userInformationAddorChangeForm = new UserInformationAddorChangeForm(userInformationID);
            userInformationAddorChangeForm.ShowDialog();
            progresbarFill();
            this.Show();
        }

        private void raporlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var userInformationAddorChangeForm = new ReportsForm(userInformationID);
            userInformationAddorChangeForm.ShowDialog();
            this.Show();
        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
            LoginForm LoginForm = new LoginForm();
            LoginForm.ShowDialog();

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
