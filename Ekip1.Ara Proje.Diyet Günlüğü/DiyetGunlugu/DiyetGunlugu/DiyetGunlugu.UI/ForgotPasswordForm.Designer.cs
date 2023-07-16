namespace DiyetGunlugu.UI
{
    partial class ForgotPasswordForm
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
            txt_Email = new TextBox();
            label1 = new Label();
            btn_Newactivekod = new Button();
            label2 = new Label();
            lbl_ActivationCode = new Label();
            txt_ActivationCode = new TextBox();
            btn_ActivationCode = new Button();
            SuspendLayout();
            // 
            // txt_Email
            // 
            txt_Email.BackColor = Color.SeaShell;
            txt_Email.Location = new Point(139, 16);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(177, 23);
            txt_Email.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(77, 34);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 1;
            // 
            // btn_Newactivekod
            // 
            btn_Newactivekod.BackColor = Color.SeaShell;
            btn_Newactivekod.Location = new Point(210, 84);
            btn_Newactivekod.Name = "btn_Newactivekod";
            btn_Newactivekod.Size = new Size(107, 23);
            btn_Newactivekod.TabIndex = 2;
            btn_Newactivekod.Text = "Yeni Aktivasyon Kodu Gönder";
            btn_Newactivekod.UseVisualStyleBackColor = false;
            btn_Newactivekod.Click += brn_NewPassword_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 24);
            label2.Name = "label2";
            label2.Size = new Size(119, 15);
            label2.TabIndex = 3;
            label2.Text = "Kullanıcı Adı / E-Mail";
            // 
            // lbl_ActivationCode
            // 
            lbl_ActivationCode.AutoSize = true;
            lbl_ActivationCode.BackColor = Color.Transparent;
            lbl_ActivationCode.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_ActivationCode.Location = new Point(31, 48);
            lbl_ActivationCode.Name = "lbl_ActivationCode";
            lbl_ActivationCode.Size = new Size(100, 15);
            lbl_ActivationCode.TabIndex = 4;
            lbl_ActivationCode.Text = "Aktivasyon Kodu";
            lbl_ActivationCode.Visible = false;
            // 
            // txt_ActivationCode
            // 
            txt_ActivationCode.BackColor = Color.SeaShell;
            txt_ActivationCode.Location = new Point(139, 45);
            txt_ActivationCode.Name = "txt_ActivationCode";
            txt_ActivationCode.Size = new Size(177, 23);
            txt_ActivationCode.TabIndex = 5;
            txt_ActivationCode.Visible = false;
            // 
            // btn_ActivationCode
            // 
            btn_ActivationCode.BackColor = Color.SeaShell;
            btn_ActivationCode.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ActivationCode.Location = new Point(210, 84);
            btn_ActivationCode.Name = "btn_ActivationCode";
            btn_ActivationCode.Size = new Size(107, 23);
            btn_ActivationCode.TabIndex = 6;
            btn_ActivationCode.Text = "Gönder";
            btn_ActivationCode.UseVisualStyleBackColor = false;
            btn_ActivationCode.Visible = false;
            btn_ActivationCode.Click += btn_ActivationCode_Click;
            // 
            // ForgotPasswordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Custom_Designed_Illustrations___897818__Printable_Illustrations___Creativa_Fabrica;
            ClientSize = new Size(329, 115);
            Controls.Add(btn_ActivationCode);
            Controls.Add(txt_ActivationCode);
            Controls.Add(lbl_ActivationCode);
            Controls.Add(label2);
            Controls.Add(btn_Newactivekod);
            Controls.Add(label1);
            Controls.Add(txt_Email);
            Name = "ForgotPasswordForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ForgotPasswordForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_Email;
        private Label label1;
        private Button btn_Newactivekod;
        private Label label2;
        private Label lbl_ActivationCode;
        private TextBox txt_ActivationCode;
        private Button btn_ActivationCode;
    }
}