INSERT INTO BesinKategorileri (KategoriAdi) VALUES (N'Temel Bileşen'),(N'Et/Tavuk/Balık'),(N'Süt Ürünleri'),(N'Sebze/Meyve'),(N'Tahıl/Baklagil'),(N'Hazır/Paketli Gıda'),(N'İçecekler'),(N'Kuruyemiş & Tohumlar'),(N'Klasik Türk Yemekleri');
GO

-- TEMEL BİLEŞEN (1)
INSERT INTO Besinler (BesinAdi, KategoriID, VarsayilanPorsiyonGram, KaloriPer100g, ProteinPer100g, KarbonhidratPer100g, YagPer100g) VALUES
(N'Beyaz Un', 1, 100, 364, 10.3, 76.3, 1),
(N'Tam Buğday Unu', 1, 100, 340, 13.2, 72, 2.5),
(N'Beyaz Şeker', 1, 5, 387, 0, 100, 0),
(N'Esmer Şeker', 1, 5, 380, 0, 98, 0),
(N'Zeytinyağı', 1, 10, 884, 0, 0, 100),
(N'Ayçiçek Yağı', 1, 10, 884, 0, 0, 100),
(N'Tereyağı', 1, 10, 717, 0.9, 0.1, 81.1),
(N'Tuz', 1, 3, 0, 0, 0, 0),
(N'Karabiber', 1, 3, 251, 10.4, 63.9, 3.3),
(N'Pul Biber', 1, 3, 282, 12, 50, 5.8),
(N'Domates Salçası', 1, 15, 82, 4.3, 18.9, 0.5),
(N'Biber Salçası', 1, 15, 75, 3.5, 16, 0.8),
(N'Sirke (Elma)', 1, 10, 21, 0, 0.9, 0),
(N'Limon Suyu', 1, 10, 22, 0.4, 6.9, 0.2),
(N'Sarımsak', 1, 5, 149, 6.4, 33.1, 0.5),
(N'Su', 1, 200, 0, 0, 0, 0),
(N'Nişasta', 1, 10, 381, 0.3, 91.3, 0.1),
(N'Galeta Unu', 1, 20, 395, 13.4, 72, 5.8),
(N'Bal', 1, 20, 304, 0.3, 82.4, 0),
(N'Pekmez (Üzüm)', 1, 20, 293, 0.4, 73, 0.1),
(N'Tahin', 1, 15, 595, 17, 21.2, 53.8),
(N'Soya Sosu', 1, 10, 53, 8.1, 4.9, 0.6),
(N'Tarçın (Toz)', 1, 3, 247, 4, 80.6, 1.2),
(N'Kimyon', 1, 3, 375, 17.8, 44.2, 22.3),
(N'Kekik (Kuru)', 1, 3, 276, 9.1, 63.9, 7.4),
(N'Nane (Kuru)', 1, 3, 285, 19.9, 52.8, 6.0),
(N'Margarin', 1, 10, 719, 0.2, 0.7, 80.7),
(N'İrmik', 1, 50, 360, 12.7, 72.8, 1.1);
GO

-- ET/TAVUK/BALIK (2)
INSERT INTO Besinler (BesinAdi, KategoriID, VarsayilanPorsiyonGram, KaloriPer100g, ProteinPer100g, KarbonhidratPer100g, YagPer100g) VALUES
(N'Tavuk Göğsü (Çiğ)', 2, 100, 120, 22.5, 0, 2.6),
(N'Dana Kıyma (%10 Yağlı)', 2, 100, 176, 20, 0, 10),
(N'Dana Kıyma (%20 Yağlı)', 2, 100, 254, 17.2, 0, 20),
(N'Dana Kuşbaşı', 2, 100, 155, 21, 0, 7.7),
(N'Kuzu Kuşbaşı', 2, 100, 206, 20.3, 0, 13.4),
(N'Tavuk But (Çiğ)', 2, 100, 172, 17.3, 0, 10.9),
(N'Yumurta (Orta Boy)', 2, 50, 144, 12.6, 0.6, 9.5),
(N'Somon Balığı (Çiğ)', 2, 100, 208, 20, 0, 13.4),
(N'Sucuk', 2, 30, 452, 18.2, 1.8, 41.5),
(N'Salam', 2, 30, 325, 11.8, 2.9, 29.2),
(N'Sosis', 2, 50, 290, 10.5, 3.5, 26),
(N'Pastırma', 2, 20, 174, 33, 1, 4.3),
(N'Karides', 2, 100, 99, 20.9, 0.2, 1.7),
(N'Hamsi (Çiğ)', 2, 100, 131, 20.4, 0, 4.8),
(N'Levrek (Çiğ)', 2, 100, 97, 18.4, 0, 2.0);
GO

