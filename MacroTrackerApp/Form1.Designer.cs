namespace MacroTrackerApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            txtYas = new TextBox();
            txtBoy = new TextBox();
            txtKilo = new TextBox();
            cmbCinsiyet = new ComboBox();
            cmbAktivite = new ComboBox();
            cmbHedef = new ComboBox();
            btnHesapla = new Button();
            lblSonuc = new Label();
            lblYas = new Label();
            lblBoy = new Label();
            lblKilo = new Label();
            lblCinsiyet = new Label();
            lblAktivite = new Label();
            lblHedef = new Label();
            SuspendLayout();

            var bgDark = System.Drawing.Color.FromArgb(24, 28, 36);
            var bgCard = System.Drawing.Color.FromArgb(32, 38, 50);
            var bgInput = System.Drawing.Color.FromArgb(40, 48, 62);
            var txtColor = System.Drawing.Color.FromArgb(235, 240, 250);
            var txtSec = System.Drawing.Color.FromArgb(160, 170, 190);
            var accent = System.Drawing.Color.FromArgb(99, 179, 237);
            var bodyFont = new System.Drawing.Font("Segoe UI", 10F);
            var labelFont = new System.Drawing.Font("Segoe UI", 10F);

            txtYas.Font = bodyFont;
            txtYas.BackColor = bgInput;
            txtYas.ForeColor = txtColor;
            txtYas.BorderStyle = BorderStyle.FixedSingle;
            txtYas.Location = new System.Drawing.Point(180, 30);
            txtYas.Size = new System.Drawing.Size(260, 28);

            txtBoy.Font = bodyFont;
            txtBoy.BackColor = bgInput;
            txtBoy.ForeColor = txtColor;
            txtBoy.BorderStyle = BorderStyle.FixedSingle;
            txtBoy.Location = new System.Drawing.Point(180, 75);
            txtBoy.Size = new System.Drawing.Size(260, 28);

            txtKilo.Font = bodyFont;
            txtKilo.BackColor = bgInput;
            txtKilo.ForeColor = txtColor;
            txtKilo.BorderStyle = BorderStyle.FixedSingle;
            txtKilo.Location = new System.Drawing.Point(180, 120);
            txtKilo.Size = new System.Drawing.Size(260, 28);

            cmbCinsiyet.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCinsiyet.Font = bodyFont;
            cmbCinsiyet.BackColor = bgInput;
            cmbCinsiyet.ForeColor = txtColor;
            cmbCinsiyet.FlatStyle = FlatStyle.Flat;
            cmbCinsiyet.Items.AddRange(new object[] { "Erkek", "Kad\u0131n" });
            cmbCinsiyet.Location = new System.Drawing.Point(180, 165);
            cmbCinsiyet.Size = new System.Drawing.Size(260, 28);

            cmbAktivite.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAktivite.Font = bodyFont;
            cmbAktivite.BackColor = bgInput;
            cmbAktivite.ForeColor = txtColor;
            cmbAktivite.FlatStyle = FlatStyle.Flat;
            cmbAktivite.Items.AddRange(new object[] { "Sedanter (Masa ba\u015f\u0131)", "Hafif Aktif (1-3 g\u00fcn)", "Orta Aktif (3-5 g\u00fcn)", "Aktif (6-7 g\u00fcn)", "\u00c7ok Aktif (Profesyonel)" });
            cmbAktivite.Location = new System.Drawing.Point(180, 210);
            cmbAktivite.Size = new System.Drawing.Size(260, 28);

            cmbHedef.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbHedef.Font = bodyFont;
            cmbHedef.BackColor = bgInput;
            cmbHedef.ForeColor = txtColor;
            cmbHedef.FlatStyle = FlatStyle.Flat;
            cmbHedef.Items.AddRange(new object[] { "Koruma (0 kcal)", "Yava\u015f Verme (-275)", "Orta Verme (-550)", "Agresif Verme (-825)", "\u00c7ok Agresif (-1100)" });
            cmbHedef.Location = new System.Drawing.Point(180, 255);
            cmbHedef.Size = new System.Drawing.Size(260, 28);

            btnHesapla.BackColor = accent;
            btnHesapla.Font = new System.Drawing.Font("Segoe UI Semibold", 13F);
            btnHesapla.ForeColor = System.Drawing.Color.White;
            btnHesapla.FlatStyle = FlatStyle.Flat;
            btnHesapla.FlatAppearance.BorderSize = 0;
            btnHesapla.Location = new System.Drawing.Point(20, 310);
            btnHesapla.Size = new System.Drawing.Size(420, 55);
            btnHesapla.Text = "HESAPLA";
            btnHesapla.Cursor = Cursors.Hand;
            btnHesapla.Click += BtnHesapla_Click;

            lblSonuc.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblSonuc.ForeColor = txtColor;
            lblSonuc.BackColor = bgCard;
            lblSonuc.BorderStyle = BorderStyle.None;
            lblSonuc.Location = new System.Drawing.Point(20, 380);
            lblSonuc.Size = new System.Drawing.Size(420, 180);
            lblSonuc.Padding = new Padding(12);
            lblSonuc.Text = "De\u011ferleri girip 'HESAPLA' butonuna bas\u0131n\u0131z...";

            lblYas.AutoSize = true; lblYas.Font = labelFont; lblYas.ForeColor = txtSec;
            lblYas.Location = new System.Drawing.Point(20, 33); lblYas.Text = "Ya\u015f:";

            lblBoy.AutoSize = true; lblBoy.Font = labelFont; lblBoy.ForeColor = txtSec;
            lblBoy.Location = new System.Drawing.Point(20, 78); lblBoy.Text = "Boy (cm):";

            lblKilo.AutoSize = true; lblKilo.Font = labelFont; lblKilo.ForeColor = txtSec;
            lblKilo.Location = new System.Drawing.Point(20, 123); lblKilo.Text = "Kilo (kg):";

            lblCinsiyet.AutoSize = true; lblCinsiyet.Font = labelFont; lblCinsiyet.ForeColor = txtSec;
            lblCinsiyet.Location = new System.Drawing.Point(20, 168); lblCinsiyet.Text = "Cinsiyet:";

            lblAktivite.AutoSize = true; lblAktivite.Font = labelFont; lblAktivite.ForeColor = txtSec;
            lblAktivite.Location = new System.Drawing.Point(20, 213); lblAktivite.Text = "Aktivite:";

            lblHedef.AutoSize = true; lblHedef.Font = labelFont; lblHedef.ForeColor = txtSec;
            lblHedef.Location = new System.Drawing.Point(20, 258); lblHedef.Text = "Hedef:";

            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = bgDark;
            ForeColor = txtColor;
            ClientSize = new System.Drawing.Size(465, 580);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Controls.Add(lblSonuc);
            Controls.Add(btnHesapla);
            Controls.Add(cmbHedef); Controls.Add(lblHedef);
            Controls.Add(cmbAktivite); Controls.Add(lblAktivite);
            Controls.Add(cmbCinsiyet); Controls.Add(lblCinsiyet);
            Controls.Add(txtKilo); Controls.Add(lblKilo);
            Controls.Add(txtBoy); Controls.Add(lblBoy);
            Controls.Add(txtYas); Controls.Add(lblYas);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Makro ve Kalori Hesaplay\u0131c\u0131";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtYas;
        private System.Windows.Forms.TextBox txtBoy;
        private System.Windows.Forms.TextBox txtKilo;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.ComboBox cmbAktivite;
        private System.Windows.Forms.ComboBox cmbHedef;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Label lblYas;
        private System.Windows.Forms.Label lblBoy;
        private System.Windows.Forms.Label lblKilo;
        private System.Windows.Forms.Label lblCinsiyet;
        private System.Windows.Forms.Label lblAktivite;
        private System.Windows.Forms.Label lblHedef;
    }
}
