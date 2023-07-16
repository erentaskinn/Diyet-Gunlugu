namespace DiyetGunlugu.UI
{
    partial class NewUserForm
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
            txt_Password = new TextBox();
            btn_Register = new Button();
            lbl_sifre = new Label();
            txt_Email = new TextBox();
            lbl_email = new Label();
            txt_PasswordAgain = new TextBox();
            lbl_PasswordAgain = new Label();
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
            txt_Password.ImeMode = ImeMode.On;
            txt_Password.Location = new Point(0, 0);
            txt_Password.Name = "txt_Password";
            txt_Password.PasswordChar = '*';
            txt_Password.Size = new Size(207, 23);
            txt_Password.TabIndex = 1;
            txt_Password.TextChanged += txt_Password_TextChanged;
            // 
            // btn_Register
            // 
            btn_Register.BackColor = Color.SeaShell;
            btn_Register.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Register.Location = new Point(247, 132);
            btn_Register.Name = "btn_Register";
            btn_Register.Size = new Size(74, 27);
            btn_Register.TabIndex = 4;
            btn_Register.Text = "Kayıt Ol";
            btn_Register.UseVisualStyleBackColor = false;
            btn_Register.Click += btn_Register_Click;
            // 
            // lbl_sifre
            // 
            lbl_sifre.AutoSize = true;
            lbl_sifre.BackColor = Color.Transparent;
            lbl_sifre.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_sifre.Location = new Point(62, 49);
            lbl_sifre.Name = "lbl_sifre";
            lbl_sifre.Size = new Size(34, 15);
            lbl_sifre.TabIndex = 16;
            lbl_sifre.Text = "Şifre";
            // 
            // txt_Email
            // 
            txt_Email.BackColor = Color.SeaShell;
            txt_Email.Location = new Point(114, 12);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(204, 23);
            txt_Email.TabIndex = 1;
            // 
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.BackColor = Color.Transparent;
            lbl_email.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_email.Location = new Point(55, 20);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(41, 15);
            lbl_email.TabIndex = 15;
            lbl_email.Text = "E-Mail";
            // 
            // txt_PasswordAgain
            // 
            txt_PasswordAgain.BackColor = Color.SeaShell;
            txt_PasswordAgain.ImeMode = ImeMode.On;
            txt_PasswordAgain.Location = new Point(114, 70);
            txt_PasswordAgain.Name = "txt_PasswordAgain";
            txt_PasswordAgain.PasswordChar = '*';
            txt_PasswordAgain.Size = new Size(205, 23);
            txt_PasswordAgain.TabIndex = 3;
            txt_PasswordAgain.TextChanged += txt_Password_TextChanged;
            // 
            // lbl_PasswordAgain
            // 
            lbl_PasswordAgain.AutoSize = true;
            lbl_PasswordAgain.BackColor = Color.Transparent;
            lbl_PasswordAgain.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_PasswordAgain.Location = new Point(15, 78);
            lbl_PasswordAgain.Name = "lbl_PasswordAgain";
            lbl_PasswordAgain.Size = new Size(81, 15);
            lbl_PasswordAgain.TabIndex = 18;
            lbl_PasswordAgain.Text = "Şifre (Tekrar)";
            // 
            // pb_SpecialCharacter
            // 
            pb_SpecialCharacter.BackColor = Color.Transparent;
            pb_SpecialCharacter.Image = Properties.Resources.MicrosoftTeams_image__1_;
            pb_SpecialCharacter.Location = new Point(301, 104);
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
            pb_UpperLowerCharacter.Location = new Point(202, 104);
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
            label6.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(18, 110);
            label6.Name = "label6";
            label6.Size = new Size(59, 13);
            label6.TabIndex = 25;
            label6.Text = "8 Karakter";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(100, 110);
            label5.Name = "label5";
            label5.Size = new Size(98, 13);
            label5.TabIndex = 24;
            label5.Text = "Büyük/Küçük Harf";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(222, 110);
            label4.Name = "label4";
            label4.Size = new Size(75, 13);
            label4.TabIndex = 23;
            label4.Text = "Özel Karakter";
            // 
            // pb_EightCharacter
            // 
            pb_EightCharacter.BackColor = Color.Transparent;
            pb_EightCharacter.Image = Properties.Resources.MicrosoftTeams_image__1_;
            pb_EightCharacter.Location = new Point(80, 104);
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
            panel1.Location = new Point(114, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(205, 23);
            panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.SeaShell;
            pictureBox1.Image = Properties.Resources.Kapali_Goz_Icon;
            pictureBox1.Location = new Point(155, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(49, 20);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // NewUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Custom_Designed_Illustrations___897818__Printable_Illustrations___Creativa_Fabrica;
            ClientSize = new Size(331, 171);
            Controls.Add(panel1);
            Controls.Add(pb_SpecialCharacter);
            Controls.Add(pb_UpperLowerCharacter);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(pb_EightCharacter);
            Controls.Add(txt_PasswordAgain);
            Controls.Add(lbl_PasswordAgain);
            Controls.Add(btn_Register);
            Controls.Add(lbl_sifre);
            Controls.Add(txt_Email);
            Controls.Add(lbl_email);
            Name = "NewUserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
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
        private Button btn_Register;
        private Label lbl_sifre;
        private TextBox txt_Email;
        private Label lbl_email;
        private TextBox txt_PasswordAgain;
        private Label lbl_PasswordAgain;
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