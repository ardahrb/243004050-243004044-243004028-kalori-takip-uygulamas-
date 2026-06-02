using System;
using System.Windows.Forms;

namespace MacroTrackerApp;

static class Program
{
    [STAThread]
    static void Main()
    {
        try
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
        catch (Exception ex)
        {
            MessageBox.Show(
                "Uygulama çalışırken kritik bir hata ile karşılaştı:\n\n" + ex.Message + 
                "\n\nDetaylı Bilgi:\n" + ex.StackTrace,
                "Kritik Uygulama Hatası",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }
    }
}