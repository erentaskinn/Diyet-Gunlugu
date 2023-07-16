using DiyetGunlugu.BLL.UnitOfWork;
using DiyetGunlugu.MODEL.Entity;
using DiyetGunlugu.UI;
using System.Windows.Forms;

namespace FormOgunGosterim
{
    public partial class FoodListForm : Form
    {
        public int userinfoID { get; set; }
        public FoodListForm(int userinfoID)
        {
            InitializeComponent();
            this.userinfoID = userinfoID;
            DgwBreakfastFill();
            DgwDinnerFill();
            DgwSnackFill();
            DgwLunchFill();
        }
        /// <summary>
        /// Yiyeceklerin listelendiði formdaki Öðle yemekelerini gösteren tabloyu dolduran metoddur.
        /// </summary>
        private void DgwLunchFill()
        {
            var query = UnitofWork.Instance.Foods.DgwFoodListFill(DiyetGunlugu.MODEL.Enums.Mealstime.Lunch, dtpLunch.Value, userinfoID);
            dgwLunch.DataSource = query.ToList();
            if (query.ToList().Count > 0)
            {
                dgwLunch.Columns["ID"].Visible = false;
                dgwLunch.Columns["porsiyon_turu"].HeaderText = "Porsiyon Türü";
            }
        }
        /// <summary>
        ///  Yiyeceklerin listelendiði formdaki Ara Öðünün yemekelerini gösteren tabloyu dolduran metoddur.
        /// </summary>
        private void DgwSnackFill()
        {
            var query = UnitofWork.Instance.Foods.DgwFoodListFill(DiyetGunlugu.MODEL.Enums.Mealstime.Snack, dtpSnack.Value, userinfoID);
            dgwSnack.DataSource = query.ToList();
            if (query.ToList().Count > 0)
            {
                dgwSnack.Columns["ID"].Visible = false;
                dgwSnack.Columns["porsiyon_turu"].HeaderText = "Porsiyon Türü";
            }
        }
        /// <summary>
        /// Yiyeceklerin listelendiði formdaki Akþam yemeðinin yemekelerini gösteren tabloyu dolduran metoddur.
        /// </summary>
        private void DgwDinnerFill()
        {

            var query = UnitofWork.Instance.Foods.DgwFoodListFill(DiyetGunlugu.MODEL.Enums.Mealstime.Dinner, dtpDinner.Value, userinfoID);
            dgwDinner.DataSource = query.ToList();
            if (query.ToList().Count > 0)
            {
                dgwDinner.Columns["ID"].Visible = false;
                dgwDinner.Columns["porsiyon_turu"].HeaderText = "Porsiyon Türü";
            }
        }
        /// <summary>
        /// Yiyeceklerin listelendiði formdaki kahvaltý öðününün yemekelrini gösteren tabloyu dolduran metoddur.
        /// </summary>
        private void DgwBreakfastFill()
        {
            var query = UnitofWork.Instance.Foods.DgwFoodListFill(DiyetGunlugu.MODEL.Enums.Mealstime.Breakfast, dtpBreakfast.Value, userinfoID);
            dgwBreakfast.DataSource = query.ToList();
            if (query.ToList().Count > 0)
            {
                dgwBreakfast.Columns["ID"].Visible = false;
                dgwBreakfast.Columns["porsiyon_turu"].HeaderText = "Porsiyon Türü";
            }
        }
        private void dtpBreakfast_ValueChanged(object sender, EventArgs e)
        {
            dgwLunch.DataSource = null;
            DgwBreakfastFill();
        }

        private void dtpLunch_ValueChanged(object sender, EventArgs e)
        {
            dgwLunch.DataSource = null;
            DgwLunchFill();
        }

        private void dtpSnack_ValueChanged(object sender, EventArgs e)
        {
            dgwLunch.DataSource = null;
            DgwSnackFill();
        }

        private void dtpDinner_ValueChanged(object sender, EventArgs e)
        {
            dgwLunch.DataSource = null;
            DgwDinnerFill();
        }

        private void btnLunchAdd_Click_1(object sender, EventArgs e)
        {
            var form1 = new FoodAddForm(userinfoID, DiyetGunlugu.MODEL.Enums.Mealstime.Lunch, dtpLunch.Value);
            form1.ShowDialog();
            this.Show();
            DgwLunchFill();
        }

        private void cmsLunchSil_Click(object sender, EventArgs e)
        {
            var seciliId = (int)dgwLunch.SelectedRows[0].Cells["ID"].Value;
            UnitofWork.Instance.EatingMeal.Remove(seciliId);
            DgwLunchFill();
        }



        private void btnBreakfastAdd_Click_1(object sender, EventArgs e)
        {
            var form1 = new FoodAddForm(userinfoID, DiyetGunlugu.MODEL.Enums.Mealstime.Breakfast, dtpBreakfast.Value);
            form1.ShowDialog();
            this.Show();
            DgwBreakfastFill();
        }

        private void btnDreamMealAdd_Click_1(object sender, EventArgs e)
        {
            var form1 = new FoodAddForm(userinfoID, DiyetGunlugu.MODEL.Enums.Mealstime.Snack, dtpSnack.Value);
            form1.ShowDialog();
            this.Show();
            DgwSnackFill();
        }

        private void btnDinnerAdd_Click_1(object sender, EventArgs e)
        {
            var form1 = new FoodAddForm(userinfoID, DiyetGunlugu.MODEL.Enums.Mealstime.Dinner, dtpDinner.Value);
            form1.ShowDialog();
            this.Show();
            DgwDinnerFill();
        }

        private void SilBreakfast_Click(object sender, EventArgs e)
        {
            var seciliId = (int)dgwBreakfast.SelectedRows[0].Cells["ID"].Value;
            UnitofWork.Instance.EatingMeal.Remove(seciliId);
            DgwBreakfastFill();
        }

        private void stmSnacSil_Click(object sender, EventArgs e)
        {
            var seciliId = (int)dgwSnack.SelectedRows[0].Cells["ID"].Value;
            UnitofWork.Instance.EatingMeal.Remove(seciliId);
            DgwSnackFill();
        }

        private void stmSilDinner_Click(object sender, EventArgs e)
        {
            var seciliId = (int)dgwDinner.SelectedRows[0].Cells["ID"].Value;
            UnitofWork.Instance.EatingMeal.Remove(seciliId);
            DgwDinnerFill();
        }

        private void smsDüzenleBreakfast_Click(object sender, EventArgs e)
        {

            var form1 = new FoodChangeForm((int)dgwBreakfast.SelectedRows[0].Cells["ID"].Value);
            form1.ShowDialog();
            this.Show();
            DgwBreakfastFill();
        }

        private void smtDüzenleSnack_Click(object sender, EventArgs e)
        {
            var form1 = new FoodChangeForm((int)dgwSnack.SelectedRows[0].Cells["ID"].Value);
            form1.ShowDialog();
            this.Show();
            DgwSnackFill();
        }

        private void smtDnnerDüzenle_Click(object sender, EventArgs e)
        {
            var form1 = new FoodChangeForm((int)dgwDinner.SelectedRows[0].Cells["ID"].Value);
            form1.ShowDialog();
            this.Show();
            DgwDinnerFill();
        }

        private void smtDüzenleLunch_Click(object sender, EventArgs e)
        {
            var form1 = new FoodChangeForm((int)dgwLunch.SelectedRows[0].Cells["ID"].Value);
            form1.ShowDialog();
            this.Show();
            DgwLunchFill();
        }


    }
}