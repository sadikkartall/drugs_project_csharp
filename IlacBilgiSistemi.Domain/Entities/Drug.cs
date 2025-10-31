namespace IlacBilgiSistemi.Domain.Entities;

public class Drug
{
    public string Barkod { get; set; } = string.Empty;
    public string UrunAdi { get; set; } = string.Empty;
    public string EtkenMadde { get; set; } = string.Empty;
    public string AtcKodu { get; set; } = string.Empty;
    public string RuhsatSahibi { get; set; } = string.Empty;
    public DateTime? RuhsatTarihi { get; set; }
}

