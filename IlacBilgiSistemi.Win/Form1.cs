using IlacBilgiSistemi.Domain.Entities;
using System.Text.Json;

namespace IlacBilgiSistemi.Win;

public partial class Form1 : Form
{
    private List<Drug> allDrugs = new();
    private string drugsJsonPath = "";
    private string radioJsonPath = "";
    private string allergensJsonPath = "";

    public Form1()
    {
        InitializeComponent();
        LoadAllData();
    }

    private async void LoadAllData()
    {
        try
        {
            var basePath = AppDomain.CurrentDomain.BaseDirectory;
            drugsJsonPath = Path.Combine(basePath, "Seed", "drugs.json");
            radioJsonPath = Path.Combine(basePath, "Seed", "radiopharma.json");
            allergensJsonPath = Path.Combine(basePath, "Seed", "allergens.json");

            // İlaçları yükle
            if (File.Exists(drugsJsonPath))
            {
                var json = await File.ReadAllTextAsync(drugsJsonPath);
                allDrugs = JsonSerializer.Deserialize<List<Drug>>(json) ?? new List<Drug>();
                dataGridViewDrugs.DataSource = allDrugs;
                lblDrugsCount.Text = $"{allDrugs.Count} ilaç";
            }

            // Radyofarmasötik yükle
            if (File.Exists(radioJsonPath))
            {
                var json = await File.ReadAllTextAsync(radioJsonPath);
                var radios = JsonSerializer.Deserialize<List<Radiopharmaceutical>>(json) ?? new List<Radiopharmaceutical>();
                dataGridViewRadio.DataSource = radios;
                lblRadioCount.Text = $"{radios.Count} radyofarmasötik";
            }

            // Alerjenler yükle
            if (File.Exists(allergensJsonPath))
            {
                var json = await File.ReadAllTextAsync(allergensJsonPath);
                var allergens = JsonSerializer.Deserialize<List<Allergen>>(json) ?? new List<Allergen>();
                dataGridViewAllergens.DataSource = allergens;
                lblAllergensCount.Text = $"{allergens.Count} alerjen";
            }

            // İstatistikleri güncelle
            UpdateStatistics();

            // İlk sekmeyi göster
            tabControl1.SelectedTab = tabPageDrugs;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Veri yükleme hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void UpdateStatistics()
    {
        // Toplam ilaç
        lblTotalDrugs.Text = allDrugs.Count.ToString();

        // Benzersiz etken madde
        var uniqueIngredients = allDrugs.Select(d => d.EtkenMadde).Distinct().Count();
        lblUniqueIngredients.Text = uniqueIngredients.ToString();

        // Benzersiz şirket
        var uniqueCompanies = allDrugs.Select(d => d.RuhsatSahibi).Distinct().Count();
        lblUniqueCompanies.Text = uniqueCompanies.ToString();
    }

    private void btnSearch_Click(object sender, EventArgs e)
    {
        var searchTerm = txtSearch.Text.ToLower();
        
        if (string.IsNullOrWhiteSpace(searchTerm))
        {
            dataGridViewDrugs.DataSource = allDrugs;
            return;
        }

        var filtered = allDrugs.Where(d =>
            d.UrunAdi.ToLower().Contains(searchTerm) ||
            d.EtkenMadde.ToLower().Contains(searchTerm) ||
            d.Barkod.ToLower().Contains(searchTerm) ||
            d.RuhsatSahibi.ToLower().Contains(searchTerm)
        ).ToList();

        dataGridViewDrugs.DataSource = filtered;
        lblDrugsCount.Text = $"{filtered.Count} sonuç";
    }

    private void txtSearch_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            btnSearch_Click(sender, e);
        }
    }

    private void btnClearSearch_Click(object sender, EventArgs e)
    {
        txtSearch.Clear();
        dataGridViewDrugs.DataSource = allDrugs;
        lblDrugsCount.Text = $"{allDrugs.Count} ilaç";
    }
}
