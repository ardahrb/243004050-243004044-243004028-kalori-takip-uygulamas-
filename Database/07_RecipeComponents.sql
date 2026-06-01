-- Mercimek Çorbası (4 porsiyon, ~1000g)
DECLARE @id INT;
SET @id = (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Mercimek Çorbası');
INSERT INTO TarifBilesenleri (TarifBesinID, BilesenBesinID, MiktarGram) VALUES
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Kırmızı Mercimek (Çiğ)'), 200),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Kuru Soğan'), 80),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Havuç'), 60),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Domates Salçası'), 20),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Tereyağı'), 25),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Su'), 600),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Tuz'), 5),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Kimyon'), 3);
UPDATE Besinler SET ToplamAgirlikGram = 993 WHERE BesinID = @id;

-- Ezogelin Çorbası (4 porsiyon, ~1050g)
SET @id = (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Ezogelin Çorbası');
INSERT INTO TarifBilesenleri (TarifBesinID, BilesenBesinID, MiktarGram) VALUES
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Kırmızı Mercimek (Çiğ)'), 150),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Bulgur (Çiğ)'), 50),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Kuru Soğan'), 60),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Domates Salçası'), 25),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Biber Salçası'), 15),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Tereyağı'), 20),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Nane (Kuru)'), 3),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Su'), 700),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Tuz'), 5);
UPDATE Besinler SET ToplamAgirlikGram = 1028 WHERE BesinID = @id;

-- Menemen (2 porsiyon, ~400g)
SET @id = (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Menemen');
INSERT INTO TarifBilesenleri (TarifBesinID, BilesenBesinID, MiktarGram) VALUES
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Yumurta (Orta Boy)'), 150),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Domates'), 150),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Yeşil Biber'), 60),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Kuru Soğan'), 40),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Zeytinyağı'), 15),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Tuz'), 3);
UPDATE Besinler SET ToplamAgirlikGram = 418 WHERE BesinID = @id;

-- Karnıyarık (4 porsiyon, ~1000g)
SET @id = (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Karnıyarık');
INSERT INTO TarifBilesenleri (TarifBesinID, BilesenBesinID, MiktarGram) VALUES
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Patlıcan'), 400),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Dana Kıyma (%10 Yağlı)'), 250),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Kuru Soğan'), 100),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Domates'), 100),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Yeşil Biber'), 60),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Domates Salçası'), 20),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Ayçiçek Yağı'), 40),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Tuz'), 5),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Karabiber'), 3);
UPDATE Besinler SET ToplamAgirlikGram = 978 WHERE BesinID = @id;

-- İmam Bayıldı (4 porsiyon, ~900g)
SET @id = (SELECT BesinID FROM Besinler WHERE BesinAdi = 'İmam Bayıldı');
INSERT INTO TarifBilesenleri (TarifBesinID, BilesenBesinID, MiktarGram) VALUES
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Patlıcan'), 400),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Kuru Soğan'), 150),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Domates'), 150),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Sarımsak'), 10),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Zeytinyağı'), 60),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Maydanoz'), 15),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Tuz'), 5),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Su'), 100);
UPDATE Besinler SET ToplamAgirlikGram = 890 WHERE BesinID = @id;

-- Kuru Fasulye Yemeği (4 porsiyon, ~1100g)
SET @id = (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Kuru Fasulye (Yemek)');
INSERT INTO TarifBilesenleri (TarifBesinID, BilesenBesinID, MiktarGram) VALUES
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Kuru Fasulye (Çiğ)'), 250),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Kuru Soğan'), 80),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Domates Salçası'), 30),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Biber Salçası'), 15),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Tereyağı'), 20),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Su'), 700),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Tuz'), 5);
UPDATE Besinler SET ToplamAgirlikGram = 1100 WHERE BesinID = @id;

