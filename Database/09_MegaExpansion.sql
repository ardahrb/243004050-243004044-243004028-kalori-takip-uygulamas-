-- =============================================
-- 09: MEGA GENİŞLETİLMİŞ VERİ SETİ
-- Tüm string'ler N'' (Unicode) prefix ile
-- =============================================

-- ====== EK TEMEL BİLEŞENLER (1) ======
INSERT INTO Besinler (BesinAdi, KategoriID, VarsayilanPorsiyonGram, KaloriPer100g, ProteinPer100g, KarbonhidratPer100g, YagPer100g) VALUES
(N'Kakao Tozu', 1, 10, 228, 19.6, 57.9, 13.7),
(N'Vanilya (Toz)', 1, 2, 288, 0, 12.7, 0.1),
(N'Kabartma Tozu', 1, 5, 53, 0, 27.7, 0),
(N'Maya (Kuru)', 1, 7, 325, 40.4, 41.2, 7.6),
(N'Hindistan Cevizi Yağı', 1, 10, 862, 0, 0, 100),
(N'Susam', 1, 10, 573, 17.7, 23.4, 49.7),
(N'Çörek Otu', 1, 5, 345, 16, 44, 14.6),
(N'Defne Yaprağı', 1, 2, 313, 7.6, 75, 8.4),
(N'Sumak', 1, 5, 239, 4, 71, 1),
(N'Nar Ekşisi', 1, 10, 175, 0.5, 43, 0.2),
(N'Biber (Tatlı Toz)', 1, 5, 282, 14.1, 53.9, 12.9),
(N'Zencefil (Toz)', 1, 3, 335, 9, 71.6, 4.2),
(N'Zerdeçal', 1, 3, 312, 9.7, 67.1, 3.3),
(N'Kişniş (Toz)', 1, 3, 298, 12.4, 55, 17.8),
(N'Karanfil (Toz)', 1, 2, 274, 6, 65.5, 13),
(N'Pudra Şekeri', 1, 5, 389, 0, 99.8, 0);
GO

-- ====== EK ET/TAVUK/BALIK (2) ======
INSERT INTO Besinler (BesinAdi, KategoriID, VarsayilanPorsiyonGram, KaloriPer100g, ProteinPer100g, KarbonhidratPer100g, YagPer100g) VALUES
(N'Kuzu Pirzola', 2, 120, 282, 16, 0, 24),
(N'Dana Bonfile', 2, 150, 143, 22, 0, 5.7),
(N'Tavuk Kanat', 2, 80, 203, 18.3, 0, 14.3),
(N'Hindi Göğsü', 2, 100, 104, 24, 0, 0.7),
(N'Ciğer (Dana)', 2, 100, 135, 20.4, 3.9, 3.6),
(N'Ton Balığı (Konserve)', 2, 80, 116, 25.5, 0, 0.8),
(N'Alabalık', 2, 100, 119, 20.5, 0, 3.5),
(N'Sardalya (Konserve)', 2, 50, 208, 24.6, 0, 11.5),
(N'Mezgit', 2, 100, 82, 17.8, 0, 0.7),
(N'Kalamar', 2, 100, 92, 15.6, 3.1, 1.4),
(N'Midye', 2, 100, 86, 11.9, 3.7, 2.2),
(N'Jambon (Hindi)', 2, 30, 120, 18, 2, 4.5),
(N'Kavurma', 2, 50, 350, 26, 0, 27),
(N'Kuzu Kuşbaşı (Yağsız)', 2, 100, 162, 22, 0, 8);
GO

-- ====== EK SÜT ÜRÜNLERİ (3) ======
INSERT INTO Besinler (BesinAdi, KategoriID, VarsayilanPorsiyonGram, KaloriPer100g, ProteinPer100g, KarbonhidratPer100g, YagPer100g) VALUES
(N'Yarım Yağlı Süt', 3, 200, 46, 3.3, 4.8, 1.6),
(N'Yağsız Süt', 3, 200, 34, 3.4, 5, 0.1),
(N'Süzme Yoğurt', 3, 100, 66, 10, 4.3, 0.7),
(N'Kefir', 3, 200, 41, 3.8, 4.5, 1),
(N'Tulum Peyniri', 3, 30, 370, 26, 1, 29),
(N'Lor Peyniri', 3, 50, 99, 11.1, 3.4, 4.3),
(N'Çedar Peyniri', 3, 30, 403, 25, 1.3, 33.1),
(N'Krema (Sıvı)', 3, 15, 195, 2.8, 4, 19.1),
(N'Krem Peynir', 3, 20, 342, 5.9, 4.1, 34.2),
(N'Taze Kaşar', 3, 30, 313, 22, 2, 24),
(N'Çökelek', 3, 50, 195, 33, 2, 6),
(N'Yoğurt (Yağsız)', 3, 100, 42, 4.3, 5.6, 0.2),
(N'Peynir Altı Suyu Proteini', 3, 30, 352, 80, 8, 1.5);
GO

