namespace MacroTrackerApp
{
    partial class UserLoginForm
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
            this.lblSub = new System.Windows.Forms.Label();
            this.card = new System.Windows.Forms.Panel();
            this.lblProfile = new System.Windows.Forms.Label();
            this.cmbUsers = new System.Windows.Forms.ComboBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnNewUser = new System.Windows.Forms.Button();
            this.lblVer = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.card.SuspendLayout();
            this.SuspendLayout();

            // pnlHeader
            this.pnlHeader.BackColor = AppTheme.BgCard;
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblSub);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(480, 80);

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = AppTheme.TextPrimary;
            this.lblTitle.Location = new System.Drawing.Point(20, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(315, 30);
            this.lblTitle.Text = "Makro & Kalori Takip Sistemi";

            // lblSub
            this.lblSub.AutoSize = true;
            this.lblSub.Font = AppTheme.FontSmall;
            this.lblSub.ForeColor = AppTheme.TextSecondary;
            this.lblSub.Location = new System.Drawing.Point(20, 48);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(183, 15);
            this.lblSub.Text = "Beslenme hedeflerinizi takip edin";

            // card
            this.card.BackColor = AppTheme.BgCard;
            this.card.Controls.Add(this.lblProfile);
            this.card.Controls.Add(this.cmbUsers);
            this.card.Controls.Add(this.btnSelect);
            this.card.Controls.Add(this.btnNewUser);
            this.card.Controls.Add(this.lblVer);
            this.card.Location = new System.Drawing.Point(20, 95);
            this.card.Name = "card";
            this.card.Size = new System.Drawing.Size(440, 195);

            // lblProfile
            this.lblProfile.AutoSize = true;
            this.lblProfile.Font = AppTheme.FontSubtitle;
            this.lblProfile.ForeColor = AppTheme.Accent;
            this.lblProfile.Location = new System.Drawing.Point(12, 8);
            this.lblProfile.Name = "lblProfile";
            this.lblProfile.Size = new System.Drawing.Size(83, 19);
            this.lblProfile.Text = "Profil Secin";

            // cmbUsers
            this.cmbUsers.BackColor = AppTheme.BgInput;
            this.cmbUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbUsers.Font = AppTheme.FontBody;
            this.cmbUsers.ForeColor = AppTheme.TextPrimary;
            this.cmbUsers.Location = new System.Drawing.Point(12, 40);
            this.cmbUsers.Name = "cmbUsers";
            this.cmbUsers.Size = new System.Drawing.Size(410, 25);

            // btnSelect
            this.btnSelect.BackColor = AppTheme.Accent;
            this.btnSelect.FlatAppearance.BorderSize = 0;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Font = AppTheme.FontBtnLarge;
            this.btnSelect.ForeColor = System.Drawing.Color.White;
            this.btnSelect.Location = new System.Drawing.Point(12, 85);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(195, 42);
            this.btnSelect.Text = "Giris Yap";
            this.btnSelect.UseVisualStyleBackColor = false;

            // btnNewUser
            this.btnNewUser.BackColor = AppTheme.AccentGreen;
            this.btnNewUser.FlatAppearance.BorderSize = 0;
            this.btnNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewUser.Font = AppTheme.FontBtnLarge;
            this.btnNewUser.ForeColor = System.Drawing.Color.White;
            this.btnNewUser.Location = new System.Drawing.Point(220, 85);
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.Size = new System.Drawing.Size(195, 42);
            this.btnNewUser.Text = "Yeni Kayit";
            this.btnNewUser.UseVisualStyleBackColor = false;

            // lblVer
            this.lblVer.AutoSize = true;
            this.lblVer.Font = AppTheme.FontSmall;
            this.lblVer.ForeColor = AppTheme.TextSecondary;
            this.lblVer.Location = new System.Drawing.Point(12, 142);
            this.lblVer.Name = "lblVer";
            this.lblVer.Size = new System.Drawing.Size(206, 15);
            this.lblVer.Text = "v2.0 \u2022 Mifflin-St Jeor \u2022 SQL Server";

            // UserLoginForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = AppTheme.BgDark;
            this.ClientSize = new System.Drawing.Size(480, 310);
            this.Controls.Add(this.card);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "UserLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Makro Takip Sistemi";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.card.ResumeLayout(false);
            this.card.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.Panel card;
        private System.Windows.Forms.Label lblProfile;
        private System.Windows.Forms.ComboBox cmbUsers;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnNewUser;
        private System.Windows.Forms.Label lblVer;
    }
}