-- SÜT ÜRÜNLERİ (3)
INSERT INTO Besinler (BesinAdi, KategoriID, VarsayilanPorsiyonGram, KaloriPer100g, ProteinPer100g, KarbonhidratPer100g, YagPer100g) VALUES
(N'Tam Yağlı İnek Sütü', 3, 200, 61, 3.2, 4.8, 3.3),
(N'Yoğurt (Tam Yağlı)', 3, 100, 61, 3.5, 4.7, 3.3),
(N'Beyaz Peynir (Tam Yağlı)', 3, 30, 289, 17, 0.5, 24),
(N'Kaşar Peyniri', 3, 30, 350, 25, 2, 27),
(N'Ayran', 3, 200, 36, 1.7, 2.8, 1.8),
(N'Labne Peyniri', 3, 30, 160, 6, 3, 14),
(N'Mozzarella', 3, 30, 280, 28, 3.1, 17.1),
(N'Dondurma (Vanilya)', 3, 100, 207, 3.5, 24, 11),
(N'Kaymak', 3, 30, 292, 2.5, 3.5, 30);
GO

-- SEBZE/MEYVE (4)
INSERT INTO Besinler (BesinAdi, KategoriID, VarsayilanPorsiyonGram, KaloriPer100g, ProteinPer100g, KarbonhidratPer100g, YagPer100g) VALUES
(N'Domates', 4, 100, 18, 0.9, 3.9, 0.2),
(N'Salatalık', 4, 100, 15, 0.7, 3.6, 0.1),
(N'Yeşil Biber', 4, 30, 20, 0.9, 4.6, 0.2),
(N'Kuru Soğan', 4, 50, 40, 1.1, 9.3, 0.1),
(N'Havuç', 4, 80, 41, 0.9, 9.6, 0.2),
(N'Patates', 4, 100, 77, 2, 17, 0.1),
(N'Elma', 4, 150, 52, 0.3, 13.8, 0.2),
(N'Muz', 4, 120, 89, 1.1, 22.8, 0.3),
(N'Portakal', 4, 150, 47, 0.9, 11.8, 0.1),
(N'Brokoli', 4, 100, 34, 2.8, 6.6, 0.4),
(N'Karnabahar', 4, 100, 25, 1.9, 5, 0.3),
(N'Kabak', 4, 100, 17, 1.2, 3.1, 0.3),
(N'Patlıcan', 4, 100, 25, 1, 6, 0.2),
(N'Bezelye (Taze)', 4, 100, 81, 5.4, 14.5, 0.4),
(N'Mısır (Tane)', 4, 100, 86, 3.3, 19, 1.2),
(N'Maydanoz', 4, 10, 36, 3, 6.3, 0.8),
(N'Dereotu', 4, 10, 43, 3.5, 7, 1.1),
(N'Karpuz', 4, 200, 30, 0.6, 7.6, 0.2),
(N'Şeftali', 4, 150, 39, 0.9, 9.5, 0.3),
(N'Üzüm', 4, 100, 69, 0.7, 18.1, 0.2),
(N'Kiraz', 4, 100, 63, 1.1, 16, 0.2),
(N'Nar', 4, 100, 83, 1.7, 18.7, 1.2),
(N'Taze Fasulye', 4, 100, 31, 1.8, 7, 0.1),
(N'Bamya', 4, 100, 33, 1.9, 7.5, 0.2),
(N'Lahana', 4, 100, 25, 1.3, 5.8, 0.1);
GO