-- Köfte Izgara (4 porsiyon, ~500g)
SET @id = (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Köfte (Izgara)');
INSERT INTO TarifBilesenleri (TarifBesinID, BilesenBesinID, MiktarGram) VALUES
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Dana Kıyma (%20 Yağlı)'), 400),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Kuru Soğan'), 50),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Galeta Unu'), 20),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Yumurta (Orta Boy)'), 50),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Maydanoz'), 10),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Tuz'), 5),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Karabiber'), 3),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Kimyon'), 2);
UPDATE Besinler SET ToplamAgirlikGram = 540 WHERE BesinID = @id;

-- Cacık (4 porsiyon, ~600g)
SET @id = (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Cacık');
INSERT INTO TarifBilesenleri (TarifBesinID, BilesenBesinID, MiktarGram) VALUES
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Yoğurt (Tam Yağlı)'), 400),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Salatalık'), 100),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Sarımsak'), 5),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Nane (Kuru)'), 3),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Zeytinyağı'), 10),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Su'), 80),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Tuz'), 3);
UPDATE Besinler SET ToplamAgirlikGram = 601 WHERE BesinID = @id;

-- Kısır (6 porsiyon, ~700g)
SET @id = (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Kısır');
INSERT INTO TarifBilesenleri (TarifBesinID, BilesenBesinID, MiktarGram) VALUES
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Bulgur (Çiğ)'), 200),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Domates'), 80),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Salatalık'), 60),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Kuru Soğan'), 50),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Maydanoz'), 30),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Domates Salçası'), 30),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Biber Salçası'), 20),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Zeytinyağı'), 30),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Limon Suyu'), 20),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Pul Biber'), 5),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Su'), 200);
UPDATE Besinler SET ToplamAgirlikGram = 725 WHERE BesinID = @id;

-- Mercimek Köftesi (6 porsiyon, ~650g)
SET @id = (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Mercimek Köftesi');
INSERT INTO TarifBilesenleri (TarifBesinID, BilesenBesinID, MiktarGram) VALUES
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Kırmızı Mercimek (Çiğ)'), 200),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Bulgur (Çiğ)'), 150),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Kuru Soğan'), 80),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Maydanoz'), 20),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Domates Salçası'), 20),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Biber Salçası'), 15),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Zeytinyağı'), 20),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Limon Suyu'), 15),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Tuz'), 4),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Pul Biber'), 3),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Su'), 150);
UPDATE Besinler SET ToplamAgirlikGram = 677 WHERE BesinID = @id;

-- Çiğ Köfte Etsiz (6 porsiyon, ~600g)
SET @id = (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Çiğ Köfte (Etsiz)');
INSERT INTO TarifBilesenleri (TarifBesinID, BilesenBesinID, MiktarGram) VALUES
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Bulgur (Çiğ)'), 250),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Kuru Soğan'), 80),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Domates Salçası'), 40),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Biber Salçası'), 30),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Zeytinyağı'), 20),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Limon Suyu'), 20),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Pul Biber'), 5),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Kimyon'), 3),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Tuz'), 4),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Su'), 150);
UPDATE Besinler SET ToplamAgirlikGram = 602 WHERE BesinID = @id;

-- Gözleme Peynirli (3 porsiyon, ~500g)
SET @id = (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Gözleme (Peynirli)');
INSERT INTO TarifBilesenleri (TarifBesinID, BilesenBesinID, MiktarGram) VALUES
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Beyaz Un'), 200),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Su'), 100),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Tuz'), 3),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Beyaz Peynir (Tam Yağlı)'), 150),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Maydanoz'), 10),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Tereyağı'), 25);
UPDATE Besinler SET ToplamAgirlikGram = 488 WHERE BesinID = @id;

-- Patlıcan Musakka (4 porsiyon, ~1000g)
SET @id = (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Patlıcan Musakka');
INSERT INTO TarifBilesenleri (TarifBesinID, BilesenBesinID, MiktarGram) VALUES
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Patlıcan'), 350),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Dana Kıyma (%10 Yağlı)'), 200),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Kuru Soğan'), 80),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Domates'), 100),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Yeşil Biber'), 50),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Domates Salçası'), 20),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Ayçiçek Yağı'), 30),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Su'), 150),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Tuz'), 5);
UPDATE Besinler SET ToplamAgirlikGram = 985 WHERE BesinID = @id;

