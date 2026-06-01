-- =============================================
-- TEST 1: Tüm tabloların veri kontrolü
-- =============================================
SELECT 'AktiviteSeviyesi' AS Tablo, COUNT(*) AS KayitSayisi FROM AktiviteSeviyesi
UNION ALL
SELECT 'KiloHedefi', COUNT(*) FROM KiloHedefi
UNION ALL
SELECT 'BesinKategorileri', COUNT(*) FROM BesinKategorileri
UNION ALL
SELECT 'Ogunler', COUNT(*) FROM Ogunler
UNION ALL
SELECT 'Besinler', COUNT(*) FROM Besinler;


-- =============================================
-- TEST 2: Besinleri kategorileriyle birlikte listele (INNER JOIN)
-- =============================================
SELECT b.BesinAdi, k.KategoriAdi, b.KaloriPer100g, b.ProteinPer100g, b.KarbonhidratPer100g, b.YagPer100g
FROM Besinler b
INNER JOIN BesinKategorileri k ON b.KategoriID = k.KategoriID
ORDER BY k.KategoriAdi, b.BesinAdi;


-- =============================================
-- TEST 3: Kategori bazında besin sayısı (GROUP BY)
-- =============================================
SELECT k.KategoriAdi, COUNT(*) AS BesinSayisi
FROM Besinler b
INNER JOIN BesinKategorileri k ON b.KategoriID = k.KategoriID
GROUP BY k.KategoriAdi
ORDER BY BesinSayisi DESC;


-- =============================================
-- TEST 4: En yüksek kalorili 10 besin
-- =============================================
SELECT TOP 10 BesinAdi, KaloriPer100g
FROM Besinler
ORDER BY KaloriPer100g DESC;


-- =============================================
-- TEST 5: En yüksek proteinli 10 besin
-- =============================================
SELECT TOP 10 BesinAdi, ProteinPer100g
FROM Besinler
ORDER BY ProteinPer100g DESC;


-- =============================================
-- TEST 6: Sıfır kalorili besinler (Su, Tuz vb.)
-- =============================================
SELECT BesinAdi, KaloriPer100g
FROM Besinler
WHERE KaloriPer100g = 0;


-- =============================================
-- TEST 7: Kullanıcı oluştur ve profilini oku
-- =============================================
INSERT INTO Kullanicilar (Ad, Soyad, DogumTarihi, Cinsiyet, Boy, Kilo, AktiviteSeviyesiID, KiloHedefiID)
VALUES ('Arda', 'Test', '2005-01-15', 'E', 184.00, 99.20, 3, 4);

SELECT 
    u.Ad, u.Soyad, u.Boy, u.Kilo,
    DATEDIFF(YEAR, u.DogumTarihi, GETDATE()) AS Yas,
    a.SeviyeAdi, a.Carpan,
    h.HedefAdi, h.GunlukKaloriAcigi
FROM Kullanicilar u
INNER JOIN AktiviteSeviyesi a ON u.AktiviteSeviyesiID = a.AktiviteSeviyesiID
INNER JOIN KiloHedefi h ON u.KiloHedefiID = h.KiloHedefiID;


-- =============================================
-- TEST 8: Kilo geçmişi kaydı oluştur ve oku
-- =============================================
INSERT INTO KiloGecmisi (KullaniciID, Kilo, OlcumTarihi) VALUES (1, 103.00, '2025-03-01');
INSERT INTO KiloGecmisi (KullaniciID, Kilo, OlcumTarihi) VALUES (1, 101.50, '2025-03-15');
INSERT INTO KiloGecmisi (KullaniciID, Kilo, OlcumTarihi) VALUES (1, 100.20, '2025-04-01');
INSERT INTO KiloGecmisi (KullaniciID, Kilo, OlcumTarihi) VALUES (1, 99.20, '2025-04-15');

SELECT Kilo, OlcumTarihi,
       LAG(Kilo) OVER (ORDER BY OlcumTarihi) AS OncekiKilo,
       Kilo - LAG(Kilo) OVER (ORDER BY OlcumTarihi) AS Fark
FROM KiloGecmisi
WHERE KullaniciID = 1
ORDER BY OlcumTarihi;


