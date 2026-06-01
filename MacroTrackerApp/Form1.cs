using System;
using System.Drawing;
using System.Windows.Forms;

namespace MacroTrackerApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            cmbCinsiyet.SelectedIndex = 0;
            cmbAktivite.SelectedIndex = 2;
            cmbHedef.SelectedIndex = 3;
        }

        private void BtnHesapla_Click(object sender, EventArgs e)
        {
            try
            {
                int yas = int.Parse(txtYas.Text);
                double boy = double.Parse(txtBoy.Text);
                double kilo = double.Parse(txtKilo.Text);
                char cinsiyet = cmbCinsiyet.SelectedIndex == 0 ? 'E' : 'K';

                double aktiviteCarpani = 1.20;
                switch (cmbAktivite.SelectedIndex)
                {
                    case 0: aktiviteCarpani = 1.20; break;
                    case 1: aktiviteCarpani = 1.375; break;
                    case 2: aktiviteCarpani = 1.55; break;
                    case 3: aktiviteCarpani = 1.725; break;
                    case 4: aktiviteCarpani = 1.90; break;
                }

                int kaloriAcigi = 0;
                switch (cmbHedef.SelectedIndex)
                {
                    case 0: kaloriAcigi = 0; break;
                    case 1: kaloriAcigi = -275; break;
                    case 2: kaloriAcigi = -550; break;
                    case 3: kaloriAcigi = -825; break;
                    case 4: kaloriAcigi = -1100; break;
                }

                CalculatorService calc = new CalculatorService();
                double bmr = calc.CalculateBMR(kilo, boy, yas, cinsiyet);
                double tdee = calc.CalculateTDEE(bmr, aktiviteCarpani);
                double hedefKalori = calc.CalculateTargetCalories(tdee, kaloriAcigi);
                var makrolar = calc.CalculateMacros(hedefKalori);

                lblSonuc.Text = $"✅ HESAPLAMA BAŞARILI!\n\n" +
                               $"BMR (Bazal Metabolizma):  {bmr} kcal\n" +
                               $"TDEE (Günlük Harcama):    {tdee} kcal\n" +
                               $"GÜNLÜK HEDEF KALORİ:    {hedefKalori} kcal\n\n" +
                               $"--- Önerilen Makro Dağılımı ---\n" +
                               $"Protein: {makrolar.Protein} g  |  Karb: {makrolar.Carbs} g  |  Yağ: {makrolar.Fat} g";
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Yaş, Boy ve Kilo alanlarına sadece rakam giriniz!", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblCinsiyet_Click(object sender, EventArgs e)
        {
        }
    }
}
