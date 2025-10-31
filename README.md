# İlaç Bilgi Sistemi (Drug Information System)

İlaç bilgilerini yönetmek ve aramak için geliştirilmiş Windows Forms tabanlı bir .NET 8 uygulamasıdır.

## 📋 Genel Bakış

Bu proje, ilaç verilerini yönetmek, aramak ve görüntülemek için tasarlanmış kapsamlı bir uygulamadır. Sistem, ilaçlar, radyofarmasötikler ve alerjenler hakkında detaylı bilgi sağlar ve kullanıcı dostu bir arayüz sunar.

## 🏗️ Mimari

Proje Clean Architecture prensiplerine göre katmanlı bir yapıda tasarlanmıştır:

### Katmanlar

- **IlacBilgiSistemi.Domain**: İş mantığı ve domain entities
  - `Drug`: İlaç bilgileri (Barkod, Ürün Adı, Etken Madde, ATC Kodu, Ruhsat Sahibi, Ruhsat Tarihi)
  - `Radiopharmaceutical`: Radyofarmasötik bilgileri
  - `Allergen`: Alerjen bilgileri
  - `ProspectusRef`: Prospektüs referans bilgileri
  - Repository interfaces ve servisler

- **IlacBilgiSistemi.Infrastructure**: Altyapı ve veri erişim katmanı
  - JSON dosya tabanlı veri erişimi
  - HTTP servis entegrasyonları

- **IlacBilgiSistemi.Win**: Windows Forms kullanıcı arayüzü
  - İlaç listesi görüntüleme
  - Arama ve filtreleme özellikleri
  - İstatistikler

## 🚀 Özellikler

- ✅ İlaç bilgilerini görüntüleme
- ✅ Radyofarmasötik bilgilerini görüntüleme
- ✅ Alerjen bilgilerini görüntüleme
- ✅ Gelişmiş arama ve filtreleme
- ✅ İstatistiksel veriler (toplam ilaç, benzersiz etken madde, benzersiz şirket)
- ✅ Tab bazlı arayüz
- ✅ JSON tabanlı veri yönetimi

## 🛠️ Teknolojiler

- **.NET 8**: Hedef framework
- **Windows Forms**: Kullanıcı arayüzü
- **System.Text.Json**: JSON işlemleri
- **Microsoft.Extensions.Http**: HTTP istemci yönetimi
- **C#**: Programlama dili

## 📦 Kurulum

### Gereksinimler

- .NET 8 SDK veya üzeri
- Windows işletim sistemi
- Visual Studio 2022 veya Visual Studio Code (opsiyonel)

### Adımlar

1. Projeyi klonlayın:
```bash
git clone https://github.com/sadikkartall/drugs_project_csharp.git
cd IlacBilgiSistemi
```

2. Çözümü derleyin:
```bash
dotnet build
```

3. Uygulamayı çalıştırın:
```bash
dotnet run --project IlacBilgiSistemi.Win
```

veya Visual Studio'da çözümü açıp çalıştırın.

## 📁 Proje Yapısı

```
IlacBilgiSistemi/
├── IlacBilgiSistemi.Domain/          # Domain katmanı
│   ├── Entities/                      # Domain entities
│   │   ├── Drug.cs
│   │   ├── Radiopharmaceutical.cs
│   │   ├── Allergen.cs
│   │   └── ProspectusRef.cs
│   └── Interfaces/                    # Repository interfaces
├── IlacBilgiSistemi.Infrastructure/   # Infrastructure katmanı
├── IlacBilgiSistemi.Win/              # Windows Forms UI
│   ├── Form1.cs
│   ├── Program.cs
│   └── Seed/                          # JSON veri dosyaları
│       ├── drugs.json
│       ├── radiopharma.json
│       └── allergens.json
└── IlacBilgiSistemi.sln              # Solution dosyası
```

## 🎯 Kullanım

1. Uygulamayı başlattığınızda, tüm ilaç verileri otomatik olarak yüklenir.
2. **İlaçlar** sekmesinde:
   - Tüm ilaçları görüntüleyebilirsiniz
   - Ürün adı, etken madde, barkod veya ruhsat sahibine göre arama yapabilirsiniz
3. **Radyofarmasötikler** sekmesinde radyofarmasötik ürünleri görüntüleyebilirsiniz
4. **Alerjenler** sekmesinde alerjen bilgilerini görüntüleyebilirsiniz
5. İstatistik panelinde genel bilgileri görebilirsiniz

## 📊 Veri Formatı

Veriler JSON formatında `Seed` klasöründe saklanır:

- `drugs.json`: İlaç verileri
- `radiopharma.json`: Radyofarmasötik verileri
- `allergens.json`: Alerjen verileri

## 🤝 Katkıda Bulunma

1. Bu repository'yi fork edin
2. Feature branch oluşturun (`git checkout -b feature/amazing-feature`)
3. Değişikliklerinizi commit edin (`git commit -m 'Add some amazing feature'`)
4. Branch'inizi push edin (`git push origin feature/amazing-feature`)
5. Pull Request oluşturun

## 📝 Lisans

Bu proje MIT lisansı altında lisanslanmıştır.

## 👤 Yazar

**Sadık Kartal**

- GitHub: [@sadikkartall](https://github.com/sadikkartall)

## 🙏 Teşekkürler

Bu projenin geliştirilmesinde kullanılan tüm teknolojiler ve kütüphaneler için teşekkürler.

---

⭐ Beğendiyseniz yıldız vermeyi unutmayın!

