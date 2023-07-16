namespace DiyetGunlugu.UI
{
    partial class ReportsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            REPORT = new TabControl();
            tabPage1 = new TabPage();
            label3 = new Label();
            btnGunlukRaporExcekAktar = new Button();
            dtpGunlukRapor = new DateTimePicker();
            dgvGunlukRapor = new DataGridView();
            tabPage2 = new TabPage();
            btnHafKateGöreExceleAktar = new Button();
            btnHafRaporExcAktar = new Button();
            label2 = new Label();
            label1 = new Label();
            dgvHaftalıkYiyecegeGore = new DataGridView();
            dtpHafalıkReport = new DateTimePicker();
            dgvHaftalıkRapor = new DataGridView();
            tabPage3 = new TabPage();
            brnKatGörAylıkRapExcAktar = new Button();
            btnAylıkExceleAkatr = new Button();
            label7 = new Label();
            label4 = new Label();
            dtpAylıkRapor = new DateTimePicker();
            dgvAylıkKategoriyeGore = new DataGridView();
            dgvAylıkRapor = new DataGridView();
            tabPage4 = new TabPage();
            btnBestYenenExceleAktar = new Button();
            btnOgunEnCokYenılenRaporAktar = new Button();
            label6 = new Label();
            label5 = new Label();
            dgvOgunlerdeEnçokYenilen = new DataGridView();
            dgvEnCokYenenler = new DataGridView();
            REPORT.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGunlukRapor).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHaftalıkYiyecegeGore).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvHaftalıkRapor).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAylıkKategoriyeGore).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAylıkRapor).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOgunlerdeEnçokYenilen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEnCokYenenler).BeginInit();
            SuspendLayout();
            // 
            // REPORT
            // 
            REPORT.Controls.Add(tabPage1);
            REPORT.Controls.Add(tabPage2);
            REPORT.Controls.Add(tabPage3);
            REPORT.Controls.Add(tabPage4);
            REPORT.Dock = DockStyle.Fill;
            REPORT.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            REPORT.Location = new Point(0, 0);
            REPORT.Name = "REPORT";
            REPORT.SelectedIndex = 0;
            REPORT.Size = new Size(906, 576);
            REPORT.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackgroundImage = Properties.Resources.Custom_Designed_Illustrations___897818__Printable_Illustrations___Creativa_Fabrica;
            tabPage1.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(btnGunlukRaporExcekAktar);
            tabPage1.Controls.Add(dtpGunlukRapor);
            tabPage1.Controls.Add(dgvGunlukRapor);
            tabPage1.Location = new Point(4, 26);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(898, 546);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Günlük";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(112, 14);
            label3.Name = "label3";
            label3.Size = new Size(155, 19);
            label3.TabIndex = 6;
            label3.Text = "Günlük Rapor Tablosu";
            // 
            // btnGunlukRaporExcekAktar
            // 
            btnGunlukRaporExcekAktar.BackColor = Color.SeaShell;
            btnGunlukRaporExcekAktar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGunlukRaporExcekAktar.Location = new Point(247, 496);
            btnGunlukRaporExcekAktar.Name = "btnGunlukRaporExcekAktar";
            btnGunlukRaporExcekAktar.Size = new Size(126, 31);
            btnGunlukRaporExcekAktar.TabIndex = 5;
            btnGunlukRaporExcekAktar.Text = "Excel'e Aktar";
            btnGunlukRaporExcekAktar.UseVisualStyleBackColor = false;
            btnGunlukRaporExcekAktar.Click += btnGunlukRaporExcekAktar_Click;
            // 
            // dtpGunlukRapor
            // 
            dtpGunlukRapor.Location = new Point(98, 40);
            dtpGunlukRapor.Name = "dtpGunlukRapor";
            dtpGunlukRapor.Size = new Size(183, 25);
            dtpGunlukRapor.TabIndex = 4;
            dtpGunlukRapor.ValueChanged += dtpGunlukRapor_ValueChanged;
            // 
            // dgvGunlukRapor
            // 
            dgvGunlukRapor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGunlukRapor.BackgroundColor = Color.SeaShell;
            dgvGunlukRapor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGunlukRapor.Location = new Point(16, 71);
            dgvGunlukRapor.Name = "dgvGunlukRapor";
            dgvGunlukRapor.RowTemplate.Height = 25;
            dgvGunlukRapor.Size = new Size(357, 417);
            dgvGunlukRapor.TabIndex = 2;
            // 
            // tabPage2
            // 
            tabPage2.BackgroundImage = Properties.Resources.Custom_Designed_Illustrations___897818__Printable_Illustrations___Creativa_Fabrica;
            tabPage2.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage2.Controls.Add(btnHafKateGöreExceleAktar);
            tabPage2.Controls.Add(btnHafRaporExcAktar);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(dgvHaftalıkYiyecegeGore);
            tabPage2.Controls.Add(dtpHafalıkReport);
            tabPage2.Controls.Add(dgvHaftalıkRapor);
            tabPage2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tabPage2.Location = new Point(4, 26);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(898, 546);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Haftalık";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnHafKateGöreExceleAktar
            // 
            btnHafKateGöreExceleAktar.BackColor = Color.SeaShell;
            btnHafKateGöreExceleAktar.Location = new Point(697, 496);
            btnHafKateGöreExceleAktar.Name = "btnHafKateGöreExceleAktar";
            btnHafKateGöreExceleAktar.Size = new Size(189, 41);
            btnHafKateGöreExceleAktar.TabIndex = 6;
            btnHafKateGöreExceleAktar.Text = "Haftalık Kategoriye Göre Raporu Excel'e Aktar";
            btnHafKateGöreExceleAktar.UseVisualStyleBackColor = false;
            btnHafKateGöreExceleAktar.Click += btnHafKateGöreExceleAktar_Click;
            // 
            // btnHafRaporExcAktar
            // 
            btnHafRaporExcAktar.BackColor = Color.SeaShell;
            btnHafRaporExcAktar.Location = new Point(247, 496);
            btnHafRaporExcAktar.Name = "btnHafRaporExcAktar";
            btnHafRaporExcAktar.Size = new Size(126, 32);
            btnHafRaporExcAktar.TabIndex = 5;
            btnHafRaporExcAktar.Text = "Excel'e Aktar";
            btnHafRaporExcAktar.UseVisualStyleBackColor = false;
            btnHafRaporExcAktar.Click += btnHafRaporExcAktar_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(486, 24);
            label2.Name = "label2";
            label2.Size = new Size(359, 23);
            label2.TabIndex = 4;
            label2.Text = "Haftalık Kalori Tablosu Yiyecek katogorisine göre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(90, 28);
            label1.Name = "label1";
            label1.Size = new Size(161, 19);
            label1.TabIndex = 3;
            label1.Text = "Haftalık Kalori Tablosu";
            // 
            // dgvHaftalıkYiyecegeGore
            // 
            dgvHaftalıkYiyecegeGore.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHaftalıkYiyecegeGore.BackgroundColor = Color.SeaShell;
            dgvHaftalıkYiyecegeGore.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHaftalıkYiyecegeGore.Location = new Point(401, 61);
            dgvHaftalıkYiyecegeGore.Name = "dgvHaftalıkYiyecegeGore";
            dgvHaftalıkYiyecegeGore.RowHeadersVisible = false;
            dgvHaftalıkYiyecegeGore.RowTemplate.Height = 25;
            dgvHaftalıkYiyecegeGore.Size = new Size(485, 429);
            dgvHaftalıkYiyecegeGore.TabIndex = 2;
            // 
            // dtpHafalıkReport
            // 
            dtpHafalıkReport.Location = new Point(280, 24);
            dtpHafalıkReport.Name = "dtpHafalıkReport";
            dtpHafalıkReport.Size = new Size(200, 23);
            dtpHafalıkReport.TabIndex = 1;
            dtpHafalıkReport.ValueChanged += dtpHafalıkReport_ValueChanged;
            // 
            // dgvHaftalıkRapor
            // 
            dgvHaftalıkRapor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHaftalıkRapor.BackgroundColor = Color.SeaShell;
            dgvHaftalıkRapor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHaftalıkRapor.Location = new Point(16, 61);
            dgvHaftalıkRapor.Name = "dgvHaftalıkRapor";
            dgvHaftalıkRapor.RowTemplate.Height = 25;
            dgvHaftalıkRapor.Size = new Size(357, 429);
            dgvHaftalıkRapor.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.BackgroundImage = Properties.Resources.Custom_Designed_Illustrations___897818__Printable_Illustrations___Creativa_Fabrica;
            tabPage3.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage3.Controls.Add(brnKatGörAylıkRapExcAktar);
            tabPage3.Controls.Add(btnAylıkExceleAkatr);
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(label4);
            tabPage3.Controls.Add(dtpAylıkRapor);
            tabPage3.Controls.Add(dgvAylıkKategoriyeGore);
            tabPage3.Controls.Add(dgvAylıkRapor);
            tabPage3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tabPage3.Location = new Point(4, 26);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(898, 546);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Aylık";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // brnKatGörAylıkRapExcAktar
            // 
            brnKatGörAylıkRapExcAktar.BackColor = Color.SeaShell;
            brnKatGörAylıkRapExcAktar.Location = new Point(692, 497);
            brnKatGörAylıkRapExcAktar.Name = "brnKatGörAylıkRapExcAktar";
            brnKatGörAylıkRapExcAktar.Size = new Size(189, 41);
            brnKatGörAylıkRapExcAktar.TabIndex = 6;
            brnKatGörAylıkRapExcAktar.Text = "Aylık Kategoriye Göre Raporu Excel'e Aktar";
            brnKatGörAylıkRapExcAktar.UseVisualStyleBackColor = false;
            brnKatGörAylıkRapExcAktar.Click += brnKatGörAylıkRapExcAktar_Click;
            // 
            // btnAylıkExceleAkatr
            // 
            btnAylıkExceleAkatr.BackColor = Color.SeaShell;
            btnAylıkExceleAkatr.Location = new Point(246, 501);
            btnAylıkExceleAkatr.Name = "btnAylıkExceleAkatr";
            btnAylıkExceleAkatr.Size = new Size(126, 32);
            btnAylıkExceleAkatr.TabIndex = 5;
            btnAylıkExceleAkatr.Text = "Excel'e Aktar";
            btnAylıkExceleAkatr.UseVisualStyleBackColor = false;
            btnAylıkExceleAkatr.Click += btnAylıkExceleAkatr_Click;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(522, 30);
            label7.Name = "label7";
            label7.Size = new Size(271, 29);
            label7.TabIndex = 4;
            label7.Text = "Aylık Rapor Tablosu Kategoriye Göre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(102, 30);
            label4.Name = "label4";
            label4.Size = new Size(143, 19);
            label4.TabIndex = 3;
            label4.Text = "Aylık Rapor Tablosu";
            // 
            // dtpAylıkRapor
            // 
            dtpAylıkRapor.Location = new Point(289, 26);
            dtpAylıkRapor.Name = "dtpAylıkRapor";
            dtpAylıkRapor.Size = new Size(200, 23);
            dtpAylıkRapor.TabIndex = 2;
            dtpAylıkRapor.ValueChanged += dtpAylıkRapor_ValueChanged;
            // 
            // dgvAylıkKategoriyeGore
            // 
            dgvAylıkKategoriyeGore.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAylıkKategoriyeGore.BackgroundColor = Color.SeaShell;
            dgvAylıkKategoriyeGore.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAylıkKategoriyeGore.Location = new Point(396, 62);
            dgvAylıkKategoriyeGore.Name = "dgvAylıkKategoriyeGore";
            dgvAylıkKategoriyeGore.RowTemplate.Height = 25;
            dgvAylıkKategoriyeGore.Size = new Size(485, 429);
            dgvAylıkKategoriyeGore.TabIndex = 1;
            // 
            // dgvAylıkRapor
            // 
            dgvAylıkRapor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAylıkRapor.BackgroundColor = Color.SeaShell;
            dgvAylıkRapor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAylıkRapor.Location = new Point(15, 62);
            dgvAylıkRapor.Name = "dgvAylıkRapor";
            dgvAylıkRapor.RowTemplate.Height = 25;
            dgvAylıkRapor.Size = new Size(357, 429);
            dgvAylıkRapor.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.BackgroundImage = Properties.Resources.Custom_Designed_Illustrations___897818__Printable_Illustrations___Creativa_Fabrica;
            tabPage4.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage4.Controls.Add(btnBestYenenExceleAktar);
            tabPage4.Controls.Add(btnOgunEnCokYenılenRaporAktar);
            tabPage4.Controls.Add(label6);
            tabPage4.Controls.Add(label5);
            tabPage4.Controls.Add(dgvOgunlerdeEnçokYenilen);
            tabPage4.Controls.Add(dgvEnCokYenenler);
            tabPage4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tabPage4.Location = new Point(4, 26);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(898, 546);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Favoriler";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnBestYenenExceleAktar
            // 
            btnBestYenenExceleAktar.BackColor = Color.SeaShell;
            btnBestYenenExceleAktar.Location = new Point(691, 491);
            btnBestYenenExceleAktar.Name = "btnBestYenenExceleAktar";
            btnBestYenenExceleAktar.Size = new Size(189, 41);
            btnBestYenenExceleAktar.TabIndex = 5;
            btnBestYenenExceleAktar.Text = "Best Yenen Yemekleri Excele Aktar";
            btnBestYenenExceleAktar.UseVisualStyleBackColor = false;
            btnBestYenenExceleAktar.Click += btnBestYenenExceleAktar_Click;
            // 
            // btnOgunEnCokYenılenRaporAktar
            // 
            btnOgunEnCokYenılenRaporAktar.BackColor = Color.SeaShell;
            btnOgunEnCokYenılenRaporAktar.Location = new Point(234, 491);
            btnOgunEnCokYenılenRaporAktar.Name = "btnOgunEnCokYenılenRaporAktar";
            btnOgunEnCokYenılenRaporAktar.Size = new Size(189, 41);
            btnOgunEnCokYenılenRaporAktar.TabIndex = 4;
            btnOgunEnCokYenılenRaporAktar.Text = "Öğünlerde Yenilen En Çok Yemekleri Excele Aktar";
            btnOgunEnCokYenılenRaporAktar.UseVisualStyleBackColor = false;
            btnOgunEnCokYenılenRaporAktar.Click += btnOgunEnCokYenılenRaporAktar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(592, 27);
            label6.Name = "label6";
            label6.Size = new Size(141, 19);
            label6.TabIndex = 3;
            label6.Text = "Favori Yemekleriniz";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(77, 27);
            label5.Name = "label5";
            label5.Size = new Size(247, 19);
            label5.TabIndex = 2;
            label5.Text = "Öğünlerde En Çok Tercih Ettikleriniz";
            // 
            // dgvOgunlerdeEnçokYenilen
            // 
            dgvOgunlerdeEnçokYenilen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOgunlerdeEnçokYenilen.BackgroundColor = Color.SeaShell;
            dgvOgunlerdeEnçokYenilen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOgunlerdeEnçokYenilen.Location = new Point(17, 62);
            dgvOgunlerdeEnçokYenilen.Name = "dgvOgunlerdeEnçokYenilen";
            dgvOgunlerdeEnçokYenilen.RowTemplate.Height = 25;
            dgvOgunlerdeEnçokYenilen.Size = new Size(406, 416);
            dgvOgunlerdeEnçokYenilen.TabIndex = 1;
            // 
            // dgvEnCokYenenler
            // 
            dgvEnCokYenenler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEnCokYenenler.BackgroundColor = Color.SeaShell;
            dgvEnCokYenenler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEnCokYenenler.Location = new Point(454, 62);
            dgvEnCokYenenler.Name = "dgvEnCokYenenler";
            dgvEnCokYenenler.RowTemplate.Height = 25;
            dgvEnCokYenenler.Size = new Size(426, 416);
            dgvEnCokYenenler.TabIndex = 0;
            // 
            // ReportsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 576);
            Controls.Add(REPORT);
            Name = "ReportsForm";
            Text = "ReportsForm";
            REPORT.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGunlukRapor).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHaftalıkYiyecegeGore).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvHaftalıkRapor).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAylıkKategoriyeGore).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAylıkRapor).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOgunlerdeEnçokYenilen).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEnCokYenenler).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl REPORT;
        private TabPage tabPage1;
        private Button btnGunlukRaporExcekAktar;
        private DateTimePicker dtpGunlukRapor;
        private DataGridView dgvGunlukRapor;
        private TabPage tabPage2;
        private DataGridView dgvHaftalıkRapor;
        private TabPage tabPage3;
        private DataGridView dgvAylıkRapor;
        private TabPage tabPage4;
        private Label label6;
        private Label label5;
        private DataGridView dgvOgunlerdeEnçokYenilen;
        private DataGridView dgvEnCokYenenler;
        private DateTimePicker dtpHafalıkReport;
        private DataGridView dgvHaftalıkYiyecegeGore;
        private DataGridView dgvAylıkKategoriyeGore;
        private DateTimePicker dtpAylıkRapor;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label7;
        private Label label4;
        private Button btnHafKateGöreExceleAktar;
        private Button btnHafRaporExcAktar;
        private Button brnKatGörAylıkRapExcAktar;
        private Button btnAylıkExceleAkatr;
        private Button btnBestYenenExceleAktar;
        private Button btnOgunEnCokYenılenRaporAktar;
    }
}