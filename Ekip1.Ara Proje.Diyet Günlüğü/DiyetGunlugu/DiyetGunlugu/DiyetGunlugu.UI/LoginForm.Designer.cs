namespace DiyetGunlugu.UI
{
    partial class LoginForm
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
            label1 = new Label();
            label2 = new Label();
            txt_Username = new TextBox();
            btn_SignIn = new Button();
            btn_Login = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            txt_Password = new TextBox();
            link_ForgotPassword = new LinkLabel();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(17, 70);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(60, 99);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 1;
            label2.Text = "Şifre";
            // 
            // txt_Username
            // 
            txt_Username.BackColor = Color.SeaShell;
            txt_Username.Location = new Point(109, 67);
            txt_Username.Name = "txt_Username";
            txt_Username.Size = new Size(173, 23);
            txt_Username.TabIndex = 1;
            // 
            // btn_SignIn
            // 
            btn_SignIn.BackColor = Color.SeaShell;
            btn_SignIn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_SignIn.Location = new Point(109, 132);
            btn_SignIn.Name = "btn_SignIn";
            btn_SignIn.Size = new Size(81, 23);
            btn_SignIn.TabIndex = 4;
            btn_SignIn.Text = "Kayıt Ol";
            btn_SignIn.UseVisualStyleBackColor = false;
            btn_SignIn.Click += btn_SignIn_Click;
            // 
            // btn_Login
            // 
            btn_Login.BackColor = Color.SeaShell;
            btn_Login.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Login.Location = new Point(201, 132);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(81, 23);
            btn_Login.TabIndex = 3;
            btn_Login.Text = "Giriş Yap";
            btn_Login.UseVisualStyleBackColor = false;
            btn_Login.Click += btn_Login_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(txt_Password);
            panel1.Location = new Point(109, 96);
            panel1.Name = "panel1";
            panel1.Size = new Size(173, 23);
            panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.SeaShell;
            pictureBox1.Image = Properties.Resources.Kapali_Goz_Icon;
            pictureBox1.Location = new Point(121, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 20);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // txt_Password
            // 
            txt_Password.BackColor = Color.SeaShell;
            txt_Password.Location = new Point(0, 0);
            txt_Password.Name = "txt_Password";
            txt_Password.PasswordChar = '*';
            txt_Password.Size = new Size(173, 23);
            txt_Password.TabIndex = 1;
            // 
            // link_ForgotPassword
            // 
            link_ForgotPassword.ActiveLinkColor = Color.Chocolate;
            link_ForgotPassword.AutoSize = true;
            link_ForgotPassword.BackColor = Color.Transparent;
            link_ForgotPassword.LinkColor = Color.Crimson;
            link_ForgotPassword.Location = new Point(187, 168);
            link_ForgotPassword.Name = "link_ForgotPassword";
            link_ForgotPassword.Size = new Size(95, 15);
            link_ForgotPassword.TabIndex = 5;
            link_ForgotPassword.TabStop = true;
            link_ForgotPassword.Text = "Şifremi Unuttum";
            link_ForgotPassword.LinkClicked += link_ForgotPassword_LinkClicked;
            // 
            // label4
            // 
            label4.AccessibleRole = AccessibleRole.Clock;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(11, 24);
            label4.Name = "label4";
            label4.Size = new Size(274, 25);
            label4.TabIndex = 22;
            label4.Text = " Diyet Günlüğüne Hoş Geldiniz";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Custom_Designed_Illustrations___897818__Printable_Illustrations___Creativa_Fabrica;
            ClientSize = new Size(300, 192);
            Controls.Add(label4);
            Controls.Add(link_ForgotPassword);
            Controls.Add(panel1);
            Controls.Add(btn_Login);
            Controls.Add(btn_SignIn);
            Controls.Add(txt_Username);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giriş Ekranı";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_Username;
        private Button btn_SignIn;
        private Button btn_Login;
        private Panel panel1;
        private PictureBox pictureBox1;
        private TextBox txt_Password;
        private LinkLabel link_ForgotPassword;
        private Label label4;
    }
}