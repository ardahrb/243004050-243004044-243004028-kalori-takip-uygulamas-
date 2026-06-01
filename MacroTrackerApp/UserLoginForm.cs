using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace MacroTrackerApp
{
    public partial class UserLoginForm : Form
    {
        private DatabaseService db = new DatabaseService();

        public int SelectedUserID { get; private set; }
        public string SelectedUserName { get; private set; } = "";
        public double UserKilo { get; private set; }
        public double UserBoy { get; private set; }
        public int UserYas { get; private set; }
        public char UserCinsiyet { get; private set; }
        public double AktiviteCarpani { get; private set; }
        public int KaloriAcigi { get; private set; }
        public string HedefAdi { get; private set; } = "";

        public UserLoginForm()
        {
            InitializeComponent();
            btnSelect.Click += BtnSelect_Click;
            btnNewUser.Click += BtnNewUser_Click;
            LoadUsers();
        }

        private void LoadUsers()
        {
            cmbUsers.Items.Clear();
            DataTable users = db.GetAllUsers();
            foreach (DataRow row in users.Rows)
            {
                cmbUsers.Items.Add(new UserItem
                {
                    ID = Convert.ToInt32(row["KullaniciID"]),
                    Display = $"{row["Ad"]} {row["Soyad"]} ({row["Kilo"]}kg)",
                    Kilo = Convert.ToDouble(row["Kilo"]),
                    Boy = Convert.ToDouble(row["Boy"]),
                    Yas = Convert.ToInt32(row["Yas"]),
                    Cinsiyet = row["Cinsiyet"].ToString()![0],
                    Carpan = Convert.ToDouble(row["Carpan"]),
                    KaloriAcigi = Convert.ToInt32(row["GunlukKaloriAcigi"]),
                    HedefAdi = row["HedefAdi"].ToString()!
                });
            }
            if (cmbUsers.Items.Count > 0) cmbUsers.SelectedIndex = 0;
        }

        private void BtnSelect_Click(object? sender, EventArgs e)
        {
            if (cmbUsers.SelectedItem == null) { MessageBox.Show("Lütfen bir profil seçin!"); return; }
            var user = (UserItem)cmbUsers.SelectedItem;
            SelectedUserID = user.ID;
            SelectedUserName = user.Display;
            UserKilo = user.Kilo;
            UserBoy = user.Boy;
            UserYas = user.Yas;
            UserCinsiyet = user.Cinsiyet;
            AktiviteCarpani = user.Carpan;
            KaloriAcigi = user.KaloriAcigi;
            HedefAdi = user.HedefAdi;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BtnNewUser_Click(object? sender, EventArgs e)
        {
            var regForm = new RegisterForm();
            if (regForm.ShowDialog() == DialogResult.OK)
            {
                LoadUsers();
                cmbUsers.SelectedIndex = cmbUsers.Items.Count - 1;
            }
        }

        private class UserItem
        {
            public int ID { get; set; }
            public string Display { get; set; } = "";
            public double Kilo { get; set; }
            public double Boy { get; set; }
            public int Yas { get; set; }
            public char Cinsiyet { get; set; }
            public double Carpan { get; set; }
            public int KaloriAcigi { get; set; }
            public string HedefAdi { get; set; } = "";
            public override string ToString() => Display;
        }
    }
}
