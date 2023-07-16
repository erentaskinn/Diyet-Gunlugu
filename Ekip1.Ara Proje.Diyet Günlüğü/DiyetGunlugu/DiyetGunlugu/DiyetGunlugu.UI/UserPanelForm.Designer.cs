namespace DiyetGunlugu.UI
{
    partial class UserPanelForm
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
            lbl_Calory = new Label();
            panel2 = new Panel();
            menuStrip1 = new MenuStrip();
            profilToolStripMenuItem = new ToolStripMenuItem();
            şifreDeğiştirToolStripMenuItem = new ToolStripMenuItem();
            kullanıcıBilgileriniDeğiştirToolStripMenuItem = new ToolStripMenuItem();
            çıkışYapToolStripMenuItem = new ToolStripMenuItem();
            raporlarToolStripMenuItem = new ToolStripMenuItem();
            pb_Calory = new ProgressBar();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            lbl_NeedMaxcalory = new Label();
            lbl_TodayCalory = new Label();
            btn_FoodAdd = new Button();
            dgv_foodtoday = new DataGridView();
            panel2.SuspendLayout();
            menuStrip1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_foodtoday).BeginInit();
            SuspendLayout();
            // 
            // lbl_Calory
            // 
            lbl_Calory.BackColor = Color.Transparent;
            lbl_Calory.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Calory.Location = new Point(364, 10);
            lbl_Calory.Name = "lbl_Calory";
            lbl_Calory.Size = new Size(54, 20);
            lbl_Calory.TabIndex = 0;
            lbl_Calory.Text = "KALORİ";
            lbl_Calory.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SeaShell;
            panel2.BackgroundImage = Properties.Resources.Custom_Designed_Illustrations___897818__Printable_Illustrations___Creativa_Fabrica;
            panel2.Controls.Add(menuStrip1);
            panel2.Location = new Point(1, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(798, 25);
            panel2.TabIndex = 2;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.SeaShell;
            menuStrip1.Items.AddRange(new ToolStripItem[] { profilToolStripMenuItem, raporlarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(798, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // profilToolStripMenuItem
            // 
            profilToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { şifreDeğiştirToolStripMenuItem, kullanıcıBilgileriniDeğiştirToolStripMenuItem, çıkışYapToolStripMenuItem });
            profilToolStripMenuItem.Name = "profilToolStripMenuItem";
            profilToolStripMenuItem.Size = new Size(47, 20);
            profilToolStripMenuItem.Text = "Profil";
            // 
            // şifreDeğiştirToolStripMenuItem
            // 
            şifreDeğiştirToolStripMenuItem.BackColor = Color.SeaShell;
            şifreDeğiştirToolStripMenuItem.Name = "şifreDeğiştirToolStripMenuItem";
            şifreDeğiştirToolStripMenuItem.Size = new Size(156, 22);
            şifreDeğiştirToolStripMenuItem.Text = "Şifre Değiştir";
            şifreDeğiştirToolStripMenuItem.Click += şifreDeğiştirToolStripMenuItem_Click;
            // 
            // kullanıcıBilgileriniDeğiştirToolStripMenuItem
            // 
            kullanıcıBilgileriniDeğiştirToolStripMenuItem.BackColor = Color.SeaShell;
            kullanıcıBilgileriniDeğiştirToolStripMenuItem.Name = "kullanıcıBilgileriniDeğiştirToolStripMenuItem";
            kullanıcıBilgileriniDeğiştirToolStripMenuItem.Size = new Size(156, 22);
            kullanıcıBilgileriniDeğiştirToolStripMenuItem.Text = "Bilgileri Değiştir";
            kullanıcıBilgileriniDeğiştirToolStripMenuItem.Click += kullanıcıBilgileriniDeğiştirToolStripMenuItem_Click;
            // 
            // çıkışYapToolStripMenuItem
            // 
            çıkışYapToolStripMenuItem.BackColor = Color.SeaShell;
            çıkışYapToolStripMenuItem.Name = "çıkışYapToolStripMenuItem";
            çıkışYapToolStripMenuItem.Size = new Size(156, 22);
            çıkışYapToolStripMenuItem.Text = "Çıkış Yap";
            çıkışYapToolStripMenuItem.Click += çıkışYapToolStripMenuItem_Click;
            // 
            // raporlarToolStripMenuItem
            // 
            raporlarToolStripMenuItem.Name = "raporlarToolStripMenuItem";
            raporlarToolStripMenuItem.Size = new Size(63, 20);
            raporlarToolStripMenuItem.Text = "Raporlar";
            raporlarToolStripMenuItem.Click += raporlarToolStripMenuItem_Click;
            // 
            // pb_Calory
            // 
            pb_Calory.BackColor = Color.SeaShell;
            pb_Calory.Location = new Point(0, 0);
            pb_Calory.Maximum = 5000;
            pb_Calory.Name = "pb_Calory";
            pb_Calory.Size = new Size(684, 32);
            pb_Calory.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackgroundImage = Properties.Resources.Custom_Designed_Illustrations___897818__Printable_Illustrations___Creativa_Fabrica1;
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(panel1);
            panel3.Controls.Add(btn_FoodAdd);
            panel3.Controls.Add(dgv_foodtoday);
            panel3.Controls.Add(lbl_Calory);
            panel3.ImeMode = ImeMode.NoControl;
            panel3.Location = new Point(1, 25);
            panel3.Name = "panel3";
            panel3.Size = new Size(850, 386);
            panel3.TabIndex = 3;
            panel3.Paint += panel3_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.SiskoAdam;
            pictureBox2.Location = new Point(745, 33);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.icons8_standing_man_50;
            pictureBox1.Location = new Point(11, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(lbl_NeedMaxcalory);
            panel1.Controls.Add(lbl_TodayCalory);
            panel1.Controls.Add(pb_Calory);
            panel1.Location = new Point(51, 33);
            panel1.Name = "panel1";
            panel1.Size = new Size(684, 32);
            panel1.TabIndex = 8;
            // 
            // lbl_NeedMaxcalory
            // 
            lbl_NeedMaxcalory.BackColor = SystemColors.ControlLight;
            lbl_NeedMaxcalory.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_NeedMaxcalory.Location = new Point(618, 4);
            lbl_NeedMaxcalory.Name = "lbl_NeedMaxcalory";
            lbl_NeedMaxcalory.Size = new Size(63, 23);
            lbl_NeedMaxcalory.TabIndex = 7;
            lbl_NeedMaxcalory.Text = "label2";
            lbl_NeedMaxcalory.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_TodayCalory
            // 
            lbl_TodayCalory.BackColor = SystemColors.ControlLight;
            lbl_TodayCalory.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_TodayCalory.Location = new Point(3, 4);
            lbl_TodayCalory.Name = "lbl_TodayCalory";
            lbl_TodayCalory.Size = new Size(63, 23);
            lbl_TodayCalory.TabIndex = 6;
            lbl_TodayCalory.Text = "label1";
            lbl_TodayCalory.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_FoodAdd
            // 
            btn_FoodAdd.BackColor = Color.SeaShell;
            btn_FoodAdd.FlatAppearance.BorderColor = SystemColors.Control;
            btn_FoodAdd.FlatStyle = FlatStyle.Flat;
            btn_FoodAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_FoodAdd.Location = new Point(680, 340);
            btn_FoodAdd.Margin = new Padding(0);
            btn_FoodAdd.Name = "btn_FoodAdd";
            btn_FoodAdd.Size = new Size(96, 32);
            btn_FoodAdd.TabIndex = 5;
            btn_FoodAdd.Text = "Ekle";
            btn_FoodAdd.UseVisualStyleBackColor = false;
            btn_FoodAdd.Click += btn_FoodAdd_Click;
            // 
            // dgv_foodtoday
            // 
            dgv_foodtoday.BackgroundColor = Color.SeaShell;
            dgv_foodtoday.BorderStyle = BorderStyle.None;
            dgv_foodtoday.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_foodtoday.Location = new Point(11, 84);
            dgv_foodtoday.Name = "dgv_foodtoday";
            dgv_foodtoday.RowTemplate.Height = 25;
            dgv_foodtoday.Size = new Size(765, 243);
            dgv_foodtoday.TabIndex = 4;
            // 
            // UserPanelForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 406);
            Controls.Add(panel3);
            Controls.Add(panel2);
            MainMenuStrip = menuStrip1;
            Name = "UserPanelForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserPanelForm";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_foodtoday).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lbl_Calory;
        private Panel panel2;
        private ProgressBar pb_Calory;
        private Panel panel3;
        private DataGridView dgv_foodtoday;
        private Button btn_FoodAdd;
        private Label lbl_TodayCalory;
        private Label lbl_NeedMaxcalory;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem profilToolStripMenuItem;
        private ToolStripMenuItem şifreDeğiştirToolStripMenuItem;
        private ToolStripMenuItem kullanıcıBilgileriniDeğiştirToolStripMenuItem;
        private ToolStripMenuItem raporlarToolStripMenuItem;
        private ToolStripMenuItem çıkışYapToolStripMenuItem;
        private Panel panel1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}