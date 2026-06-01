-- =============================================
-- 10: TARİF BİLEŞENLERİ (Unicode Uyumlu)
-- Mevcut besinlerle eşleşen tariflerin bileşenleri
-- =============================================

-- Mercimek Çorbası
INSERT INTO TarifBilesenleri (TarifBesinID, BilesenBesinID, MiktarGram)
SELECT t.BesinID, b.BesinID, v.Miktar
FROM (VALUES
  (N'Kırmızı Mercimek (Çiğ)', 200), (N'Kuru Soğan', 100), (N'Havuç', 80),
  (N'Patates', 100), (N'Domates Salçası', 30), (N'Zeytinyağı', 20),
  (N'Tuz', 8), (N'Karabiber', 3)
) AS v(BesinAdi, Miktar)
CROSS JOIN Besinler t
INNER JOIN Besinler b ON b.BesinAdi = v.BesinAdi AND b.BilesikMi = 0
WHERE t.BesinAdi = N'Mercimek Çorbası' AND t.BilesikMi = 1;

-- Menemen
INSERT INTO TarifBilesenleri (TarifBesinID, BilesenBesinID, MiktarGram)
SELECT t.BesinID, b.BesinID, v.Miktar
FROM (VALUES
  (N'Domates', 200), (N'Yeşil Biber', 100), (N'Yumurta (Orta Boy)', 150),
  (N'Zeytinyağı', 20), (N'Tuz', 5), (N'Karabiber', 3)
) AS v(BesinAdi, Miktar)
CROSS JOIN Besinler t
INNER JOIN Besinler b ON b.BesinAdi = v.BesinAdi AND b.BilesikMi = 0
WHERE t.BesinAdi = N'Menemen' AND t.BilesikMi = 1;

-- Karnıyarık
INSERT INTO TarifBilesenleri (TarifBesinID, BilesenBesinID, MiktarGram)
SELECT t.BesinID, b.BesinID, v.Miktar
FROM (VALUES
  (N'Patlıcan', 400), (N'Dana Kıyma (%10 Yağlı)', 200), (N'Kuru Soğan', 100),
  (N'Domates', 150), (N'Yeşil Biber', 50), (N'Domates Salçası', 15),
  (N'Zeytinyağı', 30), (N'Tuz', 8), (N'Karabiber', 3)
) AS v(BesinAdi, Miktar)
CROSS JOIN Besinler t
INNER JOIN Besinler b ON b.BesinAdi = v.BesinAdi AND b.BilesikMi = 0
WHERE t.BesinAdi = N'Karnıyarık' AND t.BilesikMi = 1;

-- İmam Bayıldı
INSERT INTO TarifBilesenleri (TarifBesinID, BilesenBesinID, MiktarGram)
SELECT t.BesinID, b.BesinID, v.Miktar
FROM (VALUES
  (N'Patlıcan', 400), (N'Kuru Soğan', 150), (N'Domates', 150),
  (N'Yeşil Biber', 50), (N'Sarımsak', 10), (N'Zeytinyağı', 50),
  (N'Tuz', 8), (N'Karabiber', 3)
) AS v(BesinAdi, Miktar)
CROSS JOIN Besinler t
INNER JOIN Besinler b ON b.BesinAdi = v.BesinAdi AND b.BilesikMi = 0
WHERE t.BesinAdi = N'İmam Bayıldı' AND t.BilesikMi = 1;

-- Kuru Fasulye (Yemek)
INSERT INTO TarifBilesenleri (TarifBesinID, BilesenBesinID, MiktarGram)
SELECT t.BesinID, b.BesinID, v.Miktar
FROM (VALUES
  (N'Kuru Fasulye (Çiğ)', 300), (N'Kuru Soğan', 100), (N'Domates Salçası', 30),
  (N'Biber Salçası', 15), (N'Zeytinyağı', 20), (N'Tuz', 10), (N'Karabiber', 3)
) AS v(BesinAdi, Miktar)
CROSS JOIN Besinler t
INNER JOIN Besinler b ON b.BesinAdi = v.BesinAdi AND b.BilesikMi = 0
WHERE t.BesinAdi = N'Kuru Fasulye (Yemek)' AND t.BilesikMi = 1;

