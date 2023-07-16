using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;

namespace DiyetGunlugu.UI
{
    partial class PasswordChangeForm
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
            txt_NewPasswordAgain = new TextBox();
            txt_NewPassword = new TextBox();
            txt_PresentPassword = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btn_Degistir = new Button();
            pb_EightCharacter = new PictureBox();
            panel1 = new Panel();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            pb_UpperLowerCharacter = new PictureBox();
            pb_SpecialCharacter = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_EightCharacter).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_UpperLowerCharacter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_SpecialCharacter).BeginInit();
            SuspendLayout();
            // 
            // txt_NewPasswordAgain
            // 
            txt_NewPasswordAgain.BackColor = Color.SeaShell;
            txt_NewPasswordAgain.Location = new Point(145, 70);
            txt_NewPasswordAgain.Name = "txt_NewPasswordAgain";
            txt_NewPasswordAgain.PasswordChar = '*';
            txt_NewPasswordAgain.Size = new Size(183, 23);
            txt_NewPasswordAgain.TabIndex = 3;
            // 
            // txt_NewPassword
            // 
            txt_NewPassword.BackColor = Color.SeaShell;
            txt_NewPassword.Location = new Point(145, 41);
            txt_NewPassword.Name = "txt_NewPassword";
            txt_NewPassword.PasswordChar = '*';
            txt_NewPassword.Size = new Size(183, 23);
            txt_NewPassword.TabIndex = 2;
            txt_NewPassword.TextChanged += txt_YeniSifre_TextChanged;
            // 
            // txt_PresentPassword
            // 
            txt_PresentPassword.BackColor = Color.SeaShell;
            txt_PresentPassword.Location = new Point(0, 0);
            txt_PresentPassword.Name = "txt_PresentPassword";
            txt_PresentPassword.PasswordChar = '*';
            txt_PresentPassword.Size = new Size(183, 23);
            txt_PresentPassword.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(57, 49);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 9;
            label3.Text = "Yeni Şifreniz ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 78);
            label2.Name = "label2";
            label2.Size = new Size(124, 15);
            label2.TabIndex = 8;
            label2.Text = "Şifreyi Tekrar Giriniz ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(37, 20);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 7;
            label1.Text = "Mevcut Şifreniz ";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.SeaShell;
            pictureBox1.Image = Properties.Resources.Kapali_Goz_Icon;
            pictureBox1.Location = new Point(131, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 20);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btn_Degistir
            // 
            btn_Degistir.BackColor = Color.SeaShell;
            btn_Degistir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Degistir.Location = new Point(234, 138);
            btn_Degistir.Name = "btn_Degistir";
            btn_Degistir.Size = new Size(94, 31);
            btn_Degistir.TabIndex = 4;
            btn_Degistir.Text = "Değiştir";
            btn_Degistir.UseVisualStyleBackColor = false;
            btn_Degistir.Click += btn_Degistir_Click;
            // 
            // pb_EightCharacter
            // 
            pb_EightCharacter.BackColor = Color.Transparent;
            pb_EightCharacter.Image = Properties.Resources.MicrosoftTeams_image__1_;
            pb_EightCharacter.Location = new Point(75, 99);
            pb_EightCharacter.Name = "pb_EightCharacter";
            pb_EightCharacter.Size = new Size(17, 21);
            pb_EightCharacter.SizeMode = PictureBoxSizeMode.Zoom;
            pb_EightCharacter.TabIndex = 15;
            pb_EightCharacter.TabStop = false;
            pb_EightCharacter.Visible = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(txt_PresentPassword);
            panel1.Location = new Point(145, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(183, 23);
            panel1.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(227, 105);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 17;
            label4.Text = "Özel Karakter";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(98, 105);
            label5.Name = "label5";
            label5.Size = new Size(106, 15);
            label5.TabIndex = 18;
            label5.Text = "Büyük/Küçük Harf";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(10, 105);
            label6.Name = "label6";
            label6.Size = new Size(65, 15);
            label6.TabIndex = 19;
            label6.Text = "8 Karakter";
            // 
            // pb_UpperLowerCharacter
            // 
            pb_UpperLowerCharacter.BackColor = Color.Transparent;
            pb_UpperLowerCharacter.Image = Properties.Resources.MicrosoftTeams_image__1_;
            pb_UpperLowerCharacter.Location = new Point(208, 99);
            pb_UpperLowerCharacter.Name = "pb_UpperLowerCharacter";
            pb_UpperLowerCharacter.Size = new Size(17, 21);
            pb_UpperLowerCharacter.SizeMode = PictureBoxSizeMode.Zoom;
            pb_UpperLowerCharacter.TabIndex = 20;
            pb_UpperLowerCharacter.TabStop = false;
            pb_UpperLowerCharacter.Visible = false;
            // 
            // pb_SpecialCharacter
            // 
            pb_SpecialCharacter.BackColor = Color.Transparent;
            pb_SpecialCharacter.Image = Properties.Resources.MicrosoftTeams_image__1_;
            pb_SpecialCharacter.Location = new Point(309, 99);
            pb_SpecialCharacter.Name = "pb_SpecialCharacter";
            pb_SpecialCharacter.Size = new Size(17, 21);
            pb_SpecialCharacter.SizeMode = PictureBoxSizeMode.Zoom;
            pb_SpecialCharacter.TabIndex = 21;
            pb_SpecialCharacter.TabStop = false;
            pb_SpecialCharacter.Visible = false;
            // 
            // PasswordChangeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Custom_Designed_Illustrations___897818__Printable_Illustrations___Creativa_Fabrica;
            ClientSize = new Size(338, 180);
            Controls.Add(pb_SpecialCharacter);
            Controls.Add(txt_NewPassword);
            Controls.Add(pb_UpperLowerCharacter);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(pb_EightCharacter);
            Controls.Add(btn_Degistir);
            Controls.Add(txt_NewPasswordAgain);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "PasswordChangeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SifreYenileme";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_EightCharacter).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_UpperLowerCharacter).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_SpecialCharacter).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_NewPasswordAgain;
        private TextBox txt_NewPassword;
        private TextBox txt_PresentPassword;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btn_Degistir;
        private PictureBox pb_EightCharacter;
        private Panel panel1;
        private Label label4;
        private Label label5;
        private Label label6;
        private PictureBox pb_UpperLowerCharacter;
        private PictureBox pb_SpecialCharacter;
    }
}