-- TAHIL/BAKLAGİL (5)
INSERT INTO Besinler (BesinAdi, KategoriID, VarsayilanPorsiyonGram, KaloriPer100g, ProteinPer100g, KarbonhidratPer100g, YagPer100g) VALUES
(N'Beyaz Pirinç (Çiğ)', 5, 100, 365, 7.1, 80, 0.7),
(N'Bulgur (Çiğ)', 5, 100, 342, 12.3, 75.9, 1.3),
(N'Kırmızı Mercimek (Çiğ)', 5, 100, 352, 24.6, 63.4, 1.1),
(N'Kuru Fasulye (Çiğ)', 5, 100, 333, 23.4, 60.3, 0.8),
(N'Nohut (Çiğ)', 5, 100, 364, 19.3, 60.7, 6),
(N'Makarna (Çiğ)', 5, 100, 371, 13, 74.7, 1.5),
(N'Ekmek (Tam Buğday)', 5, 50, 247, 13, 41, 3.4),
(N'Pirinç (Pişmiş)', 5, 150, 130, 2.7, 28, 0.3),
(N'Makarna (Pişmiş)', 5, 200, 158, 5.8, 31, 0.9),
(N'Bulgur Pilavı (Pişmiş)', 5, 150, 83, 3.1, 18.6, 0.2);
GO

-- HAZIR/PAKETLİ GIDA (6)
INSERT INTO Besinler (BesinAdi, KategoriID, VarsayilanPorsiyonGram, KaloriPer100g, ProteinPer100g, KarbonhidratPer100g, YagPer100g) VALUES
(N'Simit', 6, 120, 310, 9.5, 57, 5.5),
(N'Poğaça (Peynirli)', 6, 80, 335, 8, 38, 17),
(N'Börek (Su Böreği)', 6, 150, 233, 8.5, 23, 12.5),
(N'Sigara Böreği', 6, 50, 310, 9, 28, 18),
(N'Lahmacun', 6, 180, 210, 10, 28, 6.5),
(N'Pide (Kıymalı)', 6, 200, 225, 11, 28, 8),
(N'Pizza (Karışık)', 6, 120, 266, 11.4, 33, 10),
(N'Gofret (Çikolatalı)', 6, 30, 520, 6.5, 60, 28),
(N'Nutella', 6, 15, 539, 6.3, 57.5, 30.9),
(N'Reçel (Çilek)', 6, 20, 250, 0.4, 63, 0.1),
(N'Mısır Gevreği', 6, 30, 378, 7, 84, 0.9),
(N'Granola', 6, 40, 471, 10, 64, 20),
(N'Protein Bar', 6, 60, 370, 30, 35, 12),
(N'Ketçap', 6, 15, 112, 1.7, 26, 0.4),
(N'Mayonez', 6, 15, 680, 1, 0.6, 75),
(N'Cips (Patates)', 6, 30, 536, 7, 53, 35),
(N'Kraker (Tuzlu)', 6, 30, 440, 10, 68, 14),
(N'Bazlama', 6, 80, 280, 8, 52, 4),
(N'Makarna Sosu (Domates)', 6, 50, 52, 1.5, 8, 1.5),
(N'Hazır Noodle', 6, 75, 450, 9, 62, 18);
GO

-- İÇECEKLER (7)
INSERT INTO Besinler (BesinAdi, KategoriID, VarsayilanPorsiyonGram, KaloriPer100g, ProteinPer100g, KarbonhidratPer100g, YagPer100g) VALUES
(N'Çay (Şekersiz)', 7, 200, 1, 0, 0.2, 0),
(N'Türk Kahvesi (Sade)', 7, 65, 2, 0.1, 0.4, 0),
(N'Filtre Kahve (Siyah)', 7, 250, 1, 0.1, 0, 0),
(N'Kola', 7, 330, 42, 0, 10.6, 0),
(N'Kola (Zero)', 7, 330, 0.3, 0, 0, 0),
(N'Meyve Suyu (Portakal)', 7, 200, 45, 0.7, 10.4, 0.2),
(N'Enerji İçeceği', 7, 250, 45, 0, 11, 0),
(N'Soda', 7, 200, 0, 0, 0, 0),
(N'Şalgam Suyu', 7, 200, 14, 0.3, 3, 0),
(N'Cappuccino (Sütlü)', 7, 200, 30, 1.5, 3, 1.2),
(N'Buzlu Çay', 7, 330, 32, 0, 8, 0);
GO

