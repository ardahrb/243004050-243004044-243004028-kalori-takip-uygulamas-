using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace MacroTrackerApp
{
    public partial class CalorieCounterForm : Form
    {
        private int userID;
        private double hedefKalori, hedefProtein, hedefCarbs, hedefFat;
        private DatabaseService db = new DatabaseService();

        public CalorieCounterForm(int uid, double hedef, double protein, double carbs, double fat)
        {
            userID = uid;
            hedefKalori = hedef;
            hedefProtein = protein;
            hedefCarbs = carbs;
            hedefFat = fat;

            InitializeComponent();
            
            AppTheme.StyleDataGridView(dgvFoods);
            AppTheme.StyleDataGridView(dgvDaily);
            dgvDaily.DefaultCellStyle.SelectionBackColor = Color.FromArgb(100, 40, 40);

            barKalori.Maximum = hedefKalori;
            barProtein.Maximum = hedefProtein;
            barCarbs.Maximum = hedefCarbs;
            barFat.Maximum = hedefFat;

            cmbKategori.SelectedIndexChanged += (s, e) => SearchFoods();
            txtSearch.TextChanged += (s, e) => SearchFoods();
            btnAdd.Click += BtnAdd_Click;
            btnDelete.Click += BtnDelete_Click;

            LoadCategories();
            LoadDailyData();
        }

        private void LoadCategories()
        {
            cmbKategori.Items.Clear();
            cmbKategori.Items.Add("Tumu");
            DataTable cats = db.GetCategories();
            foreach (DataRow row in cats.Rows)
                cmbKategori.Items.Add(row["KategoriAdi"].ToString());
            cmbKategori.SelectedIndex = 0;
        }

        private void FormatFoodsGrid()
        {
            if (dgvFoods.Columns.Count == 0) return;
            if (dgvFoods.Columns.Contains("BesinID")) dgvFoods.Columns["BesinID"].Visible = false;
            if (dgvFoods.Columns.Contains("BesinAdi")) { dgvFoods.Columns["BesinAdi"].HeaderText = "Besin Adi"; dgvFoods.Columns["BesinAdi"].FillWeight = 180; }
            if (dgvFoods.Columns.Contains("KategoriAdi")) { dgvFoods.Columns["KategoriAdi"].HeaderText = "Kategori"; dgvFoods.Columns["KategoriAdi"].FillWeight = 110; }
            if (dgvFoods.Columns.Contains("KaloriPer100g")) { dgvFoods.Columns["KaloriPer100g"].HeaderText = "Kalori (100g)"; dgvFoods.Columns["KaloriPer100g"].FillWeight = 85; }
            if (dgvFoods.Columns.Contains("ProteinPer100g")) { dgvFoods.Columns["ProteinPer100g"].HeaderText = "Protein"; dgvFoods.Columns["ProteinPer100g"].FillWeight = 70; }
            if (dgvFoods.Columns.Contains("KarbonhidratPer100g")) { dgvFoods.Columns["KarbonhidratPer100g"].HeaderText = "Karb"; dgvFoods.Columns["KarbonhidratPer100g"].FillWeight = 70; }
            if (dgvFoods.Columns.Contains("YagPer100g")) { dgvFoods.Columns["YagPer100g"].HeaderText = "Yag"; dgvFoods.Columns["YagPer100g"].FillWeight = 70; }
            if (dgvFoods.Columns.Contains("VarsayilanPorsiyonGram")) { dgvFoods.Columns["VarsayilanPorsiyonGram"].HeaderText = "Porsiyon (g)"; dgvFoods.Columns["VarsayilanPorsiyonGram"].FillWeight = 85; }
        }

        private void FormatDailyGrid()
        {
            if (dgvDaily.Columns.Count == 0) return;
            if (dgvDaily.Columns.Contains("TuketimID")) dgvDaily.Columns["TuketimID"].Visible = false;
            if (dgvDaily.Columns.Contains("OgunAdi")) { dgvDaily.Columns["OgunAdi"].HeaderText = "Ogun"; dgvDaily.Columns["OgunAdi"].FillWeight = 100; }
            if (dgvDaily.Columns.Contains("BesinAdi")) { dgvDaily.Columns["BesinAdi"].HeaderText = "Tuketilen Besin"; dgvDaily.Columns["BesinAdi"].FillWeight = 220; }
            if (dgvDaily.Columns.Contains("MiktarGram")) { dgvDaily.Columns["MiktarGram"].HeaderText = "Miktar (g)"; dgvDaily.Columns["MiktarGram"].FillWeight = 85; }
            if (dgvDaily.Columns.Contains("Kalori")) { dgvDaily.Columns["Kalori"].HeaderText = "Kalori (kcal)"; dgvDaily.Columns["Kalori"].FillWeight = 85; }
            if (dgvDaily.Columns.Contains("Protein")) { dgvDaily.Columns["Protein"].HeaderText = "Protein (g)"; dgvDaily.Columns["Protein"].FillWeight = 80; }
            if (dgvDaily.Columns.Contains("Karbonhidrat")) { dgvDaily.Columns["Karbonhidrat"].HeaderText = "Karb (g)"; dgvDaily.Columns["Karbonhidrat"].FillWeight = 80; }
            if (dgvDaily.Columns.Contains("Yag")) { dgvDaily.Columns["Yag"].HeaderText = "Yag (g)"; dgvDaily.Columns["Yag"].FillWeight = 80; }
        }

        private void SearchFoods()
        {
            string keyword = txtSearch.Text.Trim();
            if (cmbKategori.SelectedIndex <= 0)
                dgvFoods.DataSource = db.SearchFoods(string.IsNullOrEmpty(keyword) ? "" : keyword);
            else
                dgvFoods.DataSource = db.GetFoodsByCategory(cmbKategori.SelectedItem!.ToString()!);
            FormatFoodsGrid();
        }

        private void BtnAdd_Click(object? sender, EventArgs e)
        {
            if (dgvFoods.SelectedRows.Count == 0) { MessageBox.Show("Lutfen listeden bir besin secin!"); return; }
            try
            {
                int besinID = Convert.ToInt32(dgvFoods.SelectedRows[0].Cells["BesinID"].Value);
                int ogunID = cmbOgun.SelectedIndex + 1;
                decimal miktar = decimal.Parse(txtMiktar.Text);
                db.AddConsumption(userID, besinID, ogunID, miktar, DateTime.Today);
                LoadDailyData();
            }
            catch (Exception) { MessageBox.Show("Lutfen gram alanina gecerli bir sayi girin!"); }
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            if (dgvDaily.SelectedRows.Count == 0) { MessageBox.Show("Silmek icin bir kayit secin!"); return; }
            int tuketimID = Convert.ToInt32(dgvDaily.SelectedRows[0].Cells["TuketimID"].Value);
            db.DeleteConsumption(tuketimID);
            LoadDailyData();
        }

        private void LoadDailyData()
        {
            dgvDaily.DataSource = db.GetDailyConsumption(userID, DateTime.Today);
            FormatDailyGrid();
            DataTable summary = db.GetDailySummary(userID, DateTime.Today);
            if (summary.Rows.Count > 0)
            {
                double topKal = Convert.ToDouble(summary.Rows[0]["ToplamKalori"]);
                double topPro = Convert.ToDouble(summary.Rows[0]["ToplamProtein"]);
                double topKar = Convert.ToDouble(summary.Rows[0]["ToplamKarbonhidrat"]);
                double topYag = Convert.ToDouble(summary.Rows[0]["ToplamYag"]);
                double kalan = hedefKalori - topKal;

                barKalori.Value = topKal;
                barKalori.DisplayLabel = $"{topKal:F0} / {hedefKalori:F0} kcal  |  Kalan: {kalan:F0}";
                barKalori.BarColor = kalan >= 0 ? AppTheme.Accent : AppTheme.AccentRed;

                barProtein.Value = topPro;
                barProtein.DisplayLabel = $"{topPro:F0} / {hedefProtein:F0}g";

                barCarbs.Value = topKar;
                barCarbs.DisplayLabel = $"{topKar:F0} / {hedefCarbs:F0}g";

                barFat.Value = topYag;
                barFat.DisplayLabel = $"{topYag:F0} / {hedefFat:F0}g";
            }
        }
    }
}