-- =============================================
-- TEST 9: Günlük tüketim kaydı simülasyonu
-- =============================================
INSERT INTO GunlukTuketim (KullaniciID, BesinID, OgunID, MiktarGram, TuketimTarihi)
VALUES
(1, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Yumurta (Orta Boy)'), 1, 100, CAST(GETDATE() AS DATE)),
(1, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Beyaz Peynir (Tam Yağlı)'), 1, 30, CAST(GETDATE() AS DATE)),
(1, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Ekmek (Tam Buğday)'), 1, 50, CAST(GETDATE() AS DATE)),
(1, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Tavuk Göğsü (Çiğ)'), 2, 200, CAST(GETDATE() AS DATE)),
(1, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Beyaz Pirinç (Çiğ)'), 2, 150, CAST(GETDATE() AS DATE)),
(1, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Somon Balığı (Çiğ)'), 3, 150, CAST(GETDATE() AS DATE)),
(1, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Bulgur (Çiğ)'), 3, 100, CAST(GETDATE() AS DATE));


-- =============================================
-- TEST 10: Bugünkü tüketimi öğün öğün göster (Ana Sorgu)
-- =============================================
SELECT 
    o.OgunAdi,
    b.BesinAdi,
    gt.MiktarGram,
    ROUND((gt.MiktarGram / 100.0) * b.KaloriPer100g, 1) AS Kalori,
    ROUND((gt.MiktarGram / 100.0) * b.ProteinPer100g, 1) AS Protein,
    ROUND((gt.MiktarGram / 100.0) * b.KarbonhidratPer100g, 1) AS Karbonhidrat,
    ROUND((gt.MiktarGram / 100.0) * b.YagPer100g, 1) AS Yag
FROM GunlukTuketim gt
INNER JOIN Besinler b ON gt.BesinID = b.BesinID
INNER JOIN Ogunler o ON gt.OgunID = o.OgunID
WHERE gt.KullaniciID = 1 AND gt.TuketimTarihi = CAST(GETDATE() AS DATE)
ORDER BY o.SiraNo;


-- =============================================
-- TEST 11: Günlük toplam kalori ve makro özeti
-- =============================================
SELECT 
    ROUND(SUM((gt.MiktarGram / 100.0) * b.KaloriPer100g), 0) AS ToplamKalori,
    ROUND(SUM((gt.MiktarGram / 100.0) * b.ProteinPer100g), 1) AS ToplamProtein,
    ROUND(SUM((gt.MiktarGram / 100.0) * b.KarbonhidratPer100g), 1) AS ToplamKarbonhidrat,
    ROUND(SUM((gt.MiktarGram / 100.0) * b.YagPer100g), 1) AS ToplamYag
FROM GunlukTuketim gt
INNER JOIN Besinler b ON gt.BesinID = b.BesinID
WHERE gt.KullaniciID = 1 AND gt.TuketimTarihi = CAST(GETDATE() AS DATE);


-- =============================================
-- TEST 12: Su tüketimi kaydı ve günlük toplam
-- =============================================
INSERT INTO SuTuketim (KullaniciID, MiktarMl, TuketimTarihi) VALUES (1, 300, CAST(GETDATE() AS DATE));
INSERT INTO SuTuketim (KullaniciID, MiktarMl, TuketimTarihi) VALUES (1, 500, CAST(GETDATE() AS DATE));
INSERT INTO SuTuketim (KullaniciID, MiktarMl, TuketimTarihi) VALUES (1, 250, CAST(GETDATE() AS DATE));

SELECT 
    SUM(MiktarMl) AS ToplamSuMl,
    u.GunlukSuHedefiMl,
    SUM(MiktarMl) * 100 / u.GunlukSuHedefiMl AS YuzdeTamamlanan
FROM SuTuketim st
INNER JOIN Kullanicilar u ON st.KullaniciID = u.KullaniciID
WHERE st.KullaniciID = 1 AND st.TuketimTarihi = CAST(GETDATE() AS DATE)
GROUP BY u.GunlukSuHedefiMl;


-- =============================================
-- TEST 13: TARİF MOTORU SİMÜLASYONU (Krep Oluşturma)
-- =============================================
-- Adım 1: Krep'i bileşik besin olarak ekle (değerler hesaplanacak)
-- Malzemeler: 100g Un + 100g Yumurta + 50g Süt = 250g toplam
DECLARE @UnKal DECIMAL(7,2), @UnPro DECIMAL(6,2), @UnKar DECIMAL(6,2), @UnYag DECIMAL(6,2);
DECLARE @YumKal DECIMAL(7,2), @YumPro DECIMAL(6,2), @YumKar DECIMAL(6,2), @YumYag DECIMAL(6,2);
DECLARE @SutKal DECIMAL(7,2), @SutPro DECIMAL(6,2), @SutKar DECIMAL(6,2), @SutYag DECIMAL(6,2);

SELECT @UnKal=KaloriPer100g, @UnPro=ProteinPer100g, @UnKar=KarbonhidratPer100g, @UnYag=YagPer100g FROM Besinler WHERE BesinAdi='Beyaz Un';
SELECT @YumKal=KaloriPer100g, @YumPro=ProteinPer100g, @YumKar=KarbonhidratPer100g, @YumYag=YagPer100g FROM Besinler WHERE BesinAdi='Yumurta (Orta Boy)';
SELECT @SutKal=KaloriPer100g, @SutPro=ProteinPer100g, @SutKar=KarbonhidratPer100g, @SutYag=YagPer100g FROM Besinler WHERE BesinAdi='Tam Yağlı İnek Sütü';

DECLARE @ToplamAgirlik DECIMAL(7,1) = 250.0;
DECLARE @ToplamKal DECIMAL(7,2) = (100.0/100)*@UnKal + (100.0/100)*@YumKal + (50.0/100)*@SutKal;
DECLARE @ToplamPro DECIMAL(6,2) = (100.0/100)*@UnPro + (100.0/100)*@YumPro + (50.0/100)*@SutPro;
DECLARE @ToplamKar DECIMAL(6,2) = (100.0/100)*@UnKar + (100.0/100)*@YumKar + (50.0/100)*@SutKar;
DECLARE @ToplamYag DECIMAL(6,2) = (100.0/100)*@UnYag + (100.0/100)*@YumYag + (50.0/100)*@SutYag;

INSERT INTO Besinler (BesinAdi, KategoriID, KaloriPer100g, ProteinPer100g, KarbonhidratPer100g, YagPer100g, BilesikMi, ToplamAgirlikGram, PorsiyonSayisi, OlusturanKullaniciID, VarsayilanPorsiyonGram)
VALUES (
    'Krep (Ev Yapımı)',
    (SELECT KategoriID FROM BesinKategorileri WHERE KategoriAdi = 'Hazır/Paketli Gıda'),
    ROUND((@ToplamKal / @ToplamAgirlik) * 100, 2),
    ROUND((@ToplamPro / @ToplamAgirlik) * 100, 2),
    ROUND((@ToplamKar / @ToplamAgirlik) * 100, 2),
    ROUND((@ToplamYag / @ToplamAgirlik) * 100, 2),
    1,
    @ToplamAgirlik,
    2,
    1,
    125
);

-- Adım 2: Tarif bileşenlerini kaydet
DECLARE @KrepID INT = (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Krep (Ev Yapımı)');

INSERT INTO TarifBilesenleri (TarifBesinID, BilesenBesinID, MiktarGram) VALUES
(@KrepID, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Beyaz Un'), 100),
(@KrepID, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Yumurta (Orta Boy)'), 100),
(@KrepID, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Tam Yağlı İnek Sütü'), 50);

-- Adım 3: Tarifi ve bileşenlerini doğrula
SELECT 'Tarif Bilgisi' AS Bilgi, BesinAdi, KaloriPer100g, ProteinPer100g, KarbonhidratPer100g, YagPer100g, ToplamAgirlikGram
FROM Besinler WHERE BesinAdi = 'Krep (Ev Yapımı)';

SELECT 'Bileşenler' AS Bilgi, b.BesinAdi, tb.MiktarGram,
       ROUND((tb.MiktarGram / 100.0) * b.KaloriPer100g, 1) AS KatkiKalori
FROM TarifBilesenleri tb
INNER JOIN Besinler b ON tb.BilesenBesinID = b.BesinID
WHERE tb.TarifBesinID = @KrepID;


-- =============================================
-- TEST 14: Aktivite seviyeleri ve kilo hedefleri kontrol
-- =============================================
SELECT * FROM AktiviteSeviyesi ORDER BY Carpan;
SELECT * FROM KiloHedefi ORDER BY GunlukKaloriAcigi;
SELECT * FROM Ogunler ORDER BY SiraNo;