-- KURUYEMİŞ & TOHUMLAR (8)
INSERT INTO Besinler (BesinAdi, KategoriID, VarsayilanPorsiyonGram, KaloriPer100g, ProteinPer100g, KarbonhidratPer100g, YagPer100g) VALUES
(N'Ceviz (İç)', 8, 30, 654, 15.2, 13.7, 65.2),
(N'Badem (İç)', 8, 30, 579, 21.2, 21.7, 49.9),
(N'Fındık (İç)', 8, 30, 628, 15, 16.7, 60.8),
(N'Antep Fıstığı', 8, 30, 560, 20.2, 27.2, 45.3),
(N'Yer Fıstığı', 8, 30, 567, 25.8, 16.1, 49.2),
(N'Kaju', 8, 30, 553, 18.2, 30.2, 43.8),
(N'Ay Çekirdeği', 8, 30, 584, 20.8, 20, 51.5),
(N'Kabak Çekirdeği', 8, 30, 559, 30.2, 10.7, 49),
(N'Kuru Üzüm', 8, 30, 299, 3.1, 79.2, 0.5),
(N'Kuru Kayısı', 8, 30, 241, 3.4, 62.6, 0.5),
(N'Hurma', 8, 30, 277, 1.8, 75, 0.2),
(N'Kuru İncir', 8, 30, 249, 3.3, 63.9, 0.9),
(N'Leblebi', 8, 30, 370, 22, 52, 7);
GO

-- KLASİK TÜRK YEMEKLERİ (9) - BilesikMi=1
INSERT INTO Besinler (BesinAdi, KategoriID, VarsayilanPorsiyonGram, KaloriPer100g, ProteinPer100g, KarbonhidratPer100g, YagPer100g, BilesikMi) VALUES
(N'Mercimek Çorbası', 9, 250, 56, 3.5, 8, 1.2, 1),
(N'Ezogelin Çorbası', 9, 250, 52, 2.8, 8.5, 1, 1),
(N'Tarhana Çorbası', 9, 250, 45, 2.2, 7.5, 0.8, 1),
(N'Yayla Çorbası', 9, 250, 48, 2.5, 5.5, 1.8, 1),
(N'Domates Çorbası', 9, 250, 38, 1.2, 6, 1, 1),
(N'Menemen', 9, 200, 95, 5.5, 5.5, 6, 1),
(N'Karnıyarık', 9, 250, 118, 6.5, 8, 7, 1),
(N'İmam Bayıldı', 9, 200, 80, 1.5, 8, 5, 1),
(N'Kuru Fasulye (Yemek)', 9, 250, 105, 6, 14, 2.5, 1),
(N'Etli Nohut', 9, 250, 125, 8, 12, 5, 1),
(N'Patlıcan Musakka', 9, 250, 115, 6, 9, 6.5, 1),
(N'Zeytinyağlı Yaprak Sarma', 9, 150, 160, 2.5, 18, 9, 1),
(N'Türlü (Sebze)', 9, 250, 55, 1.5, 8, 2, 1),
(N'Bezelye Yemeği', 9, 250, 72, 3.5, 10, 2, 1),
(N'Taze Fasulye Yemeği', 9, 250, 60, 2, 8, 2.5, 1),
(N'Köfte (Izgara)', 9, 100, 234, 18, 5, 16, 1),
(N'Adana Kebap', 9, 100, 230, 17, 2, 17, 1),
(N'İskender', 9, 300, 180, 12, 10, 10, 1),
(N'Mantı', 9, 250, 155, 7, 18, 6, 1),
(N'Çiğ Köfte (Etsiz)', 9, 100, 180, 5, 30, 5, 1),
(N'Döner (Tavuk)', 9, 150, 175, 17, 6, 9, 1),
(N'Döner (Et)', 9, 150, 210, 15, 4, 15, 1),
(N'Gözleme (Peynirli)', 9, 150, 215, 8, 28, 8, 1),
(N'Kısır', 9, 150, 135, 4, 20, 4.5, 1),
(N'Mercimek Köftesi', 9, 100, 175, 6.5, 27, 5, 1),
(N'İçli Köfte', 9, 100, 235, 10, 25, 11, 1),
(N'Cacık', 9, 200, 40, 2.5, 3, 2, 1),
(N'Piyaz', 9, 200, 95, 5, 12, 3.5, 1),
(N'Ali Nazik', 9, 250, 130, 10, 5, 8, 1),
(N'Kuzu Tandır', 9, 200, 195, 18, 2, 13, 1);
GO
