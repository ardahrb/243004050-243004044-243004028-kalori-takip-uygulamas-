# Makro & Kalori Takip Sistemi (Macro Tracker App)

Bu proje, C# Windows Forms ve SQL Server kullanılarak geliştirilmiş modern bir makro ve kalori takip uygulamasıdır. Kullanıcıların günlük kalori ihtiyaçlarını hesaplamalarına, tükettikleri besinleri kaydetmelerine ve malzeme bazlı gelişmiş bir tarif sihirbazıyla yemek tarifleri bulup oluşturmalarına olanak tanır.

## Sistem Gereksinimleri

- **İşletim Sistemi:** Windows (x64)
- **Veritabanı Sunucusu:** SQL Server LocalDB (Visual Studio yüklü sistemlerde otomatik olarak kuruludur)
- **Çalışma Zamanı:** .NET 10.0 (veya üzeri) Runtime

## Uygulamayı Çalıştırma (Hızlı Başlangıç)

Uygulamanın çalıştırılması tamamen **otomatikleştirilmiştir**. Herhangi bir manuel veritabanı kurulumu veya script çalıştırma işlemi yapmanıza gerek yoktur.

1. **`kalori takip uygulaması.zip`** dosyasını bilgisayarınıza indirin ve bir klasöre çıkartın.
2. Klasör içerisindeki **`MacroTrackerApp.exe`** dosyasına çift tıklayarak uygulamayı başlatın.
3. Uygulama açılışta yerel bilgisayarınızdaki SQL Server LocalDB sunucusunu kontrol edecek ve `projedb` veritabanı kurulu değilse, klasördeki `projedb.sql` dosyasını kullanarak veritabanını, tabloları ve örnek verileri **otomatik olarak oluşturacaktır**.

## Proje Özellikleri

- **Modern & Premium Tasarım:** Karanlık mod (dark theme), özel ilerleme çubukları (MacroProgressBar) ve şık geçiş animasyonları.
- **Kullanıcı Kayıt & BMR/TDEE Hesaplama:** Mifflin-St Jeor denklemi kullanılarak kişiye özel kalori ve makro besin hedefleri hesaplama.
- **Günlük Kalori Sayacı:** Kahvaltı, öğle, akşam yemeği ve atıştırmalık öğünlerine göre besin ekleme ve silme. Canlı ilerleme çubukları ile kalan kalori ve makro takibi.
- **Tarif Sihirbazı:** 
  - *Malzeme ile Tarif Bul:* Seçilen malzemelere göre veritabanındaki en uygun yemek tariflerini akıllı eşleştirme algoritmasıyla listeleme.
  - *Yeni Tarif Oluştur:* Kullanıcıların kendi malzemelerini seçerek, makro değerlerini girip veritabanına yeni tarifler kazandırması.
  - *Detaylı Hazırlanış:* Listelenen tariflere çift tıklayarak gerekli malzemeleri ve hazırlanış talimatlarını görüntüleme.
