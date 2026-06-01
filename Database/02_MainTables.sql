-- 1. KULLANICILAR TABLOSU
CREATE TABLE Kullanicilar (
    KullaniciID INT IDENTITY(1,1) PRIMARY KEY,
    Ad NVARCHAR(50) NOT NULL,
    Soyad NVARCHAR(50) NOT NULL,
    DogumTarihi DATE NOT NULL,
    Cinsiyet NCHAR(1) NOT NULL CHECK(Cinsiyet IN ('E','K')),
    Boy DECIMAL(5,2) NOT NULL,
    Kilo DECIMAL(5,2) NOT NULL,
    AktiviteSeviyesiID INT FOREIGN KEY REFERENCES AktiviteSeviyesi(AktiviteSeviyesiID),
    KiloHedefiID INT FOREIGN KEY REFERENCES KiloHedefi(KiloHedefiID),
    GunlukSuHedefiMl INT DEFAULT 2500,
    KayitTarihi DATETIME DEFAULT GETDATE()
);

-- 2. KİLO GEÇMİŞİ TABLOSU
CREATE TABLE KiloGecmisi (
    KiloGecmisiID INT IDENTITY(1,1) PRIMARY KEY,
    KullaniciID INT FOREIGN KEY REFERENCES Kullanicilar(KullaniciID) NOT NULL,
    Kilo DECIMAL(5,2) NOT NULL,
    OlcumTarihi DATE NOT NULL
);

-- 3. BESİNLER TABLOSU (PROJENİN KALBİ - TARİF MOTORU DESTEKLİ)
CREATE TABLE Besinler (
    BesinID INT IDENTITY(1,1) PRIMARY KEY,
    BesinAdi NVARCHAR(100) NOT NULL,
    KategoriID INT FOREIGN KEY REFERENCES BesinKategorileri(KategoriID),
    
    -- Değerler standart olarak 100g baz alınarak tutulur
    KaloriPer100g DECIMAL(7,2) NOT NULL,
    ProteinPer100g DECIMAL(6,2) NOT NULL,
    KarbonhidratPer100g DECIMAL(6,2) NOT NULL,
    YagPer100g DECIMAL(6,2) NOT NULL,
    
    -- Tarif Motoru İçin Gerekli Alanlar
    BilesikMi BIT DEFAULT 0, -- 0 ise basit besin (örn: un), 1 ise tarif (örn: krep)
    ToplamAgirlikGram DECIMAL(7,1) NULL, -- Sadece tariflerde dolu olur
    PorsiyonSayisi INT NULL, -- Sadece tariflerde dolu olur
    OlusturanKullaniciID INT FOREIGN KEY REFERENCES Kullanicilar(KullaniciID) NULL, -- NULL ise sistemin varsayılan besinidir
    
    VarsayilanPorsiyonGram DECIMAL(6,1) DEFAULT 100
);
