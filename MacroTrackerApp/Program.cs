namespace MacroTrackerApp;

static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        DatabaseInitializer.EnsureDatabaseExists();

        var loginForm = new UserLoginForm();
        if (loginForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
        {
            Application.Run(new MainMenu(
                loginForm.SelectedUserID,
                loginForm.SelectedUserName,
                loginForm.UserKilo,
                loginForm.UserBoy,
                loginForm.UserYas,
                loginForm.UserCinsiyet,
                loginForm.AktiviteCarpani,
                loginForm.KaloriAcigi,
                loginForm.HedefAdi
            ));
        }
    }
}