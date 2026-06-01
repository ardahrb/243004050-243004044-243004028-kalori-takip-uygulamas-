using System;
using System.Drawing;
using System.Windows.Forms;

namespace MacroTrackerApp
{
    public partial class MainMenu : Form
    {
        private int userID;
        private string userName;
        private double userKilo, userBoy, aktiviteCarpani;
        private int userYas, kaloriAcigi;
        private char userCinsiyet;
        private string hedefAdi;

        public MainMenu(int uid, string uname, double kilo, double boy, int yas, char cinsiyet, double carpan, int acik, string hedef)
        {
            InitializeComponent();

            userID = uid; userName = uname; userKilo = kilo; userBoy = boy;
            userYas = yas; userCinsiyet = cinsiyet; aktiviteCarpani = carpan;
            kaloriAcigi = acik; hedefAdi = hedef;

            CalculatorService calc = new CalculatorService();
            double bmr = calc.CalculateBMR(kilo, boy, yas, cinsiyet);
            double tdee = calc.CalculateTDEE(bmr, carpan);
            double hedefKalori = calc.CalculateTargetCalories(tdee, acik);

            lblTitle.Text = $"Hos Geldin, {uname.Split('(')[0].Trim()}!";
            lblInfo.Text = $"Hedef: {hedef}  |  Gunluk: {hedefKalori:F0} kcal  |  BMR: {bmr:F0}";

            btnCalc.Click += (s, e) => new Form1().ShowDialog();
            btnCounter.Click += (s, e) =>
            {
                var c = new CalculatorService();
                double b = c.CalculateBMR(userKilo, userBoy, userYas, userCinsiyet);
                double t = c.CalculateTDEE(b, aktiviteCarpani);
                double h = c.CalculateTargetCalories(t, kaloriAcigi);
                var m = c.CalculateMacros(h);
                new CalorieCounterForm(userID, h, m.Protein, m.Carbs, m.Fat).ShowDialog();
            };
            btnRecipe.Click += (s, e) => new RecipeWizardForm(userID).ShowDialog();
        }
    }
}
