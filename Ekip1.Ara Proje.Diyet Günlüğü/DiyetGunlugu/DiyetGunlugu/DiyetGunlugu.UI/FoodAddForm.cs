using DiyetGunlugu.BLL;
using DiyetGunlugu.BLL.UnitOfWork;
using DiyetGunlugu.MODEL.Entity;
using DiyetGunlugu.MODEL.Enums;

namespace DiyetGunlugu.UI
{
    public partial class FoodAddForm : Form
    {
        private List<string> veriler;
        private List<EatingMeal> data;
        private Mealstime mealsTime;
        private DateTime eatTime;
        private int userinfoID;

        public FoodAddForm(int userinfoID, MODEL.Enums.Mealstime mealsTime, DateTime eatTime)
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
            cmb_PortionTour.Enabled = false;
            this.mealsTime = mealsTime;
            this.eatTime = eatTime;
            this.userinfoID = userinfoID;
        }
        
        private void btn_Add_Click(object sender, EventArgs e)
        {
            var eatingMeals = new EatingMeal
            {

                EatingMealTime = eatTime,
                MealTime = mealsTime,
                Piece = (int)nud_Piece.Value,
                UserInformationID = userinfoID,
                CreateUserID = userinfoID,
                UserInformation = UnitofWork.Instance.UserInformation.GetAll().FirstOrDefault(x => x.ID == userinfoID),
                ServingID = (int)cmb_PortionTour.SelectedValue,
                Serving = (UnitofWork.Instance.Serving.GetAll()?.FirstOrDefault(x => x.ID == (int)cmb_PortionTour.SelectedValue))
            };

            if (this.data is null)
            {
                data = new List<EatingMeal>();
            }

            data.Add(eatingMeals);
            DataSourceUpdate();


        }

        private void cmb_Foods_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_PortionTour.Enabled = true;
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

        /// <summary>
        /// Formdaki tabloyu doldurmak için kullanılan metotdur.
        /// </summary>
        private void DataSourceUpdate()
        {
            dgw_AddedMeals.DataSource = null;
            dgw_AddedMeals.DataSource = data.Select(x => new
            {
                yemek = UnitofWork.Instance.Foods.GetAll().FirstOrDefault(y => y.ID == (x.Serving.FoodID)).FoodName,
                Meal = x.MealTime,
                Piece = x.Piece,
                Yağ = UnitofWork.Instance.Foods.GetAll().FirstOrDefault(y => y.ID == (x.Serving.FoodID)).Fat * x.Serving.ServingGrams,
                Karbonhidrat = UnitofWork.Instance.Foods.GetAll().FirstOrDefault(y => y.ID == (x.Serving.FoodID)).Carbohydrate * x.Serving.ServingGrams,
                Protein = UnitofWork.Instance.Foods.GetAll().FirstOrDefault(y => y.ID == (x.Serving.FoodID)).Protein * x.Serving.ServingGrams,
                Kalori = (UnitofWork.Instance.Foods.GetAll().FirstOrDefault(y => y.ID == (x.Serving.FoodID)).Protein// kalori metodu yaz
                          * 4 * x.Serving.ServingGrams
                          + UnitofWork.Instance.Foods.GetAll().FirstOrDefault(y => y.ID == (x.Serving.FoodID)).Carbohydrate
                          * 4 * x.Serving.ServingGrams
                          + UnitofWork.Instance.Foods.GetAll().FirstOrDefault(y => y.ID == (x.Serving.FoodID)).Fat
                          * 9 * x.Serving.ServingGrams) * x.Piece

            }).ToList();


            dgw_AddedMeals.Columns["Piece"].HeaderText = "Adet";
            dgw_AddedMeals.Columns["yemek"].HeaderText = "Yemek Adı";
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (data is not null)
            {
                foreach (var item in data)
                {
                    UnitofWork.Instance.EatingMeal.Add(item);
                }
                dgw_AddedMeals.DataSource = null;
                data = null;
                MessageBox.Show("kayıt eklendi");
            }
            else
            {
                MessageBox.Show("lütfen yemek ekleyin");
            }

        }
    }
}