-- ====== EK SEBZE/MEYVE (4) ======
INSERT INTO Besinler (BesinAdi, KategoriID, VarsayilanPorsiyonGram, KaloriPer100g, ProteinPer100g, KarbonhidratPer100g, YagPer100g) VALUES
(N'Ispanak', 4, 100, 23, 2.9, 3.6, 0.4),
(N'Mantar (Kültür)', 4, 100, 22, 3.1, 3.3, 0.3),
(N'Turp', 4, 50, 16, 0.7, 3.4, 0.1),
(N'Kereviz', 4, 100, 42, 1.5, 9.2, 0.3),
(N'Pırasa', 4, 100, 61, 1.5, 14.2, 0.3),
(N'Enginar', 4, 100, 47, 3.3, 10.5, 0.2),
(N'Semizotu', 4, 100, 20, 2, 3.4, 0.4),
(N'Kuşkonmaz', 4, 100, 20, 2.2, 3.9, 0.1),
(N'Roka', 4, 50, 25, 2.6, 3.7, 0.7),
(N'Marul', 4, 50, 15, 1.4, 2.9, 0.2),
(N'Sivri Biber', 4, 30, 27, 1, 6.4, 0.3),
(N'Kırmızı Biber (Kapya)', 4, 80, 31, 1, 6, 0.3),
(N'Avokado', 4, 100, 160, 2, 8.5, 14.7),
(N'Çilek', 4, 100, 33, 0.7, 7.7, 0.3),
(N'Ahududu', 4, 100, 52, 1.2, 11.9, 0.7),
(N'Böğürtlen', 4, 100, 43, 1.4, 9.6, 0.5),
(N'Yaban Mersini', 4, 100, 57, 0.7, 14.5, 0.3),
(N'Kavun', 4, 200, 34, 0.8, 8.2, 0.2),
(N'Armut', 4, 150, 57, 0.4, 15.2, 0.1),
(N'Kayısı (Taze)', 4, 100, 48, 1.4, 11.1, 0.4),
(N'Erik', 4, 100, 46, 0.7, 11.4, 0.3),
(N'Greyfurt', 4, 150, 42, 0.8, 10.7, 0.1),
(N'Mandalina', 4, 80, 53, 0.8, 13.3, 0.3),
(N'İncir (Taze)', 4, 80, 74, 0.8, 19.2, 0.3),
(N'Ananas', 4, 100, 50, 0.5, 13.1, 0.1),
(N'Mango', 4, 100, 60, 0.8, 15, 0.4),
(N'Taze Soğan (Yeşil)', 4, 20, 32, 1.8, 7.3, 0.2),
(N'Sarımsak (Taze)', 4, 5, 149, 6.4, 33.1, 0.5),
(N'Zeytin (Siyah)', 4, 20, 115, 0.8, 6, 11),
(N'Zeytin (Yeşil)', 4, 20, 145, 1, 3.8, 15.3),
(N'Turşu (Karışık)', 4, 50, 11, 0.3, 2.3, 0.2);
GO

-- ====== EK TAHIL/BAKLAGİL (5) ======
INSERT INTO Besinler (BesinAdi, KategoriID, VarsayilanPorsiyonGram, KaloriPer100g, ProteinPer100g, KarbonhidratPer100g, YagPer100g) VALUES
(N'Yulaf Ezmesi', 5, 40, 389, 16.9, 66.3, 6.9),
(N'Kinoa', 5, 80, 368, 14.1, 64, 6.1),
(N'Karabuğday', 5, 80, 343, 13.3, 71.5, 3.4),
(N'Beyaz Ekmek', 5, 50, 265, 9, 49, 3.2),
(N'Çavdar Ekmeği', 5, 50, 259, 8.5, 48, 3.3),
(N'Kepek Ekmeği', 5, 50, 247, 8.8, 43.3, 3.5),
(N'Lavaş', 5, 60, 275, 9, 56, 1.2),
(N'Yufka', 5, 50, 310, 8.6, 63.5, 2.3),
(N'Pilavlık Bulgur (Pişmiş)', 5, 150, 83, 3.1, 18.6, 0.2),
(N'Kuskus', 5, 100, 376, 12.8, 77.4, 0.6),
(N'Yeşil Mercimek (Çiğ)', 5, 100, 352, 24.6, 60.1, 1.1),
(N'Barbunya (Çiğ)', 5, 100, 347, 21.4, 61.3, 1.1),
(N'Börülce (Çiğ)', 5, 100, 336, 23.5, 60, 1.3),
(N'Pirinç Pilavı (Tereyağlı)', 5, 200, 163, 3.2, 28.2, 3.5),
(N'Makarna (Fırın)', 5, 200, 185, 7, 24, 7);
GO

-- ====== EK HAZIR/PAKETLİ GIDA (6) ======
INSERT INTO Besinler (BesinAdi, KategoriID, VarsayilanPorsiyonGram, KaloriPer100g, ProteinPer100g, KarbonhidratPer100g, YagPer100g) VALUES
(N'Tost Ekmeği', 6, 25, 261, 8, 49, 3.5),
(N'Hamburger Ekmeği', 6, 60, 272, 8, 49, 4.8),
(N'Tortilla (Lavaş)', 6, 50, 312, 8.3, 52, 8.1),
(N'Çikolata (Sütlü)', 6, 30, 535, 7.6, 59.4, 29.7),
(N'Çikolata (Bitter %70)', 6, 25, 598, 7.8, 45.9, 42.6),
(N'Bisküvi (Sade)', 6, 30, 480, 6.5, 70, 20),
(N'Kurabiye (Tereyağlı)', 6, 25, 502, 5.2, 60, 27),
(N'Kek (Sade)', 6, 80, 347, 5, 50, 14),
(N'Baklava', 6, 60, 540, 8, 53, 33),
(N'Lokum', 6, 30, 350, 0.5, 89, 0.5),
(N'Helva (Tahin)', 6, 30, 516, 12.4, 49.5, 31),
(N'Halka Tatlı', 6, 60, 415, 5, 55, 20),
(N'Sütlaç', 6, 150, 115, 3.5, 18.5, 3),
(N'Muhallebi', 6, 150, 105, 3, 17, 2.8),
(N'Tulumba', 6, 60, 390, 4, 50, 19),
(N'Revani', 6, 80, 320, 5, 55, 9),
(N'Künefe', 6, 100, 410, 9, 45, 22),
(N'Kazandibi', 6, 150, 130, 4, 22, 3),
(N'Peynirli Tost', 6, 120, 280, 12, 30, 12),
(N'Hamburger (Klasik)', 6, 200, 250, 13, 24, 12),
(N'Dürüm (Tavuk)', 6, 250, 185, 12, 22, 5.5),
(N'Patates Kızartması', 6, 100, 312, 3.4, 41.4, 14.7),
(N'Soğan Halkası', 6, 80, 332, 4.4, 39, 18),
(N'Nugget (Tavuk)', 6, 100, 297, 15, 18, 18),
(N'Pide (Peynirli)', 6, 200, 250, 10, 32, 9);
GO

-- ====== EK İÇECEKLER (7) ======
INSERT INTO Besinler (BesinAdi, KategoriID, VarsayilanPorsiyonGram, KaloriPer100g, ProteinPer100g, KarbonhidratPer100g, YagPer100g) VALUES
(N'Süt (Çikolatalı)', 7, 200, 83, 3.2, 12, 2.5),
(N'Latte', 7, 250, 40, 2, 4, 1.5),
(N'Americano', 7, 250, 2, 0.3, 0, 0),
(N'Mocha', 7, 250, 80, 3, 12, 2.5),
(N'Sahlep', 7, 200, 65, 2, 12, 1.5),
(N'Limonata', 7, 250, 40, 0.1, 10, 0),
(N'Fanta', 7, 330, 42, 0, 10.3, 0),
(N'Sprite', 7, 330, 39, 0, 9.8, 0),
(N'Maden Suyu', 7, 200, 0, 0, 0, 0),
(N'Ayran (Duble)', 7, 300, 36, 1.7, 2.8, 1.8),
(N'Boza', 7, 200, 50, 0.5, 11, 0.3),
(N'Smoothie (Karışık Meyve)', 7, 250, 55, 1, 13, 0.3);
GO

-- ====== EK KURUYEMİŞ & TOHUMLAR (8) ======
INSERT INTO Besinler (BesinAdi, KategoriID, VarsayilanPorsiyonGram, KaloriPer100g, ProteinPer100g, KarbonhidratPer100g, YagPer100g) VALUES
(N'Chia Tohumu', 8, 15, 486, 16.5, 42.1, 30.7),
(N'Keten Tohumu', 8, 15, 534, 18.3, 28.9, 42.2),
(N'Fıstık Ezmesi', 8, 20, 588, 25, 20, 50),
(N'Badem Ezmesi', 8, 20, 614, 21, 19, 55.5),
(N'Hindistan Cevizi (Rendelenmiş)', 8, 20, 354, 3.3, 15, 33.5),
(N'Kuru Dut', 8, 30, 346, 9.8, 77.5, 3.2),
(N'Kuru Çilek', 8, 20, 375, 2, 84, 4.6),
(N'Trail Mix (Karışık)', 8, 40, 462, 13, 45, 29);
GO

-- ====== EK KLASİK TÜRK YEMEKLERİ (9) ======
INSERT INTO Besinler (BesinAdi, KategoriID, VarsayilanPorsiyonGram, KaloriPer100g, ProteinPer100g, KarbonhidratPer100g, YagPer100g, BilesikMi) VALUES
(N'Hünkar Beğendi', 9, 300, 130, 9, 8, 7, 1),
(N'Etli Pilav', 9, 250, 165, 8, 22, 5, 1),
(N'Düğün Çorbası', 9, 250, 60, 4, 5, 2.5, 1),
(N'İşkembe Çorbası', 9, 250, 52, 5.5, 3, 2, 1),
(N'Beyti Kebap', 9, 200, 210, 16, 8, 13, 1),
(N'Urfa Kebap', 9, 100, 220, 16, 3, 16, 1),
(N'Çöp Şiş', 9, 100, 190, 20, 2, 11, 1),
(N'Tavuk Şiş', 9, 100, 150, 22, 2, 6, 1),
(N'Fırın Makarna', 9, 250, 165, 7, 22, 5.5, 1),
(N'Börek (Ispanaklı)', 9, 150, 220, 7, 22, 12, 1),
(N'Su Böreği', 9, 200, 233, 8.5, 23, 12.5, 1),
(N'Sigara Böreği (Peynirli)', 9, 80, 310, 9, 28, 18, 1),
(N'Zeytinyağlı Fasulye', 9, 200, 80, 3, 10, 3.5, 1),
(N'Zeytinyağlı Biber Dolma', 9, 200, 85, 2, 12, 3.5, 1),
(N'Zeytinyağlı Enginar', 9, 200, 75, 2, 10, 3, 1),
(N'Zeytinyağlı Kereviz', 9, 200, 72, 1.5, 10, 3, 1),
(N'Zeytinyağlı Barbunya', 9, 200, 100, 5, 14, 3, 1),
(N'Lahana Sarma (Etli)', 9, 200, 115, 7, 10, 5.5, 1),
(N'Biber Dolma (Etli)', 9, 200, 130, 7, 12, 6, 1),
(N'Kabak Dolma', 9, 200, 90, 4, 12, 3, 1),
(N'Tas Kebabı', 9, 250, 135, 11, 6, 7.5, 1),
(N'Orman Kebabı', 9, 300, 120, 9, 8, 6, 1),
(N'Saç Kavurma', 9, 150, 220, 20, 3, 14, 1),
(N'Çılbır', 9, 200, 110, 7, 3, 8, 1),
(N'Sucuklu Yumurta', 9, 150, 210, 14, 2, 16, 1),
(N'Sahanda Yumurta', 9, 120, 190, 12, 1, 15, 1),
(N'Omlet (Peynirli)', 9, 150, 165, 12, 2, 12, 1),
(N'Patates Oturtma', 9, 250, 95, 5, 12, 3.5, 1),
(N'Kuzu İncik', 9, 300, 175, 18, 2, 10, 1),
(N'Tantuni', 9, 200, 195, 14, 15, 9, 1),
(N'Çiğ Börek', 9, 120, 290, 11, 28, 15, 1),
(N'Mıhlama', 9, 200, 220, 9, 8, 18, 1),
(N'Kuymak', 9, 200, 230, 8, 10, 18, 1),
(N'Fıstıklı Kebap', 9, 100, 260, 14, 8, 19, 1),
(N'Çerkez Tavuğu', 9, 200, 155, 14, 8, 8, 1),
(N'Tavuk Sote', 9, 250, 110, 13, 5, 4.5, 1),
(N'Et Sote', 9, 250, 140, 14, 5, 7, 1),
(N'Karnıbahar Graten', 9, 200, 100, 6, 8, 5, 1),
(N'Fırın Tavuk', 9, 200, 165, 20, 3, 8, 1),
(N'Mercimek Köftesi (Kısır Usulü)', 9, 100, 160, 6, 25, 4.5, 1);
GO
