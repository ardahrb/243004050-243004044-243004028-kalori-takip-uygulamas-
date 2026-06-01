namespace MacroTrackerApp
{
    partial class RegisterForm
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
            this.card = new System.Windows.Forms.Panel();
            this.lblT = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.lblDogum = new System.Windows.Forms.Label();
            this.dtpDogum = new System.Windows.Forms.DateTimePicker();
            this.lblCinsiyet = new System.Windows.Forms.Label();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.lblBoy = new System.Windows.Forms.Label();
            this.txtBoy = new System.Windows.Forms.TextBox();
            this.lblKilo = new System.Windows.Forms.Label();
            this.txtKilo = new System.Windows.Forms.TextBox();
            this.lblAktivite = new System.Windows.Forms.Label();
            this.cmbAktivite = new System.Windows.Forms.ComboBox();
            this.lblHedef = new System.Windows.Forms.Label();
            this.cmbHedef = new System.Windows.Forms.ComboBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.card.SuspendLayout();
            this.SuspendLayout();

            // card
            this.card.BackColor = AppTheme.BgCard;
            this.card.Controls.Add(this.lblT);
            this.card.Controls.Add(this.lblAd);
            this.card.Controls.Add(this.txtAd);
            this.card.Controls.Add(this.lblSoyad);
            this.card.Controls.Add(this.txtSoyad);
            this.card.Controls.Add(this.lblDogum);
            this.card.Controls.Add(this.dtpDogum);
            this.card.Controls.Add(this.lblCinsiyet);
            this.card.Controls.Add(this.cmbCinsiyet);
            this.card.Controls.Add(this.lblBoy);
            this.card.Controls.Add(this.txtBoy);
            this.card.Controls.Add(this.lblKilo);
            this.card.Controls.Add(this.txtKilo);
            this.card.Controls.Add(this.lblAktivite);
            this.card.Controls.Add(this.cmbAktivite);
            this.card.Controls.Add(this.lblHedef);
            this.card.Controls.Add(this.cmbHedef);
            this.card.Controls.Add(this.btnKaydet);
            this.card.Location = new System.Drawing.Point(15, 15);
            this.card.Name = "card";
            this.card.Size = new System.Drawing.Size(390, 490);

            // lblT
            this.lblT.AutoSize = true;
            this.lblT.Font = AppTheme.FontTitle;
            this.lblT.ForeColor = AppTheme.Accent;
            this.lblT.Location = new System.Drawing.Point(12, 8);
            this.lblT.Name = "lblT";
            this.lblT.Size = new System.Drawing.Size(130, 21);
            this.lblT.Text = "Yeni Profil Olustur";

            // lblAd
            this.lblAd.AutoSize = true;
            this.lblAd.Font = AppTheme.FontBody;
            this.lblAd.ForeColor = AppTheme.TextSecondary;
            this.lblAd.Location = new System.Drawing.Point(12, 50);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(32, 19);
            this.lblAd.Text = "Ad:";

            // txtAd
            this.txtAd.BackColor = AppTheme.BgInput;
            this.txtAd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAd.Font = AppTheme.FontBody;
            this.txtAd.ForeColor = AppTheme.TextPrimary;
            this.txtAd.Location = new System.Drawing.Point(160, 50);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(200, 25);

            // lblSoyad
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Font = AppTheme.FontBody;
            this.lblSoyad.ForeColor = AppTheme.TextSecondary;
            this.lblSoyad.Location = new System.Drawing.Point(12, 98);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(53, 19);
            this.lblSoyad.Text = "Soyad:";

            // txtSoyad
            this.txtSoyad.BackColor = AppTheme.BgInput;
            this.txtSoyad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoyad.Font = AppTheme.FontBody;
            this.txtSoyad.ForeColor = AppTheme.TextPrimary;
            this.txtSoyad.Location = new System.Drawing.Point(160, 98);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(200, 25);

            // lblDogum
            this.lblDogum.AutoSize = true;
            this.lblDogum.Font = AppTheme.FontBody;
            this.lblDogum.ForeColor = AppTheme.TextSecondary;
            this.lblDogum.Location = new System.Drawing.Point(12, 146);
            this.lblDogum.Name = "lblDogum";
            this.lblDogum.Size = new System.Drawing.Size(95, 19);
            this.lblDogum.Text = "Dogum Tarihi:";

            // dtpDogum
            this.dtpDogum.CalendarForeColor = AppTheme.TextPrimary;
            this.dtpDogum.Font = AppTheme.FontBody;
            this.dtpDogum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDogum.Location = new System.Drawing.Point(160, 146);
            this.dtpDogum.Name = "dtpDogum";
            this.dtpDogum.Size = new System.Drawing.Size(200, 25);

            // lblCinsiyet
            this.lblCinsiyet.AutoSize = true;
            this.lblCinsiyet.Font = AppTheme.FontBody;
            this.lblCinsiyet.ForeColor = AppTheme.TextSecondary;
            this.lblCinsiyet.Location = new System.Drawing.Point(12, 194);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Size = new System.Drawing.Size(60, 19);
            this.lblCinsiyet.Text = "Cinsiyet:";

            // cmbCinsiyet
            this.cmbCinsiyet.BackColor = AppTheme.BgInput;
            this.cmbCinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCinsiyet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCinsiyet.Font = AppTheme.FontBody;
            this.cmbCinsiyet.ForeColor = AppTheme.TextPrimary;
            this.cmbCinsiyet.Items.AddRange(new object[] { "Erkek", "Kadin" });
            this.cmbCinsiyet.Location = new System.Drawing.Point(160, 194);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(200, 25);

            // lblBoy
            this.lblBoy.AutoSize = true;
            this.lblBoy.Font = AppTheme.FontBody;
            this.lblBoy.ForeColor = AppTheme.TextSecondary;
            this.lblBoy.Location = new System.Drawing.Point(12, 242);
            this.lblBoy.Name = "lblBoy";
            this.lblBoy.Size = new System.Drawing.Size(68, 19);
            this.lblBoy.Text = "Boy (cm):";

            // txtBoy
            this.txtBoy.BackColor = AppTheme.BgInput;
            this.txtBoy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoy.Font = AppTheme.FontBody;
            this.txtBoy.ForeColor = AppTheme.TextPrimary;
            this.txtBoy.Location = new System.Drawing.Point(160, 242);
            this.txtBoy.Name = "txtBoy";
            this.txtBoy.Size = new System.Drawing.Size(200, 25);

            // lblKilo
            this.lblKilo.AutoSize = true;
            this.lblKilo.Font = AppTheme.FontBody;
            this.lblKilo.ForeColor = AppTheme.TextSecondary;
            this.lblKilo.Location = new System.Drawing.Point(12, 290);
            this.lblKilo.Name = "lblKilo";
            this.lblKilo.Size = new System.Drawing.Size(65, 19);
            this.lblKilo.Text = "Kilo (kg):";

            // txtKilo
            this.txtKilo.BackColor = AppTheme.BgInput;
            this.txtKilo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKilo.Font = AppTheme.FontBody;
            this.txtKilo.ForeColor = AppTheme.TextPrimary;
            this.txtKilo.Location = new System.Drawing.Point(160, 290);
            this.txtKilo.Name = "txtKilo";
            this.txtKilo.Size = new System.Drawing.Size(200, 25);

            // lblAktivite
            this.lblAktivite.AutoSize = true;
            this.lblAktivite.Font = AppTheme.FontBody;
            this.lblAktivite.ForeColor = AppTheme.TextSecondary;
            this.lblAktivite.Location = new System.Drawing.Point(12, 338);
            this.lblAktivite.Name = "lblAktivite";
            this.lblAktivite.Size = new System.Drawing.Size(60, 19);
            this.lblAktivite.Text = "Aktivite:";

            // cmbAktivite
            this.cmbAktivite.BackColor = AppTheme.BgInput;
            this.cmbAktivite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAktivite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbAktivite.Font = AppTheme.FontBody;
            this.cmbAktivite.ForeColor = AppTheme.TextPrimary;
            this.cmbAktivite.Items.AddRange(new object[] { "Sedanter", "Hafif Aktif", "Orta Aktif", "Aktif", "Cok Aktif" });
            this.cmbAktivite.Location = new System.Drawing.Point(160, 338);
            this.cmbAktivite.Name = "cmbAktivite";
            this.cmbAktivite.Size = new System.Drawing.Size(200, 25);

            // lblHedef
            this.lblHedef.AutoSize = true;
            this.lblHedef.Font = AppTheme.FontBody;
            this.lblHedef.ForeColor = AppTheme.TextSecondary;
            this.lblHedef.Location = new System.Drawing.Point(12, 386);
            this.lblHedef.Name = "lblHedef";
            this.lblHedef.Size = new System.Drawing.Size(48, 19);
            this.lblHedef.Text = "Hedef:";

            // cmbHedef
            this.cmbHedef.BackColor = AppTheme.BgInput;
            this.cmbHedef.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHedef.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbHedef.Font = AppTheme.FontBody;
            this.cmbHedef.ForeColor = AppTheme.TextPrimary;
            this.cmbHedef.Items.AddRange(new object[] { "Koruma", "Yavas", "Orta", "Orta Agresif", "Agresif" });
            this.cmbHedef.Location = new System.Drawing.Point(160, 386);
            this.cmbHedef.Name = "cmbHedef";
            this.cmbHedef.Size = new System.Drawing.Size(200, 25);

            // btnKaydet
            this.btnKaydet.BackColor = AppTheme.AccentGreen;
            this.btnKaydet.FlatAppearance.BorderSize = 0;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Font = AppTheme.FontBtnLarge;
            this.btnKaydet.ForeColor = System.Drawing.Color.White;
            this.btnKaydet.Location = new System.Drawing.Point(12, 439);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(348, 48);
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = false;

            // RegisterForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = AppTheme.BgDark;
            this.ClientSize = new System.Drawing.Size(420, 520);
            this.Controls.Add(this.card);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Yeni Kullanici Kaydi";
            this.card.ResumeLayout(false);
            this.card.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel card;
        private System.Windows.Forms.Label lblT;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label lblDogum;
        private System.Windows.Forms.DateTimePicker dtpDogum;
        private System.Windows.Forms.Label lblCinsiyet;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.Label lblBoy;
        private System.Windows.Forms.TextBox txtBoy;
        private System.Windows.Forms.Label lblKilo;
        private System.Windows.Forms.TextBox txtKilo;
        private System.Windows.Forms.Label lblAktivite;
        private System.Windows.Forms.ComboBox cmbAktivite;
        private System.Windows.Forms.Label lblHedef;
        private System.Windows.Forms.ComboBox cmbHedef;
        private System.Windows.Forms.Button btnKaydet;
    }
}
