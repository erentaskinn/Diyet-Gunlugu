namespace DiyetGunlugu.UI
{
    partial class UserInformationAddorChangeForm
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
            rdbMan = new RadioButton();
            rdbWoman = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cmbActivityLevel = new ComboBox();
            label7 = new Label();
            label9 = new Label();
            btn_ProfileSave = new Button();
            dtpDateofbirth = new DateTimePicker();
            nud_Wieght = new NumericUpDown();
            nud_Height = new NumericUpDown();
            nud_TargetWeight = new NumericUpDown();
            lbl_TargetWeight = new Label();
            btn_Update = new Button();
            txt_NameSurname = new TextBox();
            ((System.ComponentModel.ISupportInitialize)nud_Wieght).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_Height).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_TargetWeight).BeginInit();
            SuspendLayout();
            // 
            // rdbMan
            // 
            rdbMan.AutoSize = true;
            rdbMan.BackColor = Color.Transparent;
            rdbMan.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rdbMan.Location = new Point(195, 220);
            rdbMan.Margin = new Padding(3, 2, 3, 2);
            rdbMan.Name = "rdbMan";
            rdbMan.Size = new Size(53, 19);
            rdbMan.TabIndex = 5;
            rdbMan.TabStop = true;
            rdbMan.Text = "Erkek";
            rdbMan.UseVisualStyleBackColor = false;
            // 
            // rdbWoman
            // 
            rdbWoman.AutoSize = true;
            rdbWoman.BackColor = Color.Transparent;
            rdbWoman.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rdbWoman.Location = new Point(125, 220);
            rdbWoman.Margin = new Padding(3, 2, 3, 2);
            rdbWoman.Name = "rdbWoman";
            rdbWoman.Size = new Size(55, 19);
            rdbWoman.TabIndex = 6;
            rdbWoman.TabStop = true;
            rdbWoman.Text = "Kadin";
            rdbWoman.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(65, 140);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 8;
            label1.Text = "Kilonuz";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(58, 111);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 9;
            label2.Text = "Boyunuz";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(16, 83);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 10;
            label3.Text = "Doğum Tarihiniz";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(44, 222);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 11;
            label4.Text = "Cinsiyetiniz";
            // 
            // cmbActivityLevel
            // 
            cmbActivityLevel.BackColor = Color.SeaShell;
            cmbActivityLevel.FormattingEnabled = true;
            cmbActivityLevel.Location = new Point(125, 160);
            cmbActivityLevel.Margin = new Padding(3, 2, 3, 2);
            cmbActivityLevel.Name = "cmbActivityLevel";
            cmbActivityLevel.Size = new Size(204, 23);
            cmbActivityLevel.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(7, 168);
            label7.Name = "label7";
            label7.Size = new Size(106, 15);
            label7.TabIndex = 15;
            label7.Text = "Aktivite seviyeniz";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(17, 56);
            label9.Name = "label9";
            label9.Size = new Size(96, 15);
            label9.TabIndex = 17;
            label9.Text = "Adınız Soyadınız";
            // 
            // btn_ProfileSave
            // 
            btn_ProfileSave.BackColor = Color.SeaShell;
            btn_ProfileSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ProfileSave.Location = new Point(222, 258);
            btn_ProfileSave.Margin = new Padding(3, 2, 3, 2);
            btn_ProfileSave.Name = "btn_ProfileSave";
            btn_ProfileSave.Size = new Size(107, 27);
            btn_ProfileSave.TabIndex = 20;
            btn_ProfileSave.Text = "Profil Kaydet";
            btn_ProfileSave.UseVisualStyleBackColor = false;
            btn_ProfileSave.Click += btn_ProfileSave_Click;
            // 
            // dtpDateofbirth
            // 
            dtpDateofbirth.CalendarForeColor = Color.BlanchedAlmond;
            dtpDateofbirth.CalendarMonthBackground = Color.BlanchedAlmond;
            dtpDateofbirth.CalendarTitleBackColor = Color.BlanchedAlmond;
            dtpDateofbirth.CalendarTitleForeColor = Color.BlanchedAlmond;
            dtpDateofbirth.CalendarTrailingForeColor = Color.BlanchedAlmond;
            dtpDateofbirth.Format = DateTimePickerFormat.Short;
            dtpDateofbirth.Location = new Point(125, 75);
            dtpDateofbirth.Margin = new Padding(3, 2, 3, 2);
            dtpDateofbirth.Name = "dtpDateofbirth";
            dtpDateofbirth.Size = new Size(204, 23);
            dtpDateofbirth.TabIndex = 21;
            // 
            // nud_Wieght
            // 
            nud_Wieght.BackColor = Color.SeaShell;
            nud_Wieght.Location = new Point(125, 132);
            nud_Wieght.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nud_Wieght.Name = "nud_Wieght";
            nud_Wieght.Size = new Size(204, 23);
            nud_Wieght.TabIndex = 22;
            // 
            // nud_Height
            // 
            nud_Height.BackColor = Color.SeaShell;
            nud_Height.Location = new Point(125, 103);
            nud_Height.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            nud_Height.Name = "nud_Height";
            nud_Height.Size = new Size(204, 23);
            nud_Height.TabIndex = 23;
            // 
            // nud_TargetWeight
            // 
            nud_TargetWeight.BackColor = Color.SeaShell;
            nud_TargetWeight.Location = new Point(125, 188);
            nud_TargetWeight.Name = "nud_TargetWeight";
            nud_TargetWeight.Size = new Size(204, 23);
            nud_TargetWeight.TabIndex = 25;
            // 
            // lbl_TargetWeight
            // 
            lbl_TargetWeight.AutoSize = true;
            lbl_TargetWeight.BackColor = Color.Transparent;
            lbl_TargetWeight.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_TargetWeight.Location = new Point(27, 196);
            lbl_TargetWeight.Name = "lbl_TargetWeight";
            lbl_TargetWeight.Size = new Size(86, 15);
            lbl_TargetWeight.TabIndex = 24;
            lbl_TargetWeight.Text = "Hedef Kilonuz";
            // 
            // btn_Update
            // 
            btn_Update.BackColor = Color.SeaShell;
            btn_Update.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Update.Location = new Point(222, 258);
            btn_Update.Margin = new Padding(3, 2, 3, 2);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(107, 27);
            btn_Update.TabIndex = 26;
            btn_Update.Text = "Profili Güncelle";
            btn_Update.UseVisualStyleBackColor = false;
            btn_Update.Click += btn_Update_Click;
            // 
            // txt_NameSurname
            // 
            txt_NameSurname.BackColor = Color.SeaShell;
            txt_NameSurname.Cursor = Cursors.IBeam;
            txt_NameSurname.Location = new Point(125, 48);
            txt_NameSurname.Margin = new Padding(3, 2, 3, 2);
            txt_NameSurname.Name = "txt_NameSurname";
            txt_NameSurname.Size = new Size(204, 23);
            txt_NameSurname.TabIndex = 18;
            // 
            // UserInformationAddorChangeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlanchedAlmond;
            BackgroundImage = Properties.Resources.Custom_Designed_Illustrations___897818__Printable_Illustrations___Creativa_Fabrica1;
            ClientSize = new Size(350, 301);
            Controls.Add(btn_Update);
            Controls.Add(nud_TargetWeight);
            Controls.Add(lbl_TargetWeight);
            Controls.Add(nud_Height);
            Controls.Add(nud_Wieght);
            Controls.Add(dtpDateofbirth);
            Controls.Add(btn_ProfileSave);
            Controls.Add(txt_NameSurname);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(cmbActivityLevel);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(rdbWoman);
            Controls.Add(rdbMan);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UserInformationAddorChangeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Profil Bilgileri";
            ((System.ComponentModel.ISupportInitialize)nud_Wieght).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_Height).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_TargetWeight).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private RadioButton rdbMan;
        private RadioButton rdbWoman;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cmbActivityLevel;
        private Label label7;
        private Label label9;
        private Button btn_ProfileSave;
        private DateTimePicker dtpDateofbirth;
        private NumericUpDown nud_Wieght;
        private NumericUpDown nud_Height;
        private NumericUpDown nud_TargetWeight;
        private Label lbl_TargetWeight;
        private Button btn_Update;
        private TextBox txt_NameSurname;
    }
}