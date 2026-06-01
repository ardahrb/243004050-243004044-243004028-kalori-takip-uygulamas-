-- Önce Kategorileri Ekleyelim
INSERT INTO BesinKategorileri (KategoriAdi) VALUES 
('Temel Bileşen'), 
('Et/Tavuk/Balık'), 
('Süt Ürünleri'), 
('Sebze/Meyve'), 
('Tahıl/Baklagil'), 
('Hazır/Paketli Gıda');

-- Besinleri Eklerken KategoriID'yi dinamik alarak ekliyoruz.
-- BilesikMi varsayılan olarak 0 olacak (hepsi temel malzeme)
-- OlusturanKullaniciID NULL olacak (hepsi sistem besini)

INSERT INTO Besinler (BesinAdi, KategoriID, VarsayilanPorsiyonGram, KaloriPer100g, ProteinPer100g, KarbonhidratPer100g, YagPer100g)
VALUES
-- Temel Bileşen (Tarif Motoru Odaklı) - KategoriID: 1
('Beyaz Un', 1, 100, 364, 10.3, 76.3, 1.0),
('Tam Buğday Unu', 1, 100, 340, 13.2, 72.6, 2.5),
('Beyaz Şeker', 1, 100, 387, 0, 100, 0),
('Esmer Şeker', 1, 100, 380, 0.1, 98, 0),
('Zeytinyağı', 1, 10, 884, 0, 0, 100),
('Ayçiçek Yağı', 1, 10, 884, 0, 0, 100),
('Tereyağı', 1, 10, 717, 0.8, 0.1, 81.1),
('Domates Salçası', 1, 20, 82, 4.3, 19, 0.5),
('Biber Salçası', 1, 20, 105, 5.2, 23.1, 1.2),
('Kabartma Tozu', 1, 10, 53, 0, 27.7, 0),
('Kuru Maya', 1, 10, 325, 40.4, 41.2, 7.6),
('Tuz', 1, 5, 0, 0, 0, 0),
('Karabiber', 1, 5, 251, 10.4, 64, 3.3),
('Pul Biber', 1, 5, 318, 12, 56.6, 17.3),
('Su', 1, 100, 0, 0, 0, 0),
('Kakao Tozu', 1, 10, 228, 19.6, 57.9, 13.7),
('Pudra Şekeri', 1, 10, 389, 0, 99.8, 0),
('Sıvı Krema', 1, 20, 340, 2.4, 3.3, 35.5),
('Limon Suyu', 1, 10, 22, 0.4, 6.9, 0.2),
('Sirke (Elma)', 1, 10, 21, 0, 0.9, 0),

-- Et/Tavuk/Balık - KategoriID: 2
('Tavuk Göğsü (Çiğ)', 2, 100, 110, 23.1, 0, 1.2),
('Dana Kıyma (%10 Yağlı)', 2, 100, 212, 26.2, 0, 11),
('Dana Kıyma (%20 Yağlı)', 2, 100, 254, 17.2, 0, 20),
('Dana Kuşbaşı', 2, 100, 143, 26.1, 0, 3.5),
('Somon Balığı (Çiğ)', 2, 100, 208, 20.4, 0, 13.4),
('Ton Balığı (Süzülmüş)', 2, 100, 116, 26, 0, 1),
('Hindi Göğsü (Çiğ)', 2, 100, 114, 23.7, 0, 1.5),

-- Süt Ürünleri - KategoriID: 3
-- Yumurtanın varsayılan porsiyonunu 50gr (1 adet) yaptık, değerler yine 100gr üzerinden hesaplandı (72 kcal / 50g -> 144 kcal / 100g)
-- Senin gönderdiğin "72 kcal" 50gr içindi. Sistemimizin 100gr kuralına göre matematikle 2 ile çarparak yazıyoruz.
('Yumurta (Orta Boy)', 3, 50, 144, 12.6, 0.8, 9.6), 
('Tam Yağlı İnek Sütü', 3, 200, 61, 3.2, 4.8, 3.3),
('Yarım Yağlı İnek Sütü', 3, 200, 47, 3.3, 5, 1.5),
('Yoğurt (Tam Yağlı)', 3, 150, 61, 3.5, 4.7, 3.3),
('Süzme Yoğurt', 3, 100, 97, 9, 4, 5),
('Beyaz Peynir (Tam Yağlı)', 3, 30, 264, 14, 2.5, 22),
('Kaşar Peyniri', 3, 30, 353, 25, 2, 27),
('Lor Peyniri', 3, 50, 98, 11, 3, 4.5),
('Kefir', 3, 200, 43, 3.3, 4, 1.5),

-- Sebze/Meyve - KategoriID: 4
('Domates', 4, 100, 18, 0.9, 3.9, 0.2),
('Salatalık', 4, 100, 15, 0.7, 3.6, 0.1),
('Kuru Soğan', 4, 50, 40, 1.1, 9.3, 0.1),
('Sarımsak', 4, 5, 149, 6.4, 33.1, 0.5),
('Patates', 4, 100, 77, 2, 17.5, 0.1),
('Havuç', 4, 100, 41, 0.9, 9.6, 0.2),
('Yeşil Biber', 4, 50, 20, 0.9, 4.6, 0.2),
('Muz', 4, 120, 89, 1.1, 22.8, 0.3),
('Elma', 4, 150, 52, 0.3, 13.8, 0.2),
('Portakal', 4, 150, 47, 0.9, 11.8, 0.1),
('Çilek', 4, 100, 32, 0.7, 7.7, 0.3),
('Avokado', 4, 100, 160, 2, 8.5, 14.7),
('Ispanak', 4, 100, 23, 2.9, 3.6, 0.4),
('Mantar', 4, 100, 22, 3.1, 3.3, 0.3),

-- Tahıl/Baklagil - KategoriID: 5
('Beyaz Pirinç (Çiğ)', 5, 100, 130, 2.7, 28, 0.3),
('Bulgur (Çiğ)', 5, 100, 342, 12.3, 76, 1.3),
('Kırmızı Mercimek (Çiğ)', 5, 100, 353, 25.8, 60.1, 1.1),
('Nohut (Çiğ)', 5, 100, 364, 19.3, 60.6, 6),
('Kuru Fasulye (Çiğ)', 5, 100, 347, 21.4, 62.6, 1.2),
('Yulaf Ezmesi', 5, 50, 389, 16.9, 66.3, 6.9),
('Makarna (Çiğ)', 5, 100, 371, 13, 74.7, 1.5),

-- Hazır/Paketli Gıda - KategoriID: 6
('Ekmek (Beyaz)', 6, 50, 265, 9, 49, 3.2),
('Ekmek (Tam Buğday)', 6, 50, 247, 13, 41, 3.4),
('Lavaş', 6, 60, 290, 8, 55, 3),
('Tost Ekmeği', 6, 30, 265, 8.5, 48, 4),
('Sütlü Çikolata', 6, 25, 535, 7.7, 59.4, 29.7),
('Bisküvi (Pötibör)', 6, 30, 438, 7, 74, 12),
('Fıstık Ezmesi', 6, 15, 588, 25, 20, 50);