-- Etli Nohut
INSERT INTO TarifBilesenleri (TarifBesinID, BilesenBesinID, MiktarGram)
SELECT t.BesinID, b.BesinID, v.Miktar
FROM (VALUES
  (N'Nohut (Çiğ)', 300), (N'Dana Kuşbaşı', 200), (N'Kuru Soğan', 100),
  (N'Domates Salçası', 30), (N'Tereyağı', 20), (N'Tuz', 10), (N'Karabiber', 3)
) AS v(BesinAdi, Miktar)
CROSS JOIN Besinler t
INNER JOIN Besinler b ON b.BesinAdi = v.BesinAdi AND b.BilesikMi = 0
WHERE t.BesinAdi = N'Etli Nohut' AND t.BilesikMi = 1;

-- Köfte (Izgara)
INSERT INTO TarifBilesenleri (TarifBesinID, BilesenBesinID, MiktarGram)
SELECT t.BesinID, b.BesinID, v.Miktar
FROM (VALUES
  (N'Dana Kıyma (%10 Yağlı)', 300), (N'Kuru Soğan', 80), (N'Beyaz Un', 30),
  (N'Galeta Unu', 20), (N'Yumurta (Orta Boy)', 50), (N'Tuz', 8),
  (N'Karabiber', 3), (N'Kimyon', 3)
) AS v(BesinAdi, Miktar)
CROSS JOIN Besinler t
INNER JOIN Besinler b ON b.BesinAdi = v.BesinAdi AND b.BilesikMi = 0
WHERE t.BesinAdi = N'Köfte (Izgara)' AND t.BilesikMi = 1;

-- Cacık
INSERT INTO TarifBilesenleri (TarifBesinID, BilesenBesinID, MiktarGram)
SELECT t.BesinID, b.BesinID, v.Miktar
FROM (VALUES
  (N'Yoğurt (Tam Yağlı)', 300), (N'Salatalık', 150), (N'Sarımsak', 5),
  (N'Zeytinyağı', 10), (N'Nane (Kuru)', 3), (N'Tuz', 5), (N'Su', 100)
) AS v(BesinAdi, Miktar)
CROSS JOIN Besinler t
INNER JOIN Besinler b ON b.BesinAdi = v.BesinAdi AND b.BilesikMi = 0
WHERE t.BesinAdi = N'Cacık' AND t.BilesikMi = 1;

-- Kısır
INSERT INTO TarifBilesenleri (TarifBesinID, BilesenBesinID, MiktarGram)
SELECT t.BesinID, b.BesinID, v.Miktar
FROM (VALUES
  (N'Bulgur (Çiğ)', 200), (N'Domates', 100), (N'Salatalık', 80),
  (N'Kuru Soğan', 50), (N'Yeşil Biber', 30), (N'Domates Salçası', 30),
  (N'Zeytinyağı', 30), (N'Limon Suyu', 30), (N'Maydanoz', 20),
  (N'Tuz', 5), (N'Pul Biber', 5)
) AS v(BesinAdi, Miktar)
CROSS JOIN Besinler t
INNER JOIN Besinler b ON b.BesinAdi = v.BesinAdi AND b.BilesikMi = 0
WHERE t.BesinAdi = N'Kısır' AND t.BilesikMi = 1;

-- Patlıcan Musakka
INSERT INTO TarifBilesenleri (TarifBesinID, BilesenBesinID, MiktarGram)
SELECT t.BesinID, b.BesinID, v.Miktar
FROM (VALUES
  (N'Patlıcan', 300), (N'Dana Kıyma (%10 Yağlı)', 200), (N'Kuru Soğan', 100),
  (N'Domates', 150), (N'Yeşil Biber', 50), (N'Domates Salçası', 20),
  (N'Zeytinyağı', 25), (N'Tuz', 8), (N'Karabiber', 3)
) AS v(BesinAdi, Miktar)
CROSS JOIN Besinler t
INNER JOIN Besinler b ON b.BesinAdi = v.BesinAdi AND b.BilesikMi = 0
WHERE t.BesinAdi = N'Patlıcan Musakka' AND t.BilesikMi = 1;

