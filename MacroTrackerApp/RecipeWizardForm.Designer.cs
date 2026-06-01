namespace MacroTrackerApp
{
    partial class RecipeWizardForm
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabFinder = new System.Windows.Forms.TabPage();
            this.lblSearchIngredient = new System.Windows.Forms.Label();
            this.txtSearchIngredient = new System.Windows.Forms.TextBox();
            this.btnAddIngr = new System.Windows.Forms.Button();
            this.dgvIngredients = new System.Windows.Forms.DataGridView();
            this.lblSelected = new System.Windows.Forms.Label();
            this.lstSelected = new System.Windows.Forms.ListBox();
            this.btnRemoveIngr = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.lblSearchRecipeName = new System.Windows.Forms.Label();
            this.txtSearchRecipeName = new System.Windows.Forms.TextBox();
            this.btnSearchName = new System.Windows.Forms.Button();
            this.lblDoubleClick = new System.Windows.Forms.Label();
            this.lblResults = new System.Windows.Forms.Label();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.tabCreator = new System.Windows.Forms.TabPage();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.lblRecipeName = new System.Windows.Forms.Label();
            this.txtRecipeName = new System.Windows.Forms.TextBox();
            this.lblToplamGram = new System.Windows.Forms.Label();
            this.txtToplamGram = new System.Windows.Forms.TextBox();
            this.lblBasina = new System.Windows.Forms.Label();
            this.lblKalori = new System.Windows.Forms.Label();
            this.txtKalori = new System.Windows.Forms.TextBox();
            this.lblProtein = new System.Windows.Forms.Label();
            this.txtProtein = new System.Windows.Forms.TextBox();
            this.lblKarb = new System.Windows.Forms.Label();
            this.txtKarb = new System.Windows.Forms.TextBox();
            this.lblYag = new System.Windows.Forms.Label();
            this.txtYag = new System.Windows.Forms.TextBox();
            this.lblTalimat = new System.Windows.Forms.Label();
            this.txtTalimat = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblSearchCreate = new System.Windows.Forms.Label();
            this.txtSearchCreate = new System.Windows.Forms.TextBox();
            this.lblItemGram = new System.Windows.Forms.Label();
            this.txtItemGram = new System.Windows.Forms.TextBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.dgvCreateIngredients = new System.Windows.Forms.DataGridView();
            this.lblRecipeItems = new System.Windows.Forms.Label();
            this.lstRecipeItems = new System.Windows.Forms.ListBox();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabFinder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.tabCreator.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreateIngredients)).BeginInit();
            this.SuspendLayout();

            // tabControl
            this.tabControl.Controls.Add(this.tabFinder);
            this.tabControl.Controls.Add(this.tabCreator);
            this.tabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabControl.ItemSize = new System.Drawing.Size(220, 34);
            this.tabControl.Location = new System.Drawing.Point(5, 5);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(950, 690);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;

            // tabFinder
            this.tabFinder.BackColor = AppTheme.BgDark;
            this.tabFinder.Controls.Add(this.lblSearchIngredient);
            this.tabFinder.Controls.Add(this.txtSearchIngredient);
            this.tabFinder.Controls.Add(this.btnAddIngr);
            this.tabFinder.Controls.Add(this.dgvIngredients);
            this.tabFinder.Controls.Add(this.lblSelected);
            this.tabFinder.Controls.Add(this.lstSelected);
            this.tabFinder.Controls.Add(this.btnRemoveIngr);
            this.tabFinder.Controls.Add(this.btnFind);
            this.tabFinder.Controls.Add(this.lblSearchRecipeName);
            this.tabFinder.Controls.Add(this.txtSearchRecipeName);
            this.tabFinder.Controls.Add(this.btnSearchName);
            this.tabFinder.Controls.Add(this.lblDoubleClick);
            this.tabFinder.Controls.Add(this.lblResults);
            this.tabFinder.Controls.Add(this.dgvResults);
            this.tabFinder.Location = new System.Drawing.Point(4, 38);
            this.tabFinder.Name = "tabFinder";
            this.tabFinder.Size = new System.Drawing.Size(942, 648);
            this.tabFinder.Text = "Malzemeyle Tarif Bul";

            // lblSearchIngredient
            this.lblSearchIngredient.AutoSize = true;
            this.lblSearchIngredient.Font = AppTheme.FontBody;
            this.lblSearchIngredient.ForeColor = AppTheme.TextSecondary;
            this.lblSearchIngredient.Location = new System.Drawing.Point(10, 15);
            this.lblSearchIngredient.Name = "lblSearchIngredient";
            this.lblSearchIngredient.Size = new System.Drawing.Size(92, 19);
            this.lblSearchIngredient.Text = "Malzeme Ara:";

            // txtSearchIngredient
            this.txtSearchIngredient.BackColor = AppTheme.BgInput;
            this.txtSearchIngredient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchIngredient.Font = AppTheme.FontBody;
            this.txtSearchIngredient.ForeColor = AppTheme.TextPrimary;
            this.txtSearchIngredient.Location = new System.Drawing.Point(115, 12);
            this.txtSearchIngredient.Name = "txtSearchIngredient";
            this.txtSearchIngredient.Size = new System.Drawing.Size(200, 25);

            // btnAddIngr
            this.btnAddIngr.BackColor = AppTheme.Accent;
            this.btnAddIngr.FlatAppearance.BorderSize = 0;
            this.btnAddIngr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddIngr.Font = AppTheme.FontBody;
            this.btnAddIngr.ForeColor = System.Drawing.Color.White;
            this.btnAddIngr.Location = new System.Drawing.Point(325, 10);
            this.btnAddIngr.Name = "btnAddIngr";
            this.btnAddIngr.Size = new System.Drawing.Size(90, 30);
            this.btnAddIngr.Text = "Ekle >>";
            this.btnAddIngr.UseVisualStyleBackColor = false;

            // dgvIngredients
            this.dgvIngredients.Location = new System.Drawing.Point(10, 50);
            this.dgvIngredients.Name = "dgvIngredients";
            this.dgvIngredients.Size = new System.Drawing.Size(410, 230);

            // lblSelected
            this.lblSelected.AutoSize = true;
            this.lblSelected.Font = AppTheme.FontBody;
            this.lblSelected.ForeColor = AppTheme.Accent;
            this.lblSelected.Location = new System.Drawing.Point(435, 15);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Size = new System.Drawing.Size(127, 19);
            this.lblSelected.Text = "Secilen Malzemeler:";

            // lstSelected
            this.lstSelected.BackColor = AppTheme.BgCard;
            this.lstSelected.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstSelected.Font = AppTheme.FontBody;
            this.lstSelected.ForeColor = AppTheme.TextPrimary;
            this.lstSelected.Location = new System.Drawing.Point(435, 50);
            this.lstSelected.Name = "lstSelected";
            this.lstSelected.Size = new System.Drawing.Size(245, 190);

            // btnRemoveIngr
            this.btnRemoveIngr.BackColor = AppTheme.AccentRed;
            this.btnRemoveIngr.FlatAppearance.BorderSize = 0;
            this.btnRemoveIngr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveIngr.Font = AppTheme.FontBody;
            this.btnRemoveIngr.ForeColor = System.Drawing.Color.White;
            this.btnRemoveIngr.Location = new System.Drawing.Point(435, 248);
            this.btnRemoveIngr.Name = "btnRemoveIngr";
            this.btnRemoveIngr.Size = new System.Drawing.Size(100, 32);
            this.btnRemoveIngr.Text = "Kaldir";
            this.btnRemoveIngr.UseVisualStyleBackColor = false;

            // btnFind
            this.btnFind.BackColor = AppTheme.AccentGreen;
            this.btnFind.FlatAppearance.BorderSize = 0;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnFind.ForeColor = System.Drawing.Color.White;
            this.btnFind.Location = new System.Drawing.Point(565, 248);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(115, 32);
            this.btnFind.Text = "TARIF BUL";
            this.btnFind.UseVisualStyleBackColor = false;

            // lblSearchRecipeName
            this.lblSearchRecipeName.AutoSize = true;
            this.lblSearchRecipeName.Font = AppTheme.FontSmall;
            this.lblSearchRecipeName.ForeColor = AppTheme.TextSecondary;
            this.lblSearchRecipeName.Location = new System.Drawing.Point(695, 15);
            this.lblSearchRecipeName.Name = "lblSearchRecipeName";
            this.lblSearchRecipeName.Size = new System.Drawing.Size(147, 15);
            this.lblSearchRecipeName.Text = "veya Tarif Adina Gore Ara:";

            // txtSearchRecipeName
            this.txtSearchRecipeName.BackColor = AppTheme.BgInput;
            this.txtSearchRecipeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchRecipeName.Font = AppTheme.FontBody;
            this.txtSearchRecipeName.ForeColor = AppTheme.TextPrimary;
            this.txtSearchRecipeName.Location = new System.Drawing.Point(695, 40);
            this.txtSearchRecipeName.Name = "txtSearchRecipeName";
            this.txtSearchRecipeName.Size = new System.Drawing.Size(230, 25);

            // btnSearchName
            this.btnSearchName.BackColor = AppTheme.AccentPurple;
            this.btnSearchName.FlatAppearance.BorderSize = 0;
            this.btnSearchName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchName.Font = AppTheme.FontBody;
            this.btnSearchName.ForeColor = System.Drawing.Color.White;
            this.btnSearchName.Location = new System.Drawing.Point(695, 75);
            this.btnSearchName.Name = "btnSearchName";
            this.btnSearchName.Size = new System.Drawing.Size(230, 30);
            this.btnSearchName.Text = "Tarif Ara";
            this.btnSearchName.UseVisualStyleBackColor = false;

            // lblDoubleClick
            this.lblDoubleClick.AutoSize = true;
            this.lblDoubleClick.Font = AppTheme.FontSmall;
            this.lblDoubleClick.ForeColor = AppTheme.TextSecondary;
            this.lblDoubleClick.Location = new System.Drawing.Point(695, 115);
            this.lblDoubleClick.Name = "lblDoubleClick";
            this.lblDoubleClick.Size = new System.Drawing.Size(240, 15);
            this.lblDoubleClick.Text = "Tariflere cift tiklayarak detaylari gorebilirsiniz";

            // lblResults
            this.lblResults.AutoSize = true;
            this.lblResults.Font = AppTheme.FontSubtitle;
            this.lblResults.ForeColor = AppTheme.AccentGreen;
            this.lblResults.Location = new System.Drawing.Point(10, 295);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(103, 19);
            this.lblResults.Text = "Eslesen Tarifler:";

            // dgvResults
            this.dgvResults.Location = new System.Drawing.Point(10, 322);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.Size = new System.Drawing.Size(920, 320);

            // tabCreator
            this.tabCreator.BackColor = AppTheme.BgDark;
            this.tabCreator.Controls.Add(this.pnlInfo);
            this.tabCreator.Controls.Add(this.lblSearchCreate);
            this.tabCreator.Controls.Add(this.txtSearchCreate);
            this.tabCreator.Controls.Add(this.lblItemGram);
            this.tabCreator.Controls.Add(this.txtItemGram);
            this.tabCreator.Controls.Add(this.btnAddItem);
            this.tabCreator.Controls.Add(this.dgvCreateIngredients);
            this.tabCreator.Controls.Add(this.lblRecipeItems);
            this.tabCreator.Controls.Add(this.lstRecipeItems);
            this.tabCreator.Controls.Add(this.btnRemoveItem);
            this.tabCreator.Location = new System.Drawing.Point(4, 38);
            this.tabCreator.Name = "tabCreator";
            this.tabCreator.Size = new System.Drawing.Size(942, 648);
            this.tabCreator.Text = "Yeni Tarif Olustur";

            // pnlInfo
            this.pnlInfo.BackColor = AppTheme.BgCard;
            this.pnlInfo.Controls.Add(this.lblRecipeName);
            this.pnlInfo.Controls.Add(this.txtRecipeName);
            this.pnlInfo.Controls.Add(this.lblToplamGram);
            this.pnlInfo.Controls.Add(this.txtToplamGram);
            this.pnlInfo.Controls.Add(this.lblBasina);
            this.pnlInfo.Controls.Add(this.lblKalori);
            this.pnlInfo.Controls.Add(this.txtKalori);
            this.pnlInfo.Controls.Add(this.lblProtein);
            this.pnlInfo.Controls.Add(this.txtProtein);
            this.pnlInfo.Controls.Add(this.lblKarb);
            this.pnlInfo.Controls.Add(this.txtKarb);
            this.pnlInfo.Controls.Add(this.lblYag);
            this.pnlInfo.Controls.Add(this.txtYag);
            this.pnlInfo.Controls.Add(this.lblTalimat);
            this.pnlInfo.Controls.Add(this.txtTalimat);
            this.pnlInfo.Controls.Add(this.btnSave);
            this.pnlInfo.Location = new System.Drawing.Point(10, 10);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(920, 130);

            // lblRecipeName
            this.lblRecipeName.AutoSize = true;
            this.lblRecipeName.Font = AppTheme.FontBody;
            this.lblRecipeName.ForeColor = AppTheme.TextSecondary;
            this.lblRecipeName.Location = new System.Drawing.Point(12, 10);
            this.lblRecipeName.Name = "lblRecipeName";
            this.lblRecipeName.Size = new System.Drawing.Size(65, 19);
            this.lblRecipeName.Text = "Tarif Adi:";

            // txtRecipeName
            this.txtRecipeName.BackColor = AppTheme.BgInput;
            this.txtRecipeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRecipeName.Font = AppTheme.FontBody;
            this.txtRecipeName.ForeColor = AppTheme.TextPrimary;
            this.txtRecipeName.Location = new System.Drawing.Point(95, 7);
            this.txtRecipeName.Name = "txtRecipeName";
            this.txtRecipeName.Size = new System.Drawing.Size(200, 25);

            // lblToplamGram
            this.lblToplamGram.AutoSize = true;
            this.lblToplamGram.Font = AppTheme.FontBody;
            this.lblToplamGram.ForeColor = AppTheme.TextSecondary;
            this.lblToplamGram.Location = new System.Drawing.Point(310, 10);
            this.lblToplamGram.Name = "lblToplamGram";
            this.lblToplamGram.Size = new System.Drawing.Size(81, 19);
            this.lblToplamGram.Text = "Toplam (g):";

            // txtToplamGram
            this.txtToplamGram.BackColor = AppTheme.BgInput;
            this.txtToplamGram.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtToplamGram.Font = AppTheme.FontBody;
            this.txtToplamGram.ForeColor = AppTheme.TextPrimary;
            this.txtToplamGram.Location = new System.Drawing.Point(400, 7);
            this.txtToplamGram.Name = "txtToplamGram";
            this.txtToplamGram.Size = new System.Drawing.Size(70, 25);

            // lblBasina
            this.lblBasina.AutoSize = true;
            this.lblBasina.Font = AppTheme.FontSmall;
            this.lblBasina.ForeColor = AppTheme.TextSecondary;
            this.lblBasina.Location = new System.Drawing.Point(12, 42);
            this.lblBasina.Name = "lblBasina";
            this.lblBasina.Size = new System.Drawing.Size(78, 15);
            this.lblBasina.Text = "100g Basina:";

            // lblKalori
            this.lblKalori.AutoSize = true;
            this.lblKalori.Font = AppTheme.FontSmall;
            this.lblKalori.ForeColor = AppTheme.Accent;
            this.lblKalori.Location = new System.Drawing.Point(100, 42);
            this.lblKalori.Name = "lblKalori";
            this.lblKalori.Size = new System.Drawing.Size(40, 15);
            this.lblKalori.Text = "Kalori:";

            // txtKalori
            this.txtKalori.BackColor = AppTheme.BgInput;
            this.txtKalori.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKalori.Font = AppTheme.FontBody;
            this.txtKalori.ForeColor = AppTheme.TextPrimary;
            this.txtKalori.Location = new System.Drawing.Point(148, 39);
            this.txtKalori.Name = "txtKalori";
            this.txtKalori.Size = new System.Drawing.Size(60, 25);

            // lblProtein
            this.lblProtein.AutoSize = true;
            this.lblProtein.Font = AppTheme.FontSmall;
            this.lblProtein.ForeColor = AppTheme.AccentGreen;
            this.lblProtein.Location = new System.Drawing.Point(220, 42);
            this.lblProtein.Name = "lblProtein";
            this.lblProtein.Size = new System.Drawing.Size(48, 15);
            this.lblProtein.Text = "Protein:";

            // txtProtein
            this.txtProtein.BackColor = AppTheme.BgInput;
            this.txtProtein.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProtein.Font = AppTheme.FontBody;
            this.txtProtein.ForeColor = AppTheme.TextPrimary;
            this.txtProtein.Location = new System.Drawing.Point(278, 39);
            this.txtProtein.Name = "txtProtein";
            this.txtProtein.Size = new System.Drawing.Size(55, 25);

            // lblKarb
            this.lblKarb.AutoSize = true;
            this.lblKarb.Font = AppTheme.FontSmall;
            this.lblKarb.ForeColor = AppTheme.AccentOrange;
            this.lblKarb.Location = new System.Drawing.Point(345, 42);
            this.lblKarb.Name = "lblKarb";
            this.lblKarb.Size = new System.Drawing.Size(34, 15);
            this.lblKarb.Text = "Karb:";

            // txtKarb
            this.txtKarb.BackColor = AppTheme.BgInput;
            this.txtKarb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKarb.Font = AppTheme.FontBody;
            this.txtKarb.ForeColor = AppTheme.TextPrimary;
            this.txtKarb.Location = new System.Drawing.Point(385, 39);
            this.txtKarb.Name = "txtKarb";
            this.txtKarb.Size = new System.Drawing.Size(55, 25);

            // lblYag
            this.lblYag.AutoSize = true;
            this.lblYag.Font = AppTheme.FontSmall;
            this.lblYag.ForeColor = AppTheme.AccentRed;
            this.lblYag.Location = new System.Drawing.Point(452, 42);
            this.lblYag.Name = "lblYag";
            this.lblYag.Size = new System.Drawing.Size(28, 15);
            this.lblYag.Text = "Yag:";

            // txtYag
            this.txtYag.BackColor = AppTheme.BgInput;
            this.txtYag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtYag.Font = AppTheme.FontBody;
            this.txtYag.ForeColor = AppTheme.TextPrimary;
            this.txtYag.Location = new System.Drawing.Point(482, 39);
            this.txtYag.Name = "txtYag";
            this.txtYag.Size = new System.Drawing.Size(55, 25);

            // lblTalimat
            this.lblTalimat.AutoSize = true;
            this.lblTalimat.Font = AppTheme.FontSmall;
            this.lblTalimat.ForeColor = AppTheme.AccentPurple;
            this.lblTalimat.Location = new System.Drawing.Point(12, 75);
            this.lblTalimat.Name = "lblTalimat";
            this.lblTalimat.Size = new System.Drawing.Size(49, 15);
            this.lblTalimat.Text = "Talimat:";

            // txtTalimat
            this.txtTalimat.BackColor = AppTheme.BgInput;
            this.txtTalimat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTalimat.Font = AppTheme.FontBody;
            this.txtTalimat.ForeColor = AppTheme.TextPrimary;
            this.txtTalimat.Location = new System.Drawing.Point(70, 72);
            this.txtTalimat.Name = "txtTalimat";
            this.txtTalimat.Size = new System.Drawing.Size(400, 25);

            // btnSave
            this.btnSave.BackColor = AppTheme.AccentGreen;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 13F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(600, 20);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(290, 95);
            this.btnSave.Text = "TARIFI KAYDET";
            this.btnSave.UseVisualStyleBackColor = false;

            // lblSearchCreate
            this.lblSearchCreate.AutoSize = true;
            this.lblSearchCreate.Font = AppTheme.FontBody;
            this.lblSearchCreate.ForeColor = AppTheme.TextSecondary;
            this.lblSearchCreate.Location = new System.Drawing.Point(10, 152);
            this.lblSearchCreate.Name = "lblSearchCreate";
            this.lblSearchCreate.Size = new System.Drawing.Size(92, 19);
            this.lblSearchCreate.Text = "Malzeme Ara:";

            // txtSearchCreate
            this.txtSearchCreate.BackColor = AppTheme.BgInput;
            this.txtSearchCreate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchCreate.Font = AppTheme.FontBody;
            this.txtSearchCreate.ForeColor = AppTheme.TextPrimary;
            this.txtSearchCreate.Location = new System.Drawing.Point(115, 149);
            this.txtSearchCreate.Name = "txtSearchCreate";
            this.txtSearchCreate.Size = new System.Drawing.Size(200, 25);

            // lblItemGram
            this.lblItemGram.AutoSize = true;
            this.lblItemGram.Font = AppTheme.FontSmall;
            this.lblItemGram.ForeColor = AppTheme.TextSecondary;
            this.lblItemGram.Location = new System.Drawing.Point(328, 152);
            this.lblItemGram.Name = "lblItemGram";
            this.lblItemGram.Size = new System.Drawing.Size(38, 15);
            this.lblItemGram.Text = "Gram:";

            // txtItemGram
            this.txtItemGram.BackColor = AppTheme.BgInput;
            this.txtItemGram.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemGram.Font = AppTheme.FontBody;
            this.txtItemGram.ForeColor = AppTheme.TextPrimary;
            this.txtItemGram.Location = new System.Drawing.Point(372, 149);
            this.txtItemGram.Name = "txtItemGram";
            this.txtItemGram.Size = new System.Drawing.Size(60, 25);
            this.txtItemGram.Text = "100";

            // btnAddItem
            this.btnAddItem.BackColor = AppTheme.Accent;
            this.btnAddItem.FlatAppearance.BorderSize = 0;
            this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItem.Font = AppTheme.FontBody;
            this.btnAddItem.ForeColor = System.Drawing.Color.White;
            this.btnAddItem.Location = new System.Drawing.Point(445, 147);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(130, 30);
            this.btnAddItem.Text = "Malzeme Ekle";
            this.btnAddItem.UseVisualStyleBackColor = false;

            // dgvCreateIngredients
            this.dgvCreateIngredients.Location = new System.Drawing.Point(10, 185);
            this.dgvCreateIngredients.Name = "dgvCreateIngredients";
            this.dgvCreateIngredients.Size = new System.Drawing.Size(575, 460);

            // lblRecipeItems
            this.lblRecipeItems.AutoSize = true;
            this.lblRecipeItems.Font = AppTheme.FontBody;
            this.lblRecipeItems.ForeColor = AppTheme.AccentPurple;
            this.lblRecipeItems.Location = new System.Drawing.Point(600, 152);
            this.lblRecipeItems.Name = "lblRecipeItems";
            this.lblRecipeItems.Size = new System.Drawing.Size(135, 19);
            this.lblRecipeItems.Text = "Eklenen Malzemeler:";

            // lstRecipeItems
            this.lstRecipeItems.BackColor = AppTheme.BgCard;
            this.lstRecipeItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstRecipeItems.Font = AppTheme.FontBody;
            this.lstRecipeItems.ForeColor = AppTheme.TextPrimary;
            this.lstRecipeItems.Location = new System.Drawing.Point(600, 185);
            this.lstRecipeItems.Name = "lstRecipeItems";
            this.lstRecipeItems.Size = new System.Drawing.Size(325, 415);

            // btnRemoveItem
            this.btnRemoveItem.BackColor = AppTheme.AccentRed;
            this.btnRemoveItem.FlatAppearance.BorderSize = 0;
            this.btnRemoveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveItem.Font = AppTheme.FontBody;
            this.btnRemoveItem.ForeColor = System.Drawing.Color.White;
            this.btnRemoveItem.Location = new System.Drawing.Point(600, 608);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(160, 32);
            this.btnRemoveItem.Text = "Malzemeyi Kaldir";
            this.btnRemoveItem.UseVisualStyleBackColor = false;

            // RecipeWizardForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = AppTheme.BgDark;
            this.ClientSize = new System.Drawing.Size(960, 700);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RecipeWizardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tarif Sihirbazi";
            this.tabControl.ResumeLayout(false);
            this.tabFinder.ResumeLayout(false);
            this.tabFinder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.tabCreator.ResumeLayout(false);
            this.tabCreator.PerformLayout();
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreateIngredients)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabFinder;
        private System.Windows.Forms.Label lblSearchIngredient;
        private System.Windows.Forms.TextBox txtSearchIngredient;
        private System.Windows.Forms.Button btnAddIngr;
        private System.Windows.Forms.DataGridView dgvIngredients;
        private System.Windows.Forms.Label lblSelected;
        private System.Windows.Forms.ListBox lstSelected;
        private System.Windows.Forms.Button btnRemoveIngr;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label lblSearchRecipeName;
        private System.Windows.Forms.TextBox txtSearchRecipeName;
        private System.Windows.Forms.Button btnSearchName;
        private System.Windows.Forms.Label lblDoubleClick;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.TabPage tabCreator;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Label lblRecipeName;
        private System.Windows.Forms.TextBox txtRecipeName;
        private System.Windows.Forms.Label lblToplamGram;
        private System.Windows.Forms.TextBox txtToplamGram;
        private System.Windows.Forms.Label lblBasina;
        private System.Windows.Forms.Label lblKalori;
        private System.Windows.Forms.TextBox txtKalori;
        private System.Windows.Forms.Label lblProtein;
        private System.Windows.Forms.TextBox txtProtein;
        private System.Windows.Forms.Label lblKarb;
        private System.Windows.Forms.TextBox txtKarb;
        private System.Windows.Forms.Label lblYag;
        private System.Windows.Forms.TextBox txtYag;
        private System.Windows.Forms.Label lblTalimat;
        private System.Windows.Forms.TextBox txtTalimat;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblSearchCreate;
        private System.Windows.Forms.TextBox txtSearchCreate;
        private System.Windows.Forms.Label lblItemGram;
        private System.Windows.Forms.TextBox txtItemGram;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.DataGridView dgvCreateIngredients;
        private System.Windows.Forms.Label lblRecipeItems;
        private System.Windows.Forms.ListBox lstRecipeItems;
        private System.Windows.Forms.Button btnRemoveItem;
    }
}
