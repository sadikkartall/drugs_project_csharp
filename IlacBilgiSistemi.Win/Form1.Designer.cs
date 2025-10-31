namespace IlacBilgiSistemi.Win;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;
    
    private TabControl tabControl1;
    private TabPage tabPageDrugs;
    private TabPage tabPageRadio;
    private TabPage tabPageAllergens;
    private TabPage tabPageStats;
    
    private DataGridView dataGridViewDrugs;
    private DataGridView dataGridViewRadio;
    private DataGridView dataGridViewAllergens;
    
    private TextBox txtSearch;
    private Button btnSearch;
    private Button btnClearSearch;
    
    private Label lblDrugsCount;
    private Label lblRadioCount;
    private Label lblAllergensCount;
    
    // İstatistikler
    private Label lblTotalDrugs;
    private Label lblUniqueIngredients;
    private Label lblUniqueCompanies;
    
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
        this.tabControl1 = new TabControl();
        this.tabPageDrugs = new TabPage();
        this.tabPageRadio = new TabPage();
        this.tabPageAllergens = new TabPage();
        this.tabPageStats = new TabPage();
        
        this.txtSearch = new TextBox();
        this.btnSearch = new Button();
        this.btnClearSearch = new Button();
        this.dataGridViewDrugs = new DataGridView();
        this.dataGridViewRadio = new DataGridView();
        this.dataGridViewAllergens = new DataGridView();
        
        this.lblDrugsCount = new Label();
        this.lblRadioCount = new Label();
        this.lblAllergensCount = new Label();
        this.lblTotalDrugs = new Label();
        this.lblUniqueIngredients = new Label();
        this.lblUniqueCompanies = new Label();
        
        this.tabControl1.SuspendLayout();
        this.tabPageDrugs.SuspendLayout();
        this.tabPageRadio.SuspendLayout();
        this.tabPageAllergens.SuspendLayout();
        this.tabPageStats.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)this.dataGridViewDrugs).BeginInit();
        ((System.ComponentModel.ISupportInitialize)this.dataGridViewRadio).BeginInit();
        ((System.ComponentModel.ISupportInitialize)this.dataGridViewAllergens).BeginInit();
        this.SuspendLayout();
        
        // 
        // txtSearch
        // 
        this.txtSearch.Anchor = ((AnchorStyles)(((AnchorStyles.Top | AnchorStyles.Left) | AnchorStyles.Right)));
        this.txtSearch.Font = new Font("Segoe UI", 10F);
        this.txtSearch.Location = new Point(12, 15);
        this.txtSearch.Size = new Size(800, 27);
        this.txtSearch.Text = "";
        this.txtSearch.KeyDown += new KeyEventHandler(this.txtSearch_KeyDown);
        
        // 
        // btnSearch
        // 
        this.btnSearch.Anchor = ((AnchorStyles)((AnchorStyles.Top | AnchorStyles.Right)));
        this.btnSearch.Font = new Font("Segoe UI", 10F);
        this.btnSearch.Location = new Point(822, 14);
        this.btnSearch.Size = new Size(85, 30);
        this.btnSearch.Text = "🔍 Ara";
        this.btnSearch.UseVisualStyleBackColor = true;
        this.btnSearch.Click += new EventHandler(this.btnSearch_Click);
        
        // 
        // btnClearSearch
        // 
        this.btnClearSearch.Anchor = ((AnchorStyles)((AnchorStyles.Top | AnchorStyles.Right)));
        this.btnClearSearch.Font = new Font("Segoe UI", 9F);
        this.btnClearSearch.Location = new Point(913, 14);
        this.btnClearSearch.Size = new Size(75, 30);
        this.btnClearSearch.Text = "Temizle";
        this.btnClearSearch.UseVisualStyleBackColor = true;
        this.btnClearSearch.Click += new EventHandler(this.btnClearSearch_Click);
        
        // 
        // lblDrugsCount
        // 
        this.lblDrugsCount.Anchor = ((AnchorStyles)((AnchorStyles.Top | AnchorStyles.Right)));
        this.lblDrugsCount.AutoSize = true;
        this.lblDrugsCount.Font = new Font("Segoe UI", 10F);
        this.lblDrugsCount.ForeColor = Color.DarkGray;
        this.lblDrugsCount.Location = new Point(1010, 21);
        this.lblDrugsCount.Text = "Yükleniyor...";
        
        // 
        // dataGridViewDrugs
        // 
        this.dataGridViewDrugs.AllowUserToAddRows = false;
        this.dataGridViewDrugs.AllowUserToDeleteRows = false;
        this.dataGridViewDrugs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        this.dataGridViewDrugs.BackgroundColor = SystemColors.Control;
        this.dataGridViewDrugs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dataGridViewDrugs.Dock = DockStyle.Fill;
        this.dataGridViewDrugs.Location = new Point(3, 3);
        this.dataGridViewDrugs.ReadOnly = true;
        this.dataGridViewDrugs.RowTemplate.Height = 25;
        this.dataGridViewDrugs.Size = new Size(1186, 554);
        
        // 
        // dataGridViewRadio
        // 
        this.dataGridViewRadio.AllowUserToAddRows = false;
        this.dataGridViewRadio.AllowUserToDeleteRows = false;
        this.dataGridViewRadio.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        this.dataGridViewRadio.BackgroundColor = SystemColors.Control;
        this.dataGridViewRadio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dataGridViewRadio.Dock = DockStyle.Fill;
        this.dataGridViewRadio.Location = new Point(3, 3);
        this.dataGridViewRadio.ReadOnly = true;
        
        // 
        // dataGridViewAllergens
        // 
        this.dataGridViewAllergens.AllowUserToAddRows = false;
        this.dataGridViewAllergens.AllowUserToDeleteRows = false;
        this.dataGridViewAllergens.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        this.dataGridViewAllergens.BackgroundColor = SystemColors.Control;
        this.dataGridViewAllergens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dataGridViewAllergens.Dock = DockStyle.Fill;
        this.dataGridViewAllergens.Location = new Point(3, 3);
        this.dataGridViewAllergens.ReadOnly = true;
        
        // 
        // tabPageDrugs
        // 
        this.tabPageDrugs.Controls.Add(this.dataGridViewDrugs);
        this.tabPageDrugs.Location = new Point(4, 24);
        this.tabPageDrugs.Padding = new Padding(3);
        this.tabPageDrugs.Size = new Size(1192, 560);
        this.tabPageDrugs.Text = "💊 İlaçlar";
        this.tabPageDrugs.UseVisualStyleBackColor = true;
        
        // 
        // tabPageRadio
        // 
        this.tabPageRadio.Controls.Add(this.dataGridViewRadio);
        this.tabPageRadio.Location = new Point(4, 24);
        this.tabPageRadio.Padding = new Padding(3);
        this.tabPageRadio.Size = new Size(1192, 560);
        this.tabPageRadio.Text = "⚛️ Radyofarmasötik";
        this.tabPageRadio.UseVisualStyleBackColor = true;
        
        // 
        // tabPageAllergens
        // 
        this.tabPageAllergens.Controls.Add(this.dataGridViewAllergens);
        this.tabPageAllergens.Location = new Point(4, 24);
        this.tabPageAllergens.Padding = new Padding(3);
        this.tabPageAllergens.Size = new Size(1192, 560);
        this.tabPageAllergens.Text = "⚠️ Alerjenler";
        this.tabPageAllergens.UseVisualStyleBackColor = true;
        
        // 
        // tabPageStats
        // 
        this.tabPageStats.BackColor = Color.AliceBlue;
        this.tabPageStats.Controls.Add(this.lblTotalDrugs);
        this.tabPageStats.Controls.Add(this.lblUniqueIngredients);
        this.tabPageStats.Controls.Add(this.lblUniqueCompanies);
        this.tabPageStats.Location = new Point(4, 24);
        this.tabPageStats.Size = new Size(1192, 560);
        this.tabPageStats.Text = "📊 İstatistikler";
        
        Label labelStats1 = new Label();
        labelStats1.Text = "TOPLAM İLAÇ SAYISI";
        labelStats1.Location = new Point(50, 80);
        labelStats1.Size = new Size(300, 30);
        labelStats1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        labelStats1.ForeColor = Color.DarkBlue;
        
        this.lblTotalDrugs.Text = "5";
        this.lblTotalDrugs.Location = new Point(50, 120);
        this.lblTotalDrugs.Size = new Size(300, 80);
        this.lblTotalDrugs.Font = new Font("Segoe UI", 48F, FontStyle.Bold);
        this.lblTotalDrugs.ForeColor = Color.Blue;
        this.lblTotalDrugs.TextAlign = ContentAlignment.TopLeft;
        
        Label labelStats2 = new Label();
        labelStats2.Text = "BENZERSİZ ETKEN MADDE SAYISI";
        labelStats2.Location = new Point(450, 80);
        labelStats2.Size = new Size(300, 30);
        labelStats2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        labelStats2.ForeColor = Color.DarkGreen;
        
        this.lblUniqueIngredients.Text = "4";
        this.lblUniqueIngredients.Location = new Point(450, 120);
        this.lblUniqueIngredients.Size = new Size(300, 80);
        this.lblUniqueIngredients.Font = new Font("Segoe UI", 48F, FontStyle.Bold);
        this.lblUniqueIngredients.ForeColor = Color.Green;
        this.lblUniqueIngredients.TextAlign = ContentAlignment.TopLeft;
        
        Label labelStats3 = new Label();
        labelStats3.Text = "BENZERSİZ ŞİRKET SAYISI";
        labelStats3.Location = new Point(850, 80);
        labelStats3.Size = new Size(300, 30);
        labelStats3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        labelStats3.ForeColor = Color.DarkMagenta;
        
        this.lblUniqueCompanies.Text = "5";
        this.lblUniqueCompanies.Location = new Point(850, 120);
        this.lblUniqueCompanies.Size = new Size(300, 80);
        this.lblUniqueCompanies.Font = new Font("Segoe UI", 48F, FontStyle.Bold);
        this.lblUniqueCompanies.ForeColor = Color.Purple;
        this.lblUniqueCompanies.TextAlign = ContentAlignment.TopLeft;
        
        this.tabPageStats.Controls.AddRange(new Control[] { labelStats1, labelStats2, labelStats3 });
        
        // 
        // tabControl1
        // 
        this.tabControl1.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom) | AnchorStyles.Left) | AnchorStyles.Right)));
        this.tabControl1.Controls.Add(this.tabPageDrugs);
        this.tabControl1.Controls.Add(this.tabPageRadio);
        this.tabControl1.Controls.Add(this.tabPageAllergens);
        this.tabControl1.Controls.Add(this.tabPageStats);
        this.tabControl1.Font = new Font("Segoe UI", 10F);
        this.tabControl1.Location = new Point(12, 55);
        this.tabControl1.Size = new Size(1176, 595);
        
        // 
        // Form1
        // 
        this.ClientSize = new Size(1200, 660);
        this.Controls.Add(this.tabControl1);
        this.Controls.Add(this.lblDrugsCount);
        this.Controls.Add(this.btnClearSearch);
        this.Controls.Add(this.btnSearch);
        this.Controls.Add(this.txtSearch);
        this.MinimumSize = new Size(800, 500);
        this.Text = "İlaç Bilgi Sistemi - Masaüstü Uygulaması";
        this.WindowState = FormWindowState.Maximized;
        
        this.tabControl1.ResumeLayout(false);
        this.tabPageDrugs.ResumeLayout(false);
        this.tabPageRadio.ResumeLayout(false);
        this.tabPageAllergens.ResumeLayout(false);
        this.tabPageStats.ResumeLayout(true);
        ((System.ComponentModel.ISupportInitialize)this.dataGridViewDrugs).EndInit();
        ((System.ComponentModel.ISupportInitialize)this.dataGridViewRadio).EndInit();
        ((System.ComponentModel.ISupportInitialize)this.dataGridViewAllergens).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }
}
