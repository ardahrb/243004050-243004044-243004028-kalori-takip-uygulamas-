namespace MacroTrackerApp
{
    partial class CalorieCounterForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTopTitle = new System.Windows.Forms.Label();
            this.lblKalori = new System.Windows.Forms.Label();
            this.barKalori = new MacroTrackerApp.MacroProgressBar();
            this.lblProtein = new System.Windows.Forms.Label();
            this.barProtein = new MacroTrackerApp.MacroProgressBar();
            this.lblCarbs = new System.Windows.Forms.Label();
            this.barCarbs = new MacroTrackerApp.MacroProgressBar();
            this.lblFat = new System.Windows.Forms.Label();
            this.barFat = new MacroTrackerApp.MacroProgressBar();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.lblKategori = new System.Windows.Forms.Label();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblOgun = new System.Windows.Forms.Label();
            this.cmbOgun = new System.Windows.Forms.ComboBox();
            this.lblMiktar = new System.Windows.Forms.Label();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvFoods = new System.Windows.Forms.DataGridView();
            this.lblDailyTitle = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvDaily = new System.Windows.Forms.DataGridView();
            this.pnlTop.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaily)).BeginInit();
            this.SuspendLayout();

            // pnlTop
            this.pnlTop.BackColor = AppTheme.BgCard;
            this.pnlTop.Controls.Add(this.lblTopTitle);
            this.pnlTop.Controls.Add(this.lblKalori);
            this.pnlTop.Controls.Add(this.barKalori);
            this.pnlTop.Controls.Add(this.lblProtein);
            this.pnlTop.Controls.Add(this.barProtein);
            this.pnlTop.Controls.Add(this.lblCarbs);
            this.pnlTop.Controls.Add(this.barCarbs);
            this.pnlTop.Controls.Add(this.lblFat);
            this.pnlTop.Controls.Add(this.barFat);
            this.pnlTop.Location = new System.Drawing.Point(10, 10);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(880, 130);

            // lblTopTitle
            this.lblTopTitle.AutoSize = true;
            this.lblTopTitle.Font = AppTheme.FontSubtitle;
            this.lblTopTitle.ForeColor = AppTheme.Accent;
            this.lblTopTitle.Location = new System.Drawing.Point(12, 5);
            this.lblTopTitle.Name = "lblTopTitle";
            this.lblTopTitle.Size = new System.Drawing.Size(107, 19);
            this.lblTopTitle.Text = "Gunluk Ilerleme";

            // lblKalori
            this.lblKalori.AutoSize = true;
            this.lblKalori.Font = AppTheme.FontSmall;
            this.lblKalori.ForeColor = AppTheme.TextSecondary;
            this.lblKalori.Location = new System.Drawing.Point(12, 35);
            this.lblKalori.Name = "lblKalori";
            this.lblKalori.Size = new System.Drawing.Size(37, 15);
            this.lblKalori.Text = "Kalori";

            // barKalori
            this.barKalori.Location = new System.Drawing.Point(70, 32);
            this.barKalori.Name = "barKalori";
            this.barKalori.Size = new System.Drawing.Size(790, 22);
            this.barKalori.BarColor = AppTheme.Accent;

            // lblProtein
            this.lblProtein.AutoSize = true;
            this.lblProtein.Font = AppTheme.FontSmall;
            this.lblProtein.ForeColor = System.Drawing.Color.FromArgb(72, 199, 142);
            this.lblProtein.Location = new System.Drawing.Point(12, 62);
            this.lblProtein.Name = "lblProtein";
            this.lblProtein.Size = new System.Drawing.Size(45, 15);
            this.lblProtein.Text = "Protein";

            // barProtein
            this.barProtein.Location = new System.Drawing.Point(70, 59);
            this.barProtein.Name = "barProtein";
            this.barProtein.Size = new System.Drawing.Size(255, 18);
            this.barProtein.BarColor = AppTheme.AccentGreen;

            // lblCarbs
            this.lblCarbs.AutoSize = true;
            this.lblCarbs.Font = AppTheme.FontSmall;
            this.lblCarbs.ForeColor = System.Drawing.Color.FromArgb(237, 167, 70);
            this.lblCarbs.Location = new System.Drawing.Point(340, 62);
            this.lblCarbs.Name = "lblCarbs";
            this.lblCarbs.Size = new System.Drawing.Size(34, 15);
            this.lblCarbs.Text = "Karb.";

            // barCarbs
            this.barCarbs.Location = new System.Drawing.Point(385, 59);
            this.barCarbs.Name = "barCarbs";
            this.barCarbs.Size = new System.Drawing.Size(235, 18);
            this.barCarbs.BarColor = AppTheme.AccentOrange;

            // lblFat
            this.lblFat.AutoSize = true;
            this.lblFat.Font = AppTheme.FontSmall;
            this.lblFat.ForeColor = System.Drawing.Color.FromArgb(235, 87, 87);
            this.lblFat.Location = new System.Drawing.Point(635, 62);
            this.lblFat.Name = "lblFat";
            this.lblFat.Size = new System.Drawing.Size(25, 15);
            this.lblFat.Text = "Yag";

            // barFat
            this.barFat.Location = new System.Drawing.Point(665, 59);
            this.barFat.Name = "barFat";
            this.barFat.Size = new System.Drawing.Size(195, 18);
            this.barFat.BarColor = AppTheme.AccentRed;

            // pnlSearch
            this.pnlSearch.BackColor = AppTheme.BgCard;
            this.pnlSearch.Controls.Add(this.lblKategori);
            this.pnlSearch.Controls.Add(this.cmbKategori);
            this.pnlSearch.Controls.Add(this.lblSearch);
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Controls.Add(this.lblOgun);
            this.pnlSearch.Controls.Add(this.cmbOgun);
            this.pnlSearch.Controls.Add(this.lblMiktar);
            this.pnlSearch.Controls.Add(this.txtMiktar);
            this.pnlSearch.Controls.Add(this.btnAdd);
            this.pnlSearch.Location = new System.Drawing.Point(10, 150);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(880, 42);

            // lblKategori
            this.lblKategori.AutoSize = true;
            this.lblKategori.Font = AppTheme.FontSmall;
            this.lblKategori.ForeColor = AppTheme.TextSecondary;
            this.lblKategori.Location = new System.Drawing.Point(8, 10);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(54, 15);
            this.lblKategori.Text = "Kategori:";

            // cmbKategori
            this.cmbKategori.BackColor = AppTheme.BgInput;
            this.cmbKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKategori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbKategori.Font = AppTheme.FontBody;
            this.cmbKategori.ForeColor = AppTheme.TextPrimary;
            this.cmbKategori.Location = new System.Drawing.Point(68, 6);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(145, 25);

            // lblSearch
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = AppTheme.FontSmall;
            this.lblSearch.ForeColor = AppTheme.TextSecondary;
            this.lblSearch.Location = new System.Drawing.Point(222, 10);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(28, 15);
            this.lblSearch.Text = "Ara:";

            // txtSearch
            this.txtSearch.BackColor = AppTheme.BgInput;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = AppTheme.FontBody;
            this.txtSearch.ForeColor = AppTheme.TextPrimary;
            this.txtSearch.Location = new System.Drawing.Point(250, 6);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(145, 25);

            // lblOgun
            this.lblOgun.AutoSize = true;
            this.lblOgun.Font = AppTheme.FontSmall;
            this.lblOgun.ForeColor = AppTheme.TextSecondary;
            this.lblOgun.Location = new System.Drawing.Point(405, 10);
            this.lblOgun.Name = "lblOgun";
            this.lblOgun.Size = new System.Drawing.Size(40, 15);
            this.lblOgun.Text = "Ogun:";

            // cmbOgun
            this.cmbOgun.BackColor = AppTheme.BgInput;
            this.cmbOgun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOgun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbOgun.Font = AppTheme.FontBody;
            this.cmbOgun.ForeColor = AppTheme.TextPrimary;
            this.cmbOgun.Items.AddRange(new object[] { "Kahvalti", "Ogle Yemegi", "Aksam Yemegi", "Atistirmalik" });
            this.cmbOgun.Location = new System.Drawing.Point(440, 6);
            this.cmbOgun.Name = "cmbOgun";
            this.cmbOgun.Size = new System.Drawing.Size(130, 25);

            // lblMiktar
            this.lblMiktar.AutoSize = true;
            this.lblMiktar.Font = AppTheme.FontSmall;
            this.lblMiktar.ForeColor = AppTheme.TextSecondary;
            this.lblMiktar.Location = new System.Drawing.Point(582, 10);
            this.lblMiktar.Name = "lblMiktar";
            this.lblMiktar.Size = new System.Drawing.Size(44, 15);
            this.lblMiktar.Text = "Gram:";

            // txtMiktar
            this.txtMiktar.BackColor = AppTheme.BgInput;
            this.txtMiktar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMiktar.Font = AppTheme.FontBody;
            this.txtMiktar.ForeColor = AppTheme.TextPrimary;
            this.txtMiktar.Location = new System.Drawing.Point(622, 6);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(60, 25);
            this.txtMiktar.Text = "100";

            // btnAdd
            this.btnAdd.BackColor = AppTheme.AccentGreen;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = AppTheme.FontBody;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(695, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(170, 32);
            this.btnAdd.Text = "EKLE";
            this.btnAdd.UseVisualStyleBackColor = false;

            // dgvFoods
            this.dgvFoods.Location = new System.Drawing.Point(10, 198);
            this.dgvFoods.Name = "dgvFoods";
            this.dgvFoods.Size = new System.Drawing.Size(880, 200);

            // lblDailyTitle
            this.lblDailyTitle.AutoSize = true;
            this.lblDailyTitle.Font = AppTheme.FontSubtitle;
            this.lblDailyTitle.ForeColor = AppTheme.Accent;
            this.lblDailyTitle.Location = new System.Drawing.Point(12, 407);
            this.lblDailyTitle.Name = "lblDailyTitle";
            this.lblDailyTitle.Size = new System.Drawing.Size(127, 19);
            this.lblDailyTitle.Text = "Bugunku Tuketimim";

            // btnDelete
            this.btnDelete.BackColor = AppTheme.AccentRed;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = AppTheme.FontBody;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(740, 404);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 30);
            this.btnDelete.Text = "Secili Kaydi Sil";
            this.btnDelete.UseVisualStyleBackColor = false;

            // dgvDaily
            this.dgvDaily.Location = new System.Drawing.Point(10, 438);
            this.dgvDaily.Name = "dgvDaily";
            this.dgvDaily.Size = new System.Drawing.Size(880, 290);

            // CalorieCounterForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = AppTheme.BgDark;
            this.ClientSize = new System.Drawing.Size(900, 740);
            this.Controls.Add(this.dgvDaily);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblDailyTitle);
            this.Controls.Add(this.dgvFoods);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CalorieCounterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kalori Sayaci";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaily)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTopTitle;
        private System.Windows.Forms.Label lblKalori;
        private MacroTrackerApp.MacroProgressBar barKalori;
        private System.Windows.Forms.Label lblProtein;
        private MacroTrackerApp.MacroProgressBar barProtein;
        private System.Windows.Forms.Label lblCarbs;
        private MacroTrackerApp.MacroProgressBar barCarbs;
        private System.Windows.Forms.Label lblFat;
        private MacroTrackerApp.MacroProgressBar barFat;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblOgun;
        private System.Windows.Forms.ComboBox cmbOgun;
        private System.Windows.Forms.Label lblMiktar;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvFoods;
        private System.Windows.Forms.Label lblDailyTitle;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvDaily;
    }
}
