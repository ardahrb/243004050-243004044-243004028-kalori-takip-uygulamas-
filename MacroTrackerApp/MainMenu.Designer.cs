namespace MacroTrackerApp
{
    partial class MainMenu
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnCounter = new System.Windows.Forms.Button();
            this.btnRecipe = new System.Windows.Forms.Button();
            this.lblFooter = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();

            // pnlHeader
            this.pnlHeader.BackColor = AppTheme.BgCard;
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblInfo);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(520, 90);

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = AppTheme.TextPrimary;
            this.lblTitle.Location = new System.Drawing.Point(20, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(150, 31);
            this.lblTitle.Text = "Hos Geldin!";

            // lblInfo
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = AppTheme.FontSmall;
            this.lblInfo.ForeColor = AppTheme.TextSecondary;
            this.lblInfo.Location = new System.Drawing.Point(20, 52);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(80, 15);
            this.lblInfo.Text = "Hedef Bilgisi";

            // btnCalc
            this.btnCalc.BackColor = AppTheme.Accent;
            this.btnCalc.FlatAppearance.BorderSize = 0;
            this.btnCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalc.Font = new System.Drawing.Font("Segoe UI Semibold", 13F);
            this.btnCalc.ForeColor = System.Drawing.Color.White;
            this.btnCalc.Location = new System.Drawing.Point(40, 110);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(440, 60);
            this.btnCalc.Text = "Hedef Kalori Hesaplama";
            this.btnCalc.UseVisualStyleBackColor = false;

            // btnCounter
            this.btnCounter.BackColor = AppTheme.AccentGreen;
            this.btnCounter.FlatAppearance.BorderSize = 0;
            this.btnCounter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCounter.Font = new System.Drawing.Font("Segoe UI Semibold", 13F);
            this.btnCounter.ForeColor = System.Drawing.Color.White;
            this.btnCounter.Location = new System.Drawing.Point(40, 190);
            this.btnCounter.Name = "btnCounter";
            this.btnCounter.Size = new System.Drawing.Size(440, 60);
            this.btnCounter.Text = "Kalori Sayaci";
            this.btnCounter.UseVisualStyleBackColor = false;

            // btnRecipe
            this.btnRecipe.BackColor = AppTheme.AccentPurple;
            this.btnRecipe.FlatAppearance.BorderSize = 0;
            this.btnRecipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecipe.Font = new System.Drawing.Font("Segoe UI Semibold", 13F);
            this.btnRecipe.ForeColor = System.Drawing.Color.White;
            this.btnRecipe.Location = new System.Drawing.Point(40, 270);
            this.btnRecipe.Name = "btnRecipe";
            this.btnRecipe.Size = new System.Drawing.Size(440, 60);
            this.btnRecipe.Text = "Tarif Sihirbazi";
            this.btnRecipe.UseVisualStyleBackColor = false;

            // lblFooter
            this.lblFooter.AutoSize = true;
            this.lblFooter.Font = AppTheme.FontSmall;
            this.lblFooter.ForeColor = AppTheme.TextSecondary;
            this.lblFooter.Location = new System.Drawing.Point(110, 370);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(306, 15);
            this.lblFooter.Text = "Makro Tracker v2.0 \u2022 SQL Server \u2022 Mifflin-St Jeor";

            // MainMenu
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = AppTheme.BgDark;
            this.ClientSize = new System.Drawing.Size(520, 420);
            this.Controls.Add(this.lblFooter);
            this.Controls.Add(this.btnRecipe);
            this.Controls.Add(this.btnCounter);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Makro & Kalori Takip Sistemi";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnCounter;
        private System.Windows.Forms.Button btnRecipe;
        private System.Windows.Forms.Label lblFooter;
    }
}
