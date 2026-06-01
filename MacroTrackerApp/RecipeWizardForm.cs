using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MacroTrackerApp
{
    public partial class RecipeWizardForm : Form
    {
        private int userID;
        private DatabaseService db = new DatabaseService();
        private Dictionary<int, string> selectedIngredients = new Dictionary<int, string>();
        private Dictionary<int, (string Name, decimal Gram)> recipeItems = new Dictionary<int, (string, decimal)>();

        public RecipeWizardForm(int uid)
        {
            userID = uid;
            InitializeComponent();

            AppTheme.StyleDataGridView(dgvIngredients);
            AppTheme.StyleDataGridView(dgvResults);
            AppTheme.StyleDataGridView(dgvCreateIngredients);

            tabControl.DrawItem += (s, e) =>
            {
                var g = e.Graphics;
                bool sel = e.Index == tabControl.SelectedIndex;
                Color bg = sel ? AppTheme.Accent : AppTheme.BgCard;
                Color fg = sel ? Color.White : AppTheme.TextSecondary;
                using (var b = new SolidBrush(bg)) g.FillRectangle(b, e.Bounds);
                using (var f = new Font("Segoe UI Semibold", 10F))
                    TextRenderer.DrawText(g, tabControl.TabPages[e.Index].Text, f, e.Bounds, fg,
                        TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            };

            txtSearchIngredient.TextChanged += (s, e) =>
            {
                dgvIngredients.DataSource = db.GetBaseIngredients(txtSearchIngredient.Text.Trim());
                FormatIngredientGrid(dgvIngredients);
            };

            btnAddIngr.Click += BtnAddIngr_Click;
            btnRemoveIngr.Click += BtnRemoveIngr_Click;
            btnFind.Click += BtnFind_Click;

            btnSearchName.Click += (s, e) =>
            {
                string kw = txtSearchRecipeName.Text.Trim();
                if (string.IsNullOrEmpty(kw)) return;
                dgvResults.DataSource = db.SearchRecipesByName(kw);
                FormatResultsGrid(dgvResults);
            };

            dgvResults.CellDoubleClick += DgvResults_CellDoubleClick;

            txtSearchCreate.TextChanged += (s, e) =>
            {
                dgvCreateIngredients.DataSource = db.GetBaseIngredients(txtSearchCreate.Text.Trim());
                FormatIngredientGrid(dgvCreateIngredients);
            };

            btnAddItem.Click += BtnAddItem_Click;
            btnRemoveItem.Click += BtnRemoveItem_Click;
            btnSave.Click += BtnSave_Click;

            this.Load += (s, e) =>
            {
                dgvIngredients.DataSource = db.GetBaseIngredients("");
                dgvCreateIngredients.DataSource = db.GetBaseIngredients("");
                FormatIngredientGrid(dgvIngredients);
                FormatIngredientGrid(dgvCreateIngredients);
            };
        }

        private void FormatIngredientGrid(DataGridView dgv)
        {
            if (dgv.Columns.Count == 0) return;
            if (dgv.Columns.Contains("BesinID")) dgv.Columns["BesinID"].Visible = false;
            if (dgv.Columns.Contains("BesinAdi")) { dgv.Columns["BesinAdi"].HeaderText = "Besin Adi"; dgv.Columns["BesinAdi"].FillWeight = 200; }
            if (dgv.Columns.Contains("KategoriAdi")) { dgv.Columns["KategoriAdi"].HeaderText = "Kategori"; dgv.Columns["KategoriAdi"].FillWeight = 100; }
            if (dgv.Columns.Contains("KaloriPer100g")) { dgv.Columns["KaloriPer100g"].HeaderText = "Kalori"; dgv.Columns["KaloriPer100g"].FillWeight = 60; }
            if (dgv.Columns.Contains("ProteinPer100g")) { dgv.Columns["ProteinPer100g"].HeaderText = "Protein"; dgv.Columns["ProteinPer100g"].FillWeight = 60; }
            if (dgv.Columns.Contains("KarbonhidratPer100g")) { dgv.Columns["KarbonhidratPer100g"].HeaderText = "Karb"; dgv.Columns["KarbonhidratPer100g"].FillWeight = 60; }
            if (dgv.Columns.Contains("YagPer100g")) { dgv.Columns["YagPer100g"].HeaderText = "Yag"; dgv.Columns["YagPer100g"].FillWeight = 60; }
        }

        private void FormatResultsGrid(DataGridView dgv)
        {
            if (dgv.Columns.Count == 0) return;
            if (dgv.Columns.Contains("BesinID")) dgv.Columns["BesinID"].Visible = false;
            if (dgv.Columns.Contains("TarifAdi")) { dgv.Columns["TarifAdi"].HeaderText = "Tarif Adi"; dgv.Columns["TarifAdi"].FillWeight = 200; }
            if (dgv.Columns.Contains("Kalori")) { dgv.Columns["Kalori"].HeaderText = "Kalori"; dgv.Columns["Kalori"].FillWeight = 65; }
            if (dgv.Columns.Contains("Protein")) { dgv.Columns["Protein"].HeaderText = "Protein"; dgv.Columns["Protein"].FillWeight = 65; }
            if (dgv.Columns.Contains("Karb")) { dgv.Columns["Karb"].HeaderText = "Karb"; dgv.Columns["Karb"].FillWeight = 65; }
            if (dgv.Columns.Contains("Yag")) { dgv.Columns["Yag"].HeaderText = "Yag"; dgv.Columns["Yag"].FillWeight = 65; }
            if (dgv.Columns.Contains("EslesenMalzeme")) { dgv.Columns["EslesenMalzeme"].HeaderText = "Eslesen"; dgv.Columns["EslesenMalzeme"].FillWeight = 65; }
            if (dgv.Columns.Contains("ToplamMalzeme")) { dgv.Columns["ToplamMalzeme"].HeaderText = "Toplam"; dgv.Columns["ToplamMalzeme"].FillWeight = 65; }
            if (dgv.Columns.Contains("MalzemeSayisi")) { dgv.Columns["MalzemeSayisi"].HeaderText = "Malzeme"; dgv.Columns["MalzemeSayisi"].FillWeight = 65; }
        }

        private void BtnAddIngr_Click(object? sender, EventArgs e)
        {
            if (dgvIngredients.SelectedRows.Count == 0) return;
            int id = Convert.ToInt32(dgvIngredients.SelectedRows[0].Cells["BesinID"].Value);
            string name = dgvIngredients.SelectedRows[0].Cells["BesinAdi"].Value?.ToString() ?? "";
            if (!selectedIngredients.ContainsKey(id))
            {
                selectedIngredients[id] = name;
                lstSelected.Items.Add(name);
            }
        }

        private void BtnRemoveIngr_Click(object? sender, EventArgs e)
        {
            if (lstSelected.SelectedIndex < 0) return;
            string name = lstSelected.SelectedItem!.ToString()!;
            var key = selectedIngredients.FirstOrDefault(x => x.Value == name).Key;
            selectedIngredients.Remove(key);
            lstSelected.Items.Remove(lstSelected.SelectedItem);
        }

        private void BtnFind_Click(object? sender, EventArgs e)
        {
            if (selectedIngredients.Count == 0) { MessageBox.Show("En az 1 malzeme secin!"); return; }
            dgvResults.DataSource = db.FindRecipesByIngredients(
                selectedIngredients.Keys.ToList(),
                selectedIngredients.Values.ToList());
            FormatResultsGrid(dgvResults);
        }

        private void DgvResults_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            int besinID = Convert.ToInt32(dgvResults.Rows[e.RowIndex].Cells["BesinID"].Value);
            ShowRecipeDetail(besinID);
        }

        private void ShowRecipeDetail(int besinID)
        {
            var detail = db.GetRecipeDetails(besinID);

            var detailForm = new Form();
            AppTheme.StyleForm(detailForm, detail.Name);
            detailForm.ClientSize = new Size(500, 480);
            detailForm.MaximizeBox = false;
            detailForm.StartPosition = FormStartPosition.CenterParent;

            var card = AppTheme.CreateCard(10, 10, 480, 460);
            detailForm.Controls.Add(card);

            var lblName = AppTheme.CreateLabel(detail.Name, 15, 10,
                new Font("Segoe UI", 16F, FontStyle.Bold), AppTheme.Accent);
            card.Controls.Add(lblName);

            string makroBilgi = $"Kalori: {detail.Kalori} kcal  |  Protein: {detail.Protein}g  |  Karb: {detail.Karb}g  |  Yag: {detail.Yag}g";
            var lblMacro = AppTheme.CreateLabel(makroBilgi, 15, 48,
                AppTheme.FontSmall, AppTheme.AccentGreen);
            card.Controls.Add(lblMacro);

            card.Controls.Add(AppTheme.CreateLabel("Malzemeler:", 15, 80,
                new Font("Segoe UI Semibold", 11F), AppTheme.AccentOrange));
            var txtIngr = new TextBox()
            {
                Location = new Point(15, 105), Size = new Size(450, 140),
                Multiline = true, ReadOnly = true, ScrollBars = ScrollBars.Vertical,
                Font = AppTheme.FontBody, BackColor = AppTheme.BgDark,
                ForeColor = AppTheme.TextPrimary, BorderStyle = BorderStyle.None,
                Text = string.IsNullOrEmpty(detail.Ingredients) ? "  Malzeme bilgisi yok" : detail.Ingredients
            };
            card.Controls.Add(txtIngr);

            card.Controls.Add(AppTheme.CreateLabel("Hazirlama Talimati:", 15, 255,
                new Font("Segoe UI Semibold", 11F), AppTheme.AccentPurple));
            var txtInst = new TextBox()
            {
                Location = new Point(15, 280), Size = new Size(450, 120),
                Multiline = true, ReadOnly = true, ScrollBars = ScrollBars.Vertical,
                Font = AppTheme.FontBody, BackColor = AppTheme.BgDark,
                ForeColor = AppTheme.TextPrimary, BorderStyle = BorderStyle.None,
                Text = string.IsNullOrEmpty(detail.Instructions) ? "Hazirlama talimati henuz eklenmemis." : detail.Instructions
            };
            card.Controls.Add(txtInst);

            var btnClose = AppTheme.CreateButton("Kapat", 170, 415, 140, 35, AppTheme.Accent);
            btnClose.Click += (s, ev) => detailForm.Close();
            card.Controls.Add(btnClose);

            detailForm.ShowDialog(this);
        }

        private void BtnAddItem_Click(object? sender, EventArgs e)
        {
            if (dgvCreateIngredients.SelectedRows.Count == 0) return;
            try
            {
                int id = Convert.ToInt32(dgvCreateIngredients.SelectedRows[0].Cells["BesinID"].Value);
                string name = dgvCreateIngredients.SelectedRows[0].Cells["BesinAdi"].Value?.ToString() ?? "";
                decimal gram = decimal.Parse(txtItemGram.Text);
                recipeItems[id] = (name, gram);
                RefreshRecipeList();
            }
            catch { MessageBox.Show("Gram alanina gecerli bir sayi girin!"); }
        }

        private void BtnRemoveItem_Click(object? sender, EventArgs e)
        {
            if (lstRecipeItems.SelectedIndex < 0) return;
            int idx = lstRecipeItems.SelectedIndex;
            int id = recipeItems.Keys.ElementAt(idx);
            recipeItems.Remove(id);
            RefreshRecipeList();
        }

        private void RefreshRecipeList()
        {
            lstRecipeItems.Items.Clear();
            foreach (var item in recipeItems)
                lstRecipeItems.Items.Add($"{item.Value.Name} - {item.Value.Gram}g");
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            try
            {
                string name = txtRecipeName.Text.Trim();
                if (string.IsNullOrEmpty(name)) { MessageBox.Show("Tarif adi bos olamaz!"); return; }
                if (recipeItems.Count == 0) { MessageBox.Show("En az 1 malzeme ekleyin!"); return; }

                decimal kalori = decimal.Parse(txtKalori.Text);
                decimal protein = decimal.Parse(txtProtein.Text);
                decimal karb = decimal.Parse(txtKarb.Text);
                decimal yag = decimal.Parse(txtYag.Text);
                decimal toplamGram = decimal.Parse(txtToplamGram.Text);

                int recipeID = db.CreateRecipe(name, 9, kalori, protein, karb, yag, toplamGram, userID);

                foreach (var item in recipeItems)
                    db.AddRecipeIngredient(recipeID, item.Key, item.Value.Gram);

                string talimat = txtTalimat.Text.Trim();
                if (!string.IsNullOrEmpty(talimat))
                    db.UpdateRecipeInstructions(recipeID, talimat);

                MessageBox.Show($"'{name}' tarifi basariyla kaydedildi!\nArtik Kalori Sayacinda kullanabilirsiniz.",
                    "Basarili", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtRecipeName.Clear(); txtKalori.Clear(); txtProtein.Clear();
                txtKarb.Clear(); txtYag.Clear(); txtToplamGram.Clear(); txtTalimat.Clear();
                recipeItems.Clear(); lstRecipeItems.Items.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
