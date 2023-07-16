using DiyetGunlugu.BLL.UnitOfWork;
using DiyetGunlugu.MODEL.Entity;
using OfficeOpenXml;
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
    public partial class ReportsForm : Form
    {

        private int userInformationID { get; set; }


        public ReportsForm(int userInfoID)
        {

            InitializeComponent();
            userInformationID = userInfoID;
            FıllDgvDailyReport();
            FıllDgvWeeksReport();
            ReportByFoodCategoryWeek();
            FıllDgvTheMostEateFoodTypeOf();
            FıllTheMostEatenFood();
            ReportByFoodCategoryMounth();
            FıllDgvMounthReport();

        }
        /// <summary>
        /// En çok yenen yemekleri tabloya getiren metod.
        /// </summary>
       
        private void FıllTheMostEatenFood()
        {
            var query = UnitofWork.Instance.ReportViewRepostroy.FıllTheMostEatenFood().ToList();
            if (query.ToList().Count > 0)
            {
                dgvEnCokYenenler.DataSource = query;
                dgvEnCokYenenler.Columns["FoodName"].HeaderText = "Yemek Adı";
                dgvEnCokYenenler.Columns["Total"].HeaderText = "Toplam Yenme Sayısı";
            }
            else
            {
                dgvHaftalıkYiyecegeGore.DataSource = null;
            }
        }
        /// <summary>
        /// Yemek türlerine göre en çok yenen yemekleri veren tabloyu dolduran metod.
        /// </summary>
        private void FıllDgvTheMostEateFoodTypeOf()
        {
            var query = UnitofWork.Instance.ReportViewRepostroy.FıllDgvTheMostEatenFoodTypeOf().ToList();
            if (query.ToList().Count > 0)
            {
                dgvOgunlerdeEnçokYenilen.DataSource = query;
                dgvOgunlerdeEnçokYenilen.Columns["FoodName"].HeaderText = "Yemek Adı";
                dgvOgunlerdeEnçokYenilen.Columns["Total"].HeaderText = "Toplam Yenme Sayısı";
                dgvOgunlerdeEnçokYenilen.Columns["MealTime"].HeaderText = "Öğün Zamanı";

            }
            else
            {
                dgvHaftalıkYiyecegeGore.DataSource = null;
            }
        }
        /// <summary>
        /// Haftalık rapor tablosunu dolduran metod
        /// </summary>
        private void FıllDgvWeeksReport()
        {
            var query = UnitofWork.Instance.ReportViewRepostroy.FıllDgvWeekRepor(userInformationID,dtpHafalıkReport.Value).ToList();
            if (query.ToList().Count > 0)
            {
                dgvHaftalıkRapor.DataSource = query;
                dgvHaftalıkRapor.Columns["UserinfoID"].Visible = false;
                dgvHaftalıkRapor.Columns["NameSurname"].HeaderText = "Ad Soyad";
                dgvHaftalıkRapor.Columns["EatingMealTime"].HeaderText = "Son Gösterilen Gün Tarihi";
            }
            else
            {
                dgvHaftalıkYiyecegeGore.DataSource = null;
            }
        }
        /// <summary>
        /// Günlük rapor tablosunu dolduran metod
        /// </summary>
        private void FıllDgvDailyReport()
        {
            var query = UnitofWork.Instance.ReportViewRepostroy.FıllDgvDailyReport(userInformationID, dtpGunlukRapor.Value).ToList();
            if (query.ToList().Count > 0)
            {
                dgvGunlukRapor.DataSource = query;
                dgvGunlukRapor.Columns["MealTime"].HeaderText = "Öğün Zamanı";
                dgvGunlukRapor.Columns["EatingMealTime"].HeaderText = "Son Gösterilen Gün Tarihi";
            }
            else
            {
                dgvHaftalıkYiyecegeGore.DataSource = null;
            }
        }
        /// <summary>
        /// Haftalık kategoriye göre yemekleri gösteren tabloyu dolduran metod.
        /// </summary>
        private void ReportByFoodCategoryWeek()
        {
            var query = UnitofWork.Instance.ReportViewRepostroy.ReportByFoodCategoryWeek(userInformationID,dtpHafalıkReport.Value).ToList();
            if (query.ToList().Count > 0)
            {
                dgvHaftalıkYiyecegeGore.DataSource = query;
                dgvHaftalıkYiyecegeGore.Columns["UserinfoID"].Visible = false;
                dgvHaftalıkYiyecegeGore.Columns["TypeOfFood"].HeaderText = "Yemek Tipi";
                dgvHaftalıkYiyecegeGore.Columns["NameSurname"].HeaderText = "Ad Soyad";
                dgvHaftalıkYiyecegeGore.Columns["EatingMealTime"].HeaderText = "Son Gösterilen Gün Tarihi";
            }
            else
            {
                dgvHaftalıkYiyecegeGore.DataSource = null;
            }

        }
        /// <summary>
        /// Aylık yenilen yemeklerin kategoriye göre gösteren tabloyu dolduran metod.
        /// </summary>
        private void ReportByFoodCategoryMounth()
        {
            var query = UnitofWork.Instance.ReportViewRepostroy.ReportByFoodCategoryMounth(userInformationID, dtpAylıkRapor.Value).ToList();
            if (query.ToList().Count > 0)
            {
                dgvAylıkKategoriyeGore.DataSource = query;
                dgvAylıkKategoriyeGore.Columns["UserinfoID"].Visible = false;
                dgvAylıkKategoriyeGore.Columns["TypeOfFood"].HeaderText = "Yemek Tipi";
                dgvAylıkKategoriyeGore.Columns["NameSurname"].HeaderText = "Ad Soyad";
                dgvAylıkKategoriyeGore.Columns["EatingMealTime"].HeaderText = "Son Gösterilen Gün Tarihi";
            }
            else
            {
                dgvHaftalıkYiyecegeGore.DataSource = null;
            }

        }
        /// <summary>
        /// Aylık yenilen yemekleri gösteren tabloyu dolduran metod.
        /// </summary>
        private void FıllDgvMounthReport()
        {
            var query = UnitofWork.Instance.ReportViewRepostroy.FıllDgvMounthReport(userInformationID, dtpAylıkRapor.Value).ToList();
            if (query.ToList().Count > 0)
            {
                dgvAylıkRapor.DataSource = query;
                dgvAylıkRapor.Columns["UserinfoID"].Visible = false;
                dgvAylıkRapor.Columns["NameSurname"].HeaderText = "Ad Soyad";
                dgvAylıkRapor.Columns["EatingMealTime"].HeaderText = "Son Gösterilen Gün Tarihi";
            }
            else
            {
                dgvHaftalıkYiyecegeGore.DataSource = null;
            }
        }
        /// <summary>
        /// Raporları excele aktaran metod.
        /// </summary>
        /// <param name="dataGridView"></param>
        private void ExportToExcel(DataGridView dataGridView)
        {
            using (ExcelPackage excelPackage = new ExcelPackage())
            {



                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Sheet1");

                // DataGridView'deki verileri Excel'e aktar
                for (int i = 0; i < dataGridView.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1].Value = dataGridView.Columns[i].HeaderText;
                }

                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1].Value = dataGridView.Rows[i].Cells[j].Value;
                    }
                }

                // Excel dosyasını kaydet
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileInfo fileInfo = new FileInfo(saveFileDialog.FileName);
                    excelPackage.SaveAs(fileInfo);
                    MessageBox.Show("Excel dosyası başarıyla kaydedildi.");
                }
            }
        }



        private void dtpGunlukRapor_ValueChanged(object sender, EventArgs e)
        {
            dgvGunlukRapor.DataSource = null;
            FıllDgvDailyReport();
        }



        private void dtpHafalıkReport_ValueChanged(object sender, EventArgs e)
        {
            dgvHaftalıkRapor.DataSource = null;
            dgvHaftalıkYiyecegeGore.DataSource = null;
            FıllDgvWeeksReport();
            ReportByFoodCategoryWeek();
        }

        private void dtpAylıkRapor_ValueChanged(object sender, EventArgs e)
        {
            dgvAylıkRapor.DataSource = null;
            dgvAylıkKategoriyeGore.DataSource = null;
            ReportByFoodCategoryMounth();
            FıllDgvMounthReport();
        }

        private void btnGunlukRaporExcekAktar_Click(object sender, EventArgs e)
        {
            ExportToExcel(dgvGunlukRapor);
        }

        private void btnHafRaporExcAktar_Click(object sender, EventArgs e)
        {
            ExportToExcel(dgvHaftalıkRapor);
        }

        private void btnHafKateGöreExceleAktar_Click(object sender, EventArgs e)
        {
            ExportToExcel(dgvHaftalıkYiyecegeGore);

        }

        private void btnAylıkExceleAkatr_Click(object sender, EventArgs e)
        {
            ExportToExcel(dgvAylıkRapor);
        }

        private void brnKatGörAylıkRapExcAktar_Click(object sender, EventArgs e)
        {
            ExportToExcel(dgvAylıkKategoriyeGore);
        }

        private void btnOgunEnCokYenılenRaporAktar_Click(object sender, EventArgs e)
        {
            ExportToExcel(dgvOgunlerdeEnçokYenilen);
        }

        private void btnBestYenenExceleAktar_Click(object sender, EventArgs e)
        {
            ExportToExcel(dgvEnCokYenenler);
        }


    }

}

