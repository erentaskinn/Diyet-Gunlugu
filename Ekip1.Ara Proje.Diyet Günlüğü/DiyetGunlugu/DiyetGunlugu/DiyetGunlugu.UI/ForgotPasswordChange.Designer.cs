namespace DiyetGunlugu.UI
{
    partial class ForgotPasswordChange
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
            txt_Password = new TextBox();
            lbl_Password = new Label();
            txt_PasswordAgain = new TextBox();
            lbl_PasswordAgain = new Label();
            btn_ChangePassword = new Button();
            pb_SpecialCharacter = new PictureBox();
            pb_UpperLowerCharacter = new PictureBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            pb_EightCharacter = new PictureBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pb_SpecialCharacter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_UpperLowerCharacter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_EightCharacter).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txt_Password
            // 
            txt_Password.BackColor = Color.SeaShell;
            txt_Password.Location = new Point(0, 0);
            txt_Password.Name = "txt_Password";
            txt_Password.PasswordChar = '*';
            txt_Password.Size = new Size(204, 23);
            txt_Password.TabIndex = 1;
            txt_Password.TextChanged += txt_Password_TextChanged;
            // 
            // lbl_Password
            // 
            lbl_Password.AutoSize = true;
            lbl_Password.BackColor = Color.Transparent;
            lbl_Password.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Password.Location = new Point(60, 25);
            lbl_Password.Name = "lbl_Password";
            lbl_Password.Size = new Size(34, 15);
            lbl_Password.TabIndex = 1;
            lbl_Password.Text = "Şifre";
            // 
            // txt_PasswordAgain
            // 
            txt_PasswordAgain.BackColor = Color.SeaShell;
            txt_PasswordAgain.Location = new Point(111, 46);
            txt_PasswordAgain.Name = "txt_PasswordAgain";
            txt_PasswordAgain.PasswordChar = '*';
            txt_PasswordAgain.Size = new Size(204, 23);
            txt_PasswordAgain.TabIndex = 2;
            // 
            // lbl_PasswordAgain
            // 
            lbl_PasswordAgain.AutoSize = true;
            lbl_PasswordAgain.BackColor = Color.Transparent;
            lbl_PasswordAgain.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_PasswordAgain.Location = new Point(18, 54);
            lbl_PasswordAgain.Name = "lbl_PasswordAgain";
            lbl_PasswordAgain.Size = new Size(81, 15);
            lbl_PasswordAgain.TabIndex = 3;
            lbl_PasswordAgain.Text = "Şifre (Tekrar)";
            // 
            // btn_ChangePassword
            // 
            btn_ChangePassword.BackColor = Color.SeaShell;
            btn_ChangePassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ChangePassword.Location = new Point(224, 112);
            btn_ChangePassword.Name = "btn_ChangePassword";
            btn_ChangePassword.Size = new Size(94, 31);
            btn_ChangePassword.TabIndex = 3;
            btn_ChangePassword.Text = "Değiştir";
            btn_ChangePassword.UseVisualStyleBackColor = false;
            btn_ChangePassword.Click += btn_ChangePassword_Click;
            // 
            // pb_SpecialCharacter
            // 
            pb_SpecialCharacter.BackColor = Color.Transparent;
            pb_SpecialCharacter.Image = Properties.Resources.MicrosoftTeams_image__1_;
            pb_SpecialCharacter.Location = new Point(298, 82);
            pb_SpecialCharacter.Name = "pb_SpecialCharacter";
            pb_SpecialCharacter.Size = new Size(17, 21);
            pb_SpecialCharacter.SizeMode = PictureBoxSizeMode.Zoom;
            pb_SpecialCharacter.TabIndex = 27;
            pb_SpecialCharacter.TabStop = false;
            pb_SpecialCharacter.Visible = false;
            // 
            // pb_UpperLowerCharacter
            // 
            pb_UpperLowerCharacter.BackColor = Color.Transparent;
            pb_UpperLowerCharacter.Image = Properties.Resources.MicrosoftTeams_image__1_;
            pb_UpperLowerCharacter.Location = new Point(200, 82);
            pb_UpperLowerCharacter.Name = "pb_UpperLowerCharacter";
            pb_UpperLowerCharacter.Size = new Size(17, 21);
            pb_UpperLowerCharacter.SizeMode = PictureBoxSizeMode.Zoom;
            pb_UpperLowerCharacter.TabIndex = 26;
            pb_UpperLowerCharacter.TabStop = false;
            pb_UpperLowerCharacter.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(18, 88);
            label6.Name = "label6";
            label6.Size = new Size(59, 13);
            label6.TabIndex = 25;
            label6.Text = "8 Karakter";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(99, 88);
            label5.Name = "label5";
            label5.Size = new Size(98, 13);
            label5.TabIndex = 24;
            label5.Text = "Büyük/Küçük Harf";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(220, 88);
            label4.Name = "label4";
            label4.Size = new Size(75, 13);
            label4.TabIndex = 23;
            label4.Text = "Özel Karakter";
            // 
            // pb_EightCharacter
            // 
            pb_EightCharacter.BackColor = Color.Transparent;
            pb_EightCharacter.Image = Properties.Resources.MicrosoftTeams_image__1_;
            pb_EightCharacter.Location = new Point(79, 82);
            pb_EightCharacter.Name = "pb_EightCharacter";
            pb_EightCharacter.Size = new Size(17, 21);
            pb_EightCharacter.SizeMode = PictureBoxSizeMode.Zoom;
            pb_EightCharacter.TabIndex = 22;
            pb_EightCharacter.TabStop = false;
            pb_EightCharacter.Visible = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(txt_Password);
            panel1.Location = new Point(111, 17);
            panel1.Name = "panel1";
            panel1.Size = new Size(204, 23);
            panel1.TabIndex = 28;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.SeaShell;
            pictureBox1.Image = Properties.Resources.Kapali_Goz_Icon;
            pictureBox1.Location = new Point(160, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(44, 20);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // ForgotPasswordChange
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Custom_Designed_Illustrations___897818__Printable_Illustrations___Creativa_Fabrica11;
            ClientSize = new Size(330, 149);
            Controls.Add(panel1);
            Controls.Add(pb_SpecialCharacter);
            Controls.Add(pb_UpperLowerCharacter);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(pb_EightCharacter);
            Controls.Add(btn_ChangePassword);
            Controls.Add(lbl_PasswordAgain);
            Controls.Add(txt_PasswordAgain);
            Controls.Add(lbl_Password);
            Name = "ForgotPasswordChange";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ForgotPasswordChange";
            ((System.ComponentModel.ISupportInitialize)pb_SpecialCharacter).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_UpperLowerCharacter).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_EightCharacter).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_Password;
        private Label lbl_Password;
        private TextBox txt_PasswordAgain;
        private Label lbl_PasswordAgain;
        private Button btn_ChangePassword;
        private PictureBox pb_SpecialCharacter;
        private PictureBox pb_UpperLowerCharacter;
        private Label label6;
        private Label label5;
        private Label label4;
        private PictureBox pb_EightCharacter;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}