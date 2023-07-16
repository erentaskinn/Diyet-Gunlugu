namespace FormOgunGosterim
{
    partial class FoodListForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoodListForm));
            cmsBreakFast = new ContextMenuStrip(components);
            SilBreakfast = new ToolStripMenuItem();
            smsDüzenleBreakfast = new ToolStripMenuItem();
            cmsLunch = new ContextMenuStrip(components);
            cmsLunchSil = new ToolStripMenuItem();
            smtDüzenleLunch = new ToolStripMenuItem();
            cmsSnack = new ContextMenuStrip(components);
            stmSnacSil = new ToolStripMenuItem();
            smtDüzenleSnack = new ToolStripMenuItem();
            cmsDinner = new ContextMenuStrip(components);
            stmSilDinner = new ToolStripMenuItem();
            smtDnnerDüzenle = new ToolStripMenuItem();
            tpDınner = new TabPage();
            label5 = new Label();
            dtpDinner = new DateTimePicker();
            btnDinnerAdd = new Button();
            dgwDinner = new DataGridView();
            tpSnack = new TabPage();
            label3 = new Label();
            dtpSnack = new DateTimePicker();
            btnDreamMealAdd = new Button();
            dgwSnack = new DataGridView();
            tpOgle = new TabPage();
            label1 = new Label();
            dtpLunch = new DateTimePicker();
            btnLunchAdd = new Button();
            dgwLunch = new DataGridView();
            tpKahvalti = new TabPage();
            label2 = new Label();
            dtpBreakfast = new DateTimePicker();
            btnBreakfastAdd = new Button();
            dgwBreakfast = new DataGridView();
            OgunGosterim = new TabControl();
            cmsBreakFast.SuspendLayout();
            cmsLunch.SuspendLayout();
            cmsSnack.SuspendLayout();
            cmsDinner.SuspendLayout();
            tpDınner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwDinner).BeginInit();
            tpSnack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwSnack).BeginInit();
            tpOgle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwLunch).BeginInit();
            tpKahvalti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwBreakfast).BeginInit();
            OgunGosterim.SuspendLayout();
            SuspendLayout();
            // 
            // cmsBreakFast
            // 
            cmsBreakFast.Items.AddRange(new ToolStripItem[] { SilBreakfast, smsDüzenleBreakfast });
            cmsBreakFast.Name = "cmsBreakFast";
            cmsBreakFast.Size = new Size(125, 48);
            // 
            // SilBreakfast
            // 
            SilBreakfast.Name = "SilBreakfast";
            SilBreakfast.Size = new Size(124, 22);
            SilBreakfast.Text = "SİL";
            SilBreakfast.Click += SilBreakfast_Click;
            // 
            // smsDüzenleBreakfast
            // 
            smsDüzenleBreakfast.Name = "smsDüzenleBreakfast";
            smsDüzenleBreakfast.Size = new Size(124, 22);
            smsDüzenleBreakfast.Text = "DÜZENLE";
            smsDüzenleBreakfast.Click += smsDüzenleBreakfast_Click;
            // 
            // cmsLunch
            // 
            cmsLunch.Items.AddRange(new ToolStripItem[] { cmsLunchSil, smtDüzenleLunch });
            cmsLunch.Name = "cmsLunch";
            cmsLunch.Size = new Size(125, 48);
            // 
            // cmsLunchSil
            // 
            cmsLunchSil.Name = "cmsLunchSil";
            cmsLunchSil.Size = new Size(124, 22);
            cmsLunchSil.Text = "SİL";
            cmsLunchSil.Click += cmsLunchSil_Click;
            // 
            // smtDüzenleLunch
            // 
            smtDüzenleLunch.Name = "smtDüzenleLunch";
            smtDüzenleLunch.Size = new Size(124, 22);
            smtDüzenleLunch.Text = "DÜZENLE";
            smtDüzenleLunch.Click += smtDüzenleLunch_Click;
            // 
            // cmsSnack
            // 
            cmsSnack.Items.AddRange(new ToolStripItem[] { stmSnacSil, smtDüzenleSnack });
            cmsSnack.Name = "cmsSnack";
            cmsSnack.Size = new Size(125, 48);
            // 
            // stmSnacSil
            // 
            stmSnacSil.Name = "stmSnacSil";
            stmSnacSil.Size = new Size(124, 22);
            stmSnacSil.Text = "SİL";
            stmSnacSil.Click += stmSnacSil_Click;
            // 
            // smtDüzenleSnack
            // 
            smtDüzenleSnack.Name = "smtDüzenleSnack";
            smtDüzenleSnack.Size = new Size(124, 22);
            smtDüzenleSnack.Text = "DÜZENLE";
            smtDüzenleSnack.Click += smtDüzenleSnack_Click;
            // 
            // cmsDinner
            // 
            cmsDinner.Items.AddRange(new ToolStripItem[] { stmSilDinner, smtDnnerDüzenle });
            cmsDinner.Name = "cmsDinner";
            cmsDinner.Size = new Size(125, 48);
            // 
            // stmSilDinner
            // 
            stmSilDinner.Name = "stmSilDinner";
            stmSilDinner.Size = new Size(124, 22);
            stmSilDinner.Text = "SİL";
            stmSilDinner.Click += stmSilDinner_Click;
            // 
            // smtDnnerDüzenle
            // 
            smtDnnerDüzenle.Name = "smtDnnerDüzenle";
            smtDnnerDüzenle.Size = new Size(124, 22);
            smtDnnerDüzenle.Text = "DÜZENLE";
            smtDnnerDüzenle.Click += smtDnnerDüzenle_Click;
            // 
            // tpDınner
            // 
            tpDınner.BackColor = Color.Transparent;
            tpDınner.BackgroundImage = DiyetGunlugu.UI.Properties.Resources.Custom_Designed_Illustrations___897818__Printable_Illustrations___Creativa_Fabrica;
            tpDınner.BackgroundImageLayout = ImageLayout.Stretch;
            tpDınner.Controls.Add(label5);
            tpDınner.Controls.Add(dtpDinner);
            tpDınner.Controls.Add(btnDinnerAdd);
            tpDınner.Controls.Add(dgwDinner);
            tpDınner.Font = new Font("Calibri", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            tpDınner.Location = new Point(4, 35);
            tpDınner.Name = "tpDınner";
            tpDınner.Padding = new Padding(3);
            tpDınner.Size = new Size(775, 454);
            tpDınner.TabIndex = 3;
            tpDınner.Text = "Akşam Yemeği";
            // 
            // label5
            // 
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Font = new Font("Calibri", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = Color.Crimson;
            label5.Location = new Point(15, 13);
            label5.Name = "label5";
            label5.Size = new Size(748, 66);
            label5.TabIndex = 4;
            label5.Text = resources.GetString("label5.Text");
            // 
            // dtpDinner
            // 
            dtpDinner.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpDinner.Location = new Point(543, 82);
            dtpDinner.Name = "dtpDinner";
            dtpDinner.Size = new Size(220, 27);
            dtpDinner.TabIndex = 2;
            dtpDinner.ValueChanged += dtpDinner_ValueChanged;
            // 
            // btnDinnerAdd
            // 
            btnDinnerAdd.BackColor = Color.SeaShell;
            btnDinnerAdd.Font = new Font("Calibri", 13F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnDinnerAdd.Location = new Point(670, 411);
            btnDinnerAdd.Name = "btnDinnerAdd";
            btnDinnerAdd.Size = new Size(93, 37);
            btnDinnerAdd.TabIndex = 1;
            btnDinnerAdd.Text = "Ekle";
            btnDinnerAdd.UseVisualStyleBackColor = false;
            btnDinnerAdd.Click += btnDinnerAdd_Click_1;
            // 
            // dgwDinner
            // 
            dgwDinner.AllowUserToOrderColumns = true;
            dgwDinner.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwDinner.BackgroundColor = Color.Snow;
            dgwDinner.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwDinner.ContextMenuStrip = cmsDinner;
            dgwDinner.Location = new Point(15, 115);
            dgwDinner.Name = "dgwDinner";
            dgwDinner.RowTemplate.Height = 25;
            dgwDinner.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwDinner.Size = new Size(748, 290);
            dgwDinner.TabIndex = 0;
            // 
            // tpSnack
            // 
            tpSnack.BackColor = Color.Bisque;
            tpSnack.BackgroundImage = DiyetGunlugu.UI.Properties.Resources.Custom_Designed_Illustrations___897818__Printable_Illustrations___Creativa_Fabrica1;
            tpSnack.BackgroundImageLayout = ImageLayout.Stretch;
            tpSnack.Controls.Add(label3);
            tpSnack.Controls.Add(dtpSnack);
            tpSnack.Controls.Add(btnDreamMealAdd);
            tpSnack.Controls.Add(dgwSnack);
            tpSnack.Font = new Font("Calibri", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            tpSnack.Location = new Point(4, 35);
            tpSnack.Name = "tpSnack";
            tpSnack.Padding = new Padding(3);
            tpSnack.Size = new Size(775, 454);
            tpSnack.TabIndex = 2;
            tpSnack.Text = "Atıştırmalık";
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Calibri", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.Crimson;
            label3.Location = new Point(14, 14);
            label3.Name = "label3";
            label3.Size = new Size(749, 68);
            label3.TabIndex = 3;
            label3.Text = resources.GetString("label3.Text");
            // 
            // dtpSnack
            // 
            dtpSnack.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpSnack.Location = new Point(541, 85);
            dtpSnack.Name = "dtpSnack";
            dtpSnack.Size = new Size(222, 27);
            dtpSnack.TabIndex = 2;
            dtpSnack.ValueChanged += dtpSnack_ValueChanged;
            // 
            // btnDreamMealAdd
            // 
            btnDreamMealAdd.BackColor = Color.SeaShell;
            btnDreamMealAdd.Font = new Font("Calibri", 13F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnDreamMealAdd.Location = new Point(670, 405);
            btnDreamMealAdd.Name = "btnDreamMealAdd";
            btnDreamMealAdd.Size = new Size(93, 37);
            btnDreamMealAdd.TabIndex = 1;
            btnDreamMealAdd.Text = "Ekle";
            btnDreamMealAdd.UseVisualStyleBackColor = false;
            btnDreamMealAdd.Click += btnDreamMealAdd_Click_1;
            // 
            // dgwSnack
            // 
            dgwSnack.AllowUserToOrderColumns = true;
            dgwSnack.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwSnack.BackgroundColor = Color.Snow;
            dgwSnack.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwSnack.ContextMenuStrip = cmsSnack;
            dgwSnack.Location = new Point(14, 118);
            dgwSnack.Name = "dgwSnack";
            dgwSnack.RowTemplate.Height = 25;
            dgwSnack.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwSnack.Size = new Size(749, 281);
            dgwSnack.TabIndex = 0;
            // 
            // tpOgle
            // 
            tpOgle.BackColor = Color.OldLace;
            tpOgle.BackgroundImage = DiyetGunlugu.UI.Properties.Resources.Custom_Designed_Illustrations___897818__Printable_Illustrations___Creativa_Fabrica;
            tpOgle.BackgroundImageLayout = ImageLayout.Stretch;
            tpOgle.Controls.Add(label1);
            tpOgle.Controls.Add(dtpLunch);
            tpOgle.Controls.Add(btnLunchAdd);
            tpOgle.Controls.Add(dgwLunch);
            tpOgle.Font = new Font("Calibri", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            tpOgle.Location = new Point(4, 35);
            tpOgle.Name = "tpOgle";
            tpOgle.Padding = new Padding(3);
            tpOgle.Size = new Size(775, 454);
            tpOgle.TabIndex = 1;
            tpOgle.Text = "Öğle Yemeği";
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Calibri", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(749, 36);
            label1.TabIndex = 3;
            label1.Text = "Öğle yemeği, öğleden sonra boyunca sizi ayakta tutacak besin ve enerji sağlayan, günün önemli bir öğünüdür. Dengeli bir öğün sağlamak için çeşitli yiyecek gruplarını dahil etmeniz önerilir.";
            // 
            // dtpLunch
            // 
            dtpLunch.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpLunch.Location = new Point(544, 65);
            dtpLunch.Name = "dtpLunch";
            dtpLunch.Size = new Size(217, 27);
            dtpLunch.TabIndex = 2;
            dtpLunch.ValueChanged += dtpLunch_ValueChanged;
            // 
            // btnLunchAdd
            // 
            btnLunchAdd.BackColor = Color.SeaShell;
            btnLunchAdd.Font = new Font("Calibri", 13F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnLunchAdd.Location = new Point(668, 407);
            btnLunchAdd.Name = "btnLunchAdd";
            btnLunchAdd.Size = new Size(93, 37);
            btnLunchAdd.TabIndex = 1;
            btnLunchAdd.Text = "Ekle";
            btnLunchAdd.UseVisualStyleBackColor = false;
            btnLunchAdd.Click += btnLunchAdd_Click_1;
            // 
            // dgwLunch
            // 
            dgwLunch.AllowUserToOrderColumns = true;
            dgwLunch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwLunch.BackgroundColor = Color.Snow;
            dgwLunch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwLunch.ContextMenuStrip = cmsLunch;
            dgwLunch.Location = new Point(12, 98);
            dgwLunch.Name = "dgwLunch";
            dgwLunch.RowTemplate.Height = 25;
            dgwLunch.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwLunch.Size = new Size(749, 303);
            dgwLunch.TabIndex = 0;
            // 
            // tpKahvalti
            // 
            tpKahvalti.BackColor = Color.MintCream;
            tpKahvalti.BackgroundImage = DiyetGunlugu.UI.Properties.Resources.Custom_Designed_Illustrations___897818__Printable_Illustrations___Creativa_Fabrica;
            tpKahvalti.BackgroundImageLayout = ImageLayout.Stretch;
            tpKahvalti.Controls.Add(label2);
            tpKahvalti.Controls.Add(dtpBreakfast);
            tpKahvalti.Controls.Add(btnBreakfastAdd);
            tpKahvalti.Controls.Add(dgwBreakfast);
            tpKahvalti.Font = new Font("Calibri", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            tpKahvalti.ForeColor = SystemColors.ControlText;
            tpKahvalti.Location = new Point(4, 35);
            tpKahvalti.Name = "tpKahvalti";
            tpKahvalti.Padding = new Padding(3);
            tpKahvalti.Size = new Size(775, 454);
            tpKahvalti.TabIndex = 0;
            tpKahvalti.Text = "Kahvaltı";
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Calibri", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.Crimson;
            label2.Location = new Point(13, 13);
            label2.Name = "label2";
            label2.Size = new Size(749, 68);
            label2.TabIndex = 4;
            label2.Text = resources.GetString("label2.Text");
            // 
            // dtpBreakfast
            // 
            dtpBreakfast.CalendarFont = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dtpBreakfast.CalendarForeColor = Color.SeaShell;
            dtpBreakfast.CalendarMonthBackground = Color.SeaShell;
            dtpBreakfast.CalendarTitleBackColor = Color.SeaShell;
            dtpBreakfast.CalendarTitleForeColor = Color.SeaShell;
            dtpBreakfast.CalendarTrailingForeColor = Color.SeaShell;
            dtpBreakfast.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpBreakfast.Location = new Point(539, 84);
            dtpBreakfast.Name = "dtpBreakfast";
            dtpBreakfast.Size = new Size(223, 27);
            dtpBreakfast.TabIndex = 2;
            dtpBreakfast.ValueChanged += dtpBreakfast_ValueChanged;
            // 
            // btnBreakfastAdd
            // 
            btnBreakfastAdd.BackColor = Color.SeaShell;
            btnBreakfastAdd.Font = new Font("Calibri", 13F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnBreakfastAdd.Location = new Point(669, 409);
            btnBreakfastAdd.Name = "btnBreakfastAdd";
            btnBreakfastAdd.Size = new Size(93, 37);
            btnBreakfastAdd.TabIndex = 1;
            btnBreakfastAdd.Text = "Ekle";
            btnBreakfastAdd.UseVisualStyleBackColor = false;
            btnBreakfastAdd.Click += btnBreakfastAdd_Click_1;
            // 
            // dgwBreakfast
            // 
            dgwBreakfast.AllowUserToOrderColumns = true;
            dgwBreakfast.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwBreakfast.BackgroundColor = Color.Snow;
            dgwBreakfast.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwBreakfast.ContextMenuStrip = cmsBreakFast;
            dgwBreakfast.Location = new Point(13, 117);
            dgwBreakfast.Name = "dgwBreakfast";
            dgwBreakfast.RowTemplate.Height = 25;
            dgwBreakfast.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwBreakfast.Size = new Size(749, 285);
            dgwBreakfast.TabIndex = 0;
            // 
            // OgunGosterim
            // 
            OgunGosterim.Controls.Add(tpKahvalti);
            OgunGosterim.Controls.Add(tpOgle);
            OgunGosterim.Controls.Add(tpSnack);
            OgunGosterim.Controls.Add(tpDınner);
            OgunGosterim.Dock = DockStyle.Fill;
            OgunGosterim.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            OgunGosterim.ImeMode = ImeMode.NoControl;
            OgunGosterim.Location = new Point(0, 0);
            OgunGosterim.Name = "OgunGosterim";
            OgunGosterim.SelectedIndex = 0;
            OgunGosterim.Size = new Size(783, 493);
            OgunGosterim.TabIndex = 0;
            // 
            // FoodListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(783, 493);
            Controls.Add(OgunGosterim);
            Name = "FoodListForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MEAL SCREENNİNG";
            cmsBreakFast.ResumeLayout(false);
            cmsLunch.ResumeLayout(false);
            cmsSnack.ResumeLayout(false);
            cmsDinner.ResumeLayout(false);
            tpDınner.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgwDinner).EndInit();
            tpSnack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgwSnack).EndInit();
            tpOgle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgwLunch).EndInit();
            tpKahvalti.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgwBreakfast).EndInit();
            OgunGosterim.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ContextMenuStrip cmsLunch;
        private ToolStripMenuItem cmsLunchSil;
        private ToolStripMenuItem smtDüzenleLunch;
        private ContextMenuStrip cmsBreakFast;
        private ToolStripMenuItem SilBreakfast;
        private ToolStripMenuItem smsDüzenleBreakfast;
        private ContextMenuStrip cmsSnack;
        private ToolStripMenuItem stmSnacSil;
        private ToolStripMenuItem smtDüzenleSnack;
        private ContextMenuStrip cmsDinner;
        private ToolStripMenuItem stmSilDinner;
        private ToolStripMenuItem smtDnnerDüzenle;
        private TabPage tpDınner;
        private DateTimePicker dtpDinner;
        private Button btnDinnerAdd;
        private DataGridView dgwDinner;
        private TabPage tpSnack;
        private DateTimePicker dtpSnack;
        private Button btnDreamMealAdd;
        private DataGridView dgwSnack;
        private TabPage tpOgle;
        private Label label1;
        private DateTimePicker dtpLunch;
        private Button btnLunchAdd;
        private DataGridView dgwLunch;
        private TabPage tpKahvalti;
        private Label label2;
        private DateTimePicker dtpBreakfast;
        private Button btnBreakfastAdd;
        private DataGridView dgwBreakfast;
        private TabControl OgunGosterim;
        private Label label3;
        private Label label5;
    }
}