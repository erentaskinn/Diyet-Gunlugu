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
    public partial class FoodChangeForm : Form
    {

        private int eatingMealID;
        private List<string> veriler;
        public FoodChangeForm(int eatingMealID)
        {

            InitializeComponent();
            cmb_Foods.DataSource = UnitofWork.Instance.Foods.GetAll().ToList();
            cmb_Foods.DisplayMember = "FoodName";
            cmb_Foods.ValueMember = "ID";
            veriler = UnitofWork.Instance.Foods.GetAll().Select(x => x.FoodName).ToList();
            cmb_Foods.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmb_Foods.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cmb_Foods.AutoCompleteCustomSource.AddRange(veriler.ToArray());
            cmb_PortionTour.DisplayMember = "ServingGram";
            cmb_PortionTour.ValueMember = "ID";
            this.eatingMealID = eatingMealID;
            dgwFill();
        }

        private void cmb_Foods_SelectedIndexChanged(object sender, EventArgs e)
        {

            cmb_PortionTour.DataSource = UnitofWork.Instance.Serving.GetAll()
      .Where(x => x.FoodID == ((Foods)cmb_Foods.SelectedItem).ID)
      .Select(x => new
      {
          ID = x.ID,
          FoodID = x.FoodID,
          ServingGram = $"{(MeasurementTypes)x.MeasurementType} ({x.ServingGrams})"
      })
      .ToList();
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            var ChangeEatingMeal = UnitofWork.Instance.EatingMeal.GetById(eatingMealID);
            ChangeEatingMeal.Piece = (int)nud_Piece.Value;
            ChangeEatingMeal.ServingID = (int)cmb_PortionTour.SelectedValue;
            ChangeEatingMeal.Serving = (UnitofWork.Instance.Serving.GetAll()?.FirstOrDefault(x => x.ID == (int)cmb_PortionTour.SelectedValue));
            ChangeEatingMeal.Serving.FoodID = (int)cmb_Foods.SelectedValue;
            UnitofWork.Instance.EatingMeal.Update(ChangeEatingMeal);
            MessageBox.Show("eklendi");
            dgwFill();

        }
        /// <summary>
        /// FoodChangeForm üzerindeki datagridviewi dolduran metotdur.
        /// </summary>
        void dgwFill()
        {
            var query = UnitofWork.Instance.Foods.dgwFill(eatingMealID);
            if (query.ToList().Count > 0)
            {
                dgw_AddedMeals.DataSource = query.ToList();
                dgw_AddedMeals.Columns["ID"].Visible = false;
                dgw_AddedMeals.Columns["PORSİYONTÜRÜ"].HeaderText = "Porsiyon Türü";
                dgw_AddedMeals.Columns["Yemek_adı"].HeaderText = "Yemek Adı";
            }
        }

    }
}
