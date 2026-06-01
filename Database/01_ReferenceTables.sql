-- 1. AKTİVİTE SEVİYESİ TABLOSU
-- Kullanıcıların günlük hareket düzeyini ve TDEE hesaplamasındaki çarpanını tutar.
CREATE TABLE AktiviteSeviyesi (
    AktiviteSeviyesiID INT PRIMARY KEY,
    SeviyeAdi NVARCHAR(50) NOT NULL,
    Aciklama NVARCHAR(200),
    Carpan DECIMAL(4,2) NOT NULL
);

-- 2. KİLO HEDEFİ TABLOSU
-- Kullanıcının zayıflama/kilo alma hedefini ve bunun günlük kaloriye etkisini tutar.
CREATE TABLE KiloHedefi (
    KiloHedefiID INT PRIMARY KEY,
    HedefAdi NVARCHAR(50) NOT NULL,
    HaftalikDegisimKg DECIMAL(3,2) NOT NULL,
    GunlukKaloriAcigi INT NOT NULL
);

-- 3. BESİN KATEGORİLERİ TABLOSU
-- Sistemdeki besinleri gruplamak için kullanılır (Süt Ürünleri, Et, Sebze vb.)
CREATE TABLE BesinKategorileri (
    KategoriID INT IDENTITY(1,1) PRIMARY KEY,
    KategoriAdi NVARCHAR(50) NOT NULL UNIQUE
);

-- 4. ÖĞÜNLER TABLOSU
-- Gün içindeki öğün isimlerini ve sıralarını sabit olarak tutar.
CREATE TABLE Ogunler (
    OgunID INT PRIMARY KEY,
    OgunAdi NVARCHAR(30) NOT NULL UNIQUE,
    SiraNo INT NOT NULL
);
