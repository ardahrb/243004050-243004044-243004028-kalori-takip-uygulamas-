using System;
using System.Drawing;
using System.Windows.Forms;

namespace MacroTrackerApp
{
    public partial class RegisterForm : Form
    {
        private DatabaseService db = new DatabaseService();

        public RegisterForm()
        {
            InitializeComponent();
            cmbCinsiyet.SelectedIndex = 0;
            cmbAktivite.SelectedIndex = 2;
            cmbHedef.SelectedIndex = 3;
            btnKaydet.Click += BtnKaydet_Click;
        }

        private void BtnKaydet_Click(object? sender, EventArgs e)
        {
            try
            {
                string ad = txtAd.Text.Trim();
                string soyad = txtSoyad.Text.Trim();
                if (string.IsNullOrEmpty(ad) || string.IsNullOrEmpty(soyad)) { MessageBox.Show("Ad ve Soyad bos birakilamaz!"); return; }

                decimal boy = decimal.Parse(txtBoy.Text);
                decimal kilo = decimal.Parse(txtKilo.Text);
                char cinsiyet = cmbCinsiyet.SelectedIndex == 0 ? 'E' : 'K';
                int aktiviteID = cmbAktivite.SelectedIndex + 1;
                int hedefID = cmbHedef.SelectedIndex + 1;

                db.CreateUser(ad, soyad, dtpDogum.Value, cinsiyet, boy, kilo, aktiviteID, hedefID);
                MessageBox.Show("Kayit basarili!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Lutfen tum alanlari dogru doldurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