-- Etli Nohut (4 porsiyon, ~1100g)
SET @id = (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Etli Nohut');
INSERT INTO TarifBilesenleri (TarifBesinID, BilesenBesinID, MiktarGram) VALUES
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Nohut (Çiğ)'), 250),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Dana Kuşbaşı'), 200),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Kuru Soğan'), 60),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Domates Salçası'), 25),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Tereyağı'), 20),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Su'), 550),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Tuz'), 5);
UPDATE Besinler SET ToplamAgirlikGram = 1110 WHERE BesinID = @id;

-- Domates Çorbası (4 porsiyon, ~900g)
SET @id = (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Domates Çorbası');
INSERT INTO TarifBilesenleri (TarifBesinID, BilesenBesinID, MiktarGram) VALUES
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Domates'), 300),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Beyaz Un'), 20),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Tereyağı'), 20),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Su'), 550),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Tuz'), 5),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Karabiber'), 2);
UPDATE Besinler SET ToplamAgirlikGram = 897 WHERE BesinID = @id;

-- Taze Fasulye Yemeği (4 porsiyon, ~900g)
SET @id = (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Taze Fasulye Yemeği');
INSERT INTO TarifBilesenleri (TarifBesinID, BilesenBesinID, MiktarGram) VALUES
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Taze Fasulye'), 400),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Kuru Soğan'), 60),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Domates'), 100),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Domates Salçası'), 15),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Zeytinyağı'), 30),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Su'), 300),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Tuz'), 4);
UPDATE Besinler SET ToplamAgirlikGram = 909 WHERE BesinID = @id;

-- Bezelye Yemeği (4 porsiyon, ~900g)
SET @id = (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Bezelye Yemeği');
INSERT INTO TarifBilesenleri (TarifBesinID, BilesenBesinID, MiktarGram) VALUES
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Bezelye (Taze)'), 350),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Kuru Soğan'), 60),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Havuç'), 80),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Patates'), 100),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Domates Salçası'), 15),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Zeytinyağı'), 20),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Su'), 300),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Tuz'), 4);
UPDATE Besinler SET ToplamAgirlikGram = 929 WHERE BesinID = @id;

-- Türlü Sebze (4 porsiyon, ~1000g)
SET @id = (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Türlü (Sebze)');
INSERT INTO TarifBilesenleri (TarifBesinID, BilesenBesinID, MiktarGram) VALUES
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Kabak'), 150),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Patlıcan'), 150),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Patates'), 100),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Yeşil Biber'), 60),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Domates'), 100),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Kuru Soğan'), 60),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Zeytinyağı'), 30),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Su'), 300),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Tuz'), 4);
UPDATE Besinler SET ToplamAgirlikGram = 954 WHERE BesinID = @id;

-- Piyaz (4 porsiyon, ~600g)
SET @id = (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Piyaz');
INSERT INTO TarifBilesenleri (TarifBesinID, BilesenBesinID, MiktarGram) VALUES
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Kuru Fasulye (Çiğ)'), 200),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Kuru Soğan'), 80),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Domates'), 80),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Maydanoz'), 15),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Yumurta (Orta Boy)'), 100),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Zeytinyağı'), 20),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Sirke (Elma)'), 15),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Tuz'), 4);
UPDATE Besinler SET ToplamAgirlikGram = 514 WHERE BesinID = @id;

-- Yayla Çorbası (4 porsiyon, ~900g)
SET @id = (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Yayla Çorbası');
INSERT INTO TarifBilesenleri (TarifBesinID, BilesenBesinID, MiktarGram) VALUES
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Yoğurt (Tam Yağlı)'), 200),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Beyaz Pirinç (Çiğ)'), 50),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Yumurta (Orta Boy)'), 50),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Beyaz Un'), 15),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Tereyağı'), 15),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Nane (Kuru)'), 3),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Su'), 600),
(@id, (SELECT BesinID FROM Besinler WHERE BesinAdi = 'Tuz'), 4);
UPDATE Besinler SET ToplamAgirlikGram = 937 WHERE BesinID = @id;