-- Taze Fasulye Yemeği
INSERT INTO TarifBilesenleri (TarifBesinID, BilesenBesinID, MiktarGram)
SELECT t.BesinID, b.BesinID, v.Miktar
FROM (VALUES
  (N'Taze Fasulye', 400), (N'Kuru Soğan', 100), (N'Domates', 150),
  (N'Zeytinyağı', 30), (N'Domates Salçası', 15), (N'Tuz', 8), (N'Karabiber', 3)
) AS v(BesinAdi, Miktar)
CROSS JOIN Besinler t
INNER JOIN Besinler b ON b.BesinAdi = v.BesinAdi AND b.BilesikMi = 0
WHERE t.BesinAdi = N'Taze Fasulye Yemeği' AND t.BilesikMi = 1;

-- Bezelye Yemeği
INSERT INTO TarifBilesenleri (TarifBesinID, BilesenBesinID, MiktarGram)
SELECT t.BesinID, b.BesinID, v.Miktar
FROM (VALUES
  (N'Bezelye (Taze)', 300), (N'Kuru Soğan', 80), (N'Havuç', 80),
  (N'Patates', 100), (N'Domates Salçası', 15), (N'Zeytinyağı', 20),
  (N'Tuz', 8), (N'Karabiber', 3)
) AS v(BesinAdi, Miktar)
CROSS JOIN Besinler t
INNER JOIN Besinler b ON b.BesinAdi = v.BesinAdi AND b.BilesikMi = 0
WHERE t.BesinAdi = N'Bezelye Yemeği' AND t.BilesikMi = 1;

-- Sucuklu Yumurta
INSERT INTO TarifBilesenleri (TarifBesinID, BilesenBesinID, MiktarGram)
SELECT t.BesinID, b.BesinID, v.Miktar
FROM (VALUES
  (N'Sucuk', 100), (N'Yumurta (Orta Boy)', 150), (N'Tereyağı', 10)
) AS v(BesinAdi, Miktar)
CROSS JOIN Besinler t
INNER JOIN Besinler b ON b.BesinAdi = v.BesinAdi AND b.BilesikMi = 0
WHERE t.BesinAdi = N'Sucuklu Yumurta' AND t.BilesikMi = 1;

-- Tavuk Sote
INSERT INTO TarifBilesenleri (TarifBesinID, BilesenBesinID, MiktarGram)
SELECT t.BesinID, b.BesinID, v.Miktar
FROM (VALUES
  (N'Tavuk Göğsü (Çiğ)', 300), (N'Kuru Soğan', 80), (N'Yeşil Biber', 80),
  (N'Domates', 150), (N'Domates Salçası', 15), (N'Zeytinyağı', 20),
  (N'Tuz', 8), (N'Karabiber', 3)
) AS v(BesinAdi, Miktar)
CROSS JOIN Besinler t
INNER JOIN Besinler b ON b.BesinAdi = v.BesinAdi AND b.BilesikMi = 0
WHERE t.BesinAdi = N'Tavuk Sote' AND t.BilesikMi = 1;

-- Et Sote
INSERT INTO TarifBilesenleri (TarifBesinID, BilesenBesinID, MiktarGram)
SELECT t.BesinID, b.BesinID, v.Miktar
FROM (VALUES
  (N'Dana Kuşbaşı', 300), (N'Kuru Soğan', 80), (N'Yeşil Biber', 80),
  (N'Domates', 150), (N'Domates Salçası', 15), (N'Tereyağı', 15),
  (N'Tuz', 8), (N'Karabiber', 3)
) AS v(BesinAdi, Miktar)
CROSS JOIN Besinler t
INNER JOIN Besinler b ON b.BesinAdi = v.BesinAdi AND b.BilesikMi = 0
WHERE t.BesinAdi = N'Et Sote' AND t.BilesikMi = 1;

-- Çılbır
INSERT INTO TarifBilesenleri (TarifBesinID, BilesenBesinID, MiktarGram)
SELECT t.BesinID, b.BesinID, v.Miktar
FROM (VALUES
  (N'Yumurta (Orta Boy)', 150), (N'Yoğurt (Tam Yağlı)', 200),
  (N'Tereyağı', 15), (N'Pul Biber', 3), (N'Sarımsak', 5), (N'Sirke (Elma)', 10)
) AS v(BesinAdi, Miktar)
CROSS JOIN Besinler t
INNER JOIN Besinler b ON b.BesinAdi = v.BesinAdi AND b.BilesikMi = 0
WHERE t.BesinAdi = N'Çılbır' AND t.BilesikMi = 1;
