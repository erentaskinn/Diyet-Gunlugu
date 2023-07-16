namespace DiyetGunlugu.UI
{
    partial class FoodAddForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgw_AddedMeals = new DataGridView();
            btn_Save = new Button();
            cmb_Foods = new ComboBox();
            cmb_PortionTour = new ComboBox();
            btn_Add = new Button();
            nud_Piece = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgw_AddedMeals).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_Piece).BeginInit();
            SuspendLayout();
            // 
            // dgw_AddedMeals
            // 
            dgw_AddedMeals.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgw_AddedMeals.BackgroundColor = Color.SeaShell;
            dgw_AddedMeals.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dgw_AddedMeals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgw_AddedMeals.Location = new Point(12, 88);
            dgw_AddedMeals.Name = "dgw_AddedMeals";
            dgw_AddedMeals.RowHeadersVisible = false;
            dgw_AddedMeals.RowTemplate.Height = 25;
            dgw_AddedMeals.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgw_AddedMeals.Size = new Size(441, 189);
            dgw_AddedMeals.TabIndex = 0;
            // 
            // btn_Save
            // 
            btn_Save.BackColor = Color.SeaShell;
            btn_Save.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Save.Location = new Point(290, 283);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(77, 26);
            btn_Save.TabIndex = 2;
            btn_Save.Text = "Kaydet";
            btn_Save.UseVisualStyleBackColor = false;
            btn_Save.Click += btn_Save_Click;
            // 
            // cmb_Foods
            // 
            cmb_Foods.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmb_Foods.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cmb_Foods.BackColor = Color.SeaShell;
            cmb_Foods.FormattingEnabled = true;
            cmb_Foods.Location = new Point(83, 16);
            cmb_Foods.Name = "cmb_Foods";
            cmb_Foods.Size = new Size(370, 23);
            cmb_Foods.TabIndex = 3;
            cmb_Foods.SelectedIndexChanged += cmb_Foods_SelectedIndexChanged;
            // 
            // cmb_PortionTour
            // 
            cmb_PortionTour.BackColor = Color.SeaShell;
            cmb_PortionTour.ForeColor = SystemColors.ActiveCaptionText;
            cmb_PortionTour.FormattingEnabled = true;
            cmb_PortionTour.Location = new Point(302, 54);
            cmb_PortionTour.Name = "cmb_PortionTour";
            cmb_PortionTour.Size = new Size(151, 23);
            cmb_PortionTour.TabIndex = 5;
            // 
            // btn_Add
            // 
            btn_Add.BackColor = Color.SeaShell;
            btn_Add.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Add.Location = new Point(378, 283);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(77, 26);
            btn_Add.TabIndex = 9;
            btn_Add.Text = "Ekle";
            btn_Add.UseVisualStyleBackColor = false;
            btn_Add.Click += btn_Add_Click;
            // 
            // nud_Piece
            // 
            nud_Piece.BackColor = Color.SeaShell;
            nud_Piece.ForeColor = SystemColors.ActiveCaptionText;
            nud_Piece.Location = new Point(83, 55);
            nud_Piece.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nud_Piece.Name = "nud_Piece";
            nud_Piece.Size = new Size(84, 23);
            nud_Piece.TabIndex = 4;
            nud_Piece.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(205, 62);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 20;
            label1.Text = "Porsiyon Türü";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(36, 62);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 19;
            label2.Text = "Adet";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(10, 24);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 18;
            label3.Text = "Yemekler";
            // 
            // FoodAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Custom_Designed_Illustrations___897818__Printable_Illustrations___Creativa_Fabrica;
            ClientSize = new Size(464, 319);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(btn_Add);
            Controls.Add(cmb_PortionTour);
            Controls.Add(nud_Piece);
            Controls.Add(cmb_Foods);
            Controls.Add(btn_Save);
            Controls.Add(dgw_AddedMeals);
            Name = "FoodAddForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgw_AddedMeals).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_Piece).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgw_AddedMeals;
        private Button btn_Save;
        private ComboBox cmb_Foods;
        private ComboBox cmb_PortionTour;
        private Button btn_Add;
        private NumericUpDown nud_Piece;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}