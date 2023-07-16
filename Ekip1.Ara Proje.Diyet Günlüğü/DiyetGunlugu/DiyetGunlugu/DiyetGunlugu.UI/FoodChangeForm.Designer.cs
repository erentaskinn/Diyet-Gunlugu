namespace DiyetGunlugu.UI
{
    partial class FoodChangeForm
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
            lbl_PorsiyonTuru = new Label();
            lbl_Adet = new Label();
            lbl_Yemekler = new Label();
            cmb_PortionTour = new ComboBox();
            nud_Piece = new NumericUpDown();
            cmb_Foods = new ComboBox();
            dgw_AddedMeals = new DataGridView();
            btn_change = new Button();
            ((System.ComponentModel.ISupportInitialize)nud_Piece).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgw_AddedMeals).BeginInit();
            SuspendLayout();
            // 
            // lbl_PorsiyonTuru
            // 
            lbl_PorsiyonTuru.AutoSize = true;
            lbl_PorsiyonTuru.BackColor = Color.Transparent;
            lbl_PorsiyonTuru.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_PorsiyonTuru.Location = new Point(207, 63);
            lbl_PorsiyonTuru.Name = "lbl_PorsiyonTuru";
            lbl_PorsiyonTuru.Size = new Size(82, 15);
            lbl_PorsiyonTuru.TabIndex = 14;
            lbl_PorsiyonTuru.Text = "Porsiyon Türü";
            // 
            // lbl_Adet
            // 
            lbl_Adet.AutoSize = true;
            lbl_Adet.BackColor = Color.Transparent;
            lbl_Adet.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Adet.Location = new Point(38, 63);
            lbl_Adet.Name = "lbl_Adet";
            lbl_Adet.Size = new Size(34, 15);
            lbl_Adet.TabIndex = 13;
            lbl_Adet.Text = "Adet";
            // 
            // lbl_Yemekler
            // 
            lbl_Yemekler.AutoSize = true;
            lbl_Yemekler.BackColor = Color.Transparent;
            lbl_Yemekler.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Yemekler.Location = new Point(12, 25);
            lbl_Yemekler.Name = "lbl_Yemekler";
            lbl_Yemekler.Size = new Size(60, 15);
            lbl_Yemekler.TabIndex = 12;
            lbl_Yemekler.Text = "Yemekler";
            // 
            // cmb_PortionTour
            // 
            cmb_PortionTour.BackColor = Color.SeaShell;
            cmb_PortionTour.FormattingEnabled = true;
            cmb_PortionTour.Location = new Point(304, 55);
            cmb_PortionTour.Name = "cmb_PortionTour";
            cmb_PortionTour.Size = new Size(151, 23);
            cmb_PortionTour.TabIndex = 11;
            // 
            // nud_Piece
            // 
            nud_Piece.BackColor = Color.SeaShell;
            nud_Piece.Location = new Point(85, 56);
            nud_Piece.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            nud_Piece.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nud_Piece.Name = "nud_Piece";
            nud_Piece.Size = new Size(84, 23);
            nud_Piece.TabIndex = 10;
            nud_Piece.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cmb_Foods
            // 
            cmb_Foods.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmb_Foods.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cmb_Foods.BackColor = Color.SeaShell;
            cmb_Foods.ForeColor = SystemColors.ActiveCaptionText;
            cmb_Foods.FormattingEnabled = true;
            cmb_Foods.Location = new Point(85, 17);
            cmb_Foods.Name = "cmb_Foods";
            cmb_Foods.Size = new Size(370, 23);
            cmb_Foods.TabIndex = 9;
            cmb_Foods.SelectedIndexChanged += cmb_Foods_SelectedIndexChanged;
            // 
            // dgw_AddedMeals
            // 
            dgw_AddedMeals.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgw_AddedMeals.BackgroundColor = Color.SeaShell;
            dgw_AddedMeals.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dgw_AddedMeals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgw_AddedMeals.Location = new Point(12, 95);
            dgw_AddedMeals.Name = "dgw_AddedMeals";
            dgw_AddedMeals.RowHeadersVisible = false;
            dgw_AddedMeals.RowTemplate.Height = 25;
            dgw_AddedMeals.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgw_AddedMeals.Size = new Size(443, 184);
            dgw_AddedMeals.TabIndex = 15;
            // 
            // btn_change
            // 
            btn_change.BackColor = Color.SeaShell;
            btn_change.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_change.ForeColor = SystemColors.ControlText;
            btn_change.Location = new Point(378, 285);
            btn_change.Name = "btn_change";
            btn_change.Size = new Size(77, 27);
            btn_change.TabIndex = 16;
            btn_change.Text = "Değiştir";
            btn_change.UseVisualStyleBackColor = false;
            btn_change.Click += btn_change_Click;
            // 
            // FoodChangeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Custom_Designed_Illustrations___897818__Printable_Illustrations___Creativa_Fabrica;
            ClientSize = new Size(464, 320);
            Controls.Add(btn_change);
            Controls.Add(dgw_AddedMeals);
            Controls.Add(lbl_PorsiyonTuru);
            Controls.Add(lbl_Adet);
            Controls.Add(lbl_Yemekler);
            Controls.Add(cmb_PortionTour);
            Controls.Add(nud_Piece);
            Controls.Add(cmb_Foods);
            Name = "FoodChangeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FoodChangeForm";
            ((System.ComponentModel.ISupportInitialize)nud_Piece).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgw_AddedMeals).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_PorsiyonTuru;
        private Label lbl_Adet;
        private Label lbl_Yemekler;
        private ComboBox cmb_PortionTour;
        private NumericUpDown nud_Piece;
        private ComboBox cmb_Foods;
        private DataGridView dgw_AddedMeals;
        private Button btn_change;
    }
}