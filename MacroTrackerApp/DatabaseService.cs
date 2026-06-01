using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;

namespace MacroTrackerApp
{
    public class DatabaseService
    {
        private readonly string connectionString;

        public DatabaseService()
        {
            connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=projedb;Trusted_Connection=True;TrustServerCertificate=True;";
        }

        private SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        public DataTable GetAllUsers()
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                string sql = @"SELECT u.KullaniciID, u.Ad, u.Soyad, u.Kilo, u.Boy,
                               DATEDIFF(YEAR, u.DogumTarihi, GETDATE()) AS Yas,
                               u.Cinsiyet, a.SeviyeAdi, a.Carpan, h.HedefAdi, h.GunlukKaloriAcigi,
                               u.GunlukSuHedefiMl
                               FROM Kullanicilar u
                               INNER JOIN AktiviteSeviyesi a ON u.AktiviteSeviyesiID = a.AktiviteSeviyesiID
                               INNER JOIN KiloHedefi h ON u.KiloHedefiID = h.KiloHedefiID";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public int CreateUser(string ad, string soyad, DateTime dogumTarihi, char cinsiyet,
                              decimal boy, decimal kilo, int aktiviteID, int hedefID)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                string sql = @"INSERT INTO Kullanicilar (Ad, Soyad, DogumTarihi, Cinsiyet, Boy, Kilo, AktiviteSeviyesiID, KiloHedefiID)
                               OUTPUT INSERTED.KullaniciID
                               VALUES (@Ad, @Soyad, @Dogum, @Cinsiyet, @Boy, @Kilo, @Aktivite, @Hedef)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Ad", ad);
                cmd.Parameters.AddWithValue("@Soyad", soyad);
                cmd.Parameters.AddWithValue("@Dogum", dogumTarihi);
                cmd.Parameters.AddWithValue("@Cinsiyet", cinsiyet.ToString());
                cmd.Parameters.AddWithValue("@Boy", boy);
                cmd.Parameters.AddWithValue("@Kilo", kilo);
                cmd.Parameters.AddWithValue("@Aktivite", aktiviteID);
                cmd.Parameters.AddWithValue("@Hedef", hedefID);
                return (int)cmd.ExecuteScalar();
            }
        }

        public DataTable SearchFoods(string keyword)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                string sql = @"SELECT b.BesinID, b.BesinAdi, k.KategoriAdi,
                               b.KaloriPer100g, b.ProteinPer100g, b.KarbonhidratPer100g, b.YagPer100g,
                               b.VarsayilanPorsiyonGram
                               FROM Besinler b
                               INNER JOIN BesinKategorileri k ON b.KategoriID = k.KategoriID
                               WHERE b.BesinAdi LIKE @keyword
                               ORDER BY b.BesinAdi";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public DataTable GetFoodsByCategory(string kategori)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                string sql = @"SELECT b.BesinID, b.BesinAdi, b.KaloriPer100g, b.ProteinPer100g,
                               b.KarbonhidratPer100g, b.YagPer100g, b.VarsayilanPorsiyonGram
                               FROM Besinler b
                               INNER JOIN BesinKategorileri k ON b.KategoriID = k.KategoriID
                               WHERE k.KategoriAdi = @kat
                               ORDER BY b.BesinAdi";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@kat", kategori);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public DataTable GetCategories()
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT KategoriAdi FROM BesinKategorileri ORDER BY KategoriID", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public void AddConsumption(int kullaniciID, int besinID, int ogunID, decimal miktarGram, DateTime tarih)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                string sql = @"INSERT INTO GunlukTuketim (KullaniciID, BesinID, OgunID, MiktarGram, TuketimTarihi)
                               VALUES (@uid, @bid, @oid, @miktar, @tarih)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@uid", kullaniciID);
                cmd.Parameters.AddWithValue("@bid", besinID);
                cmd.Parameters.AddWithValue("@oid", ogunID);
                cmd.Parameters.AddWithValue("@miktar", miktarGram);
                cmd.Parameters.AddWithValue("@tarih", tarih.Date);
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable GetDailyConsumption(int kullaniciID, DateTime tarih)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                string sql = @"SELECT gt.TuketimID, o.OgunAdi, b.BesinAdi, gt.MiktarGram,
                               ROUND((gt.MiktarGram / 100.0) * b.KaloriPer100g, 1) AS Kalori,
                               ROUND((gt.MiktarGram / 100.0) * b.ProteinPer100g, 1) AS Protein,
                               ROUND((gt.MiktarGram / 100.0) * b.KarbonhidratPer100g, 1) AS Karbonhidrat,
                               ROUND((gt.MiktarGram / 100.0) * b.YagPer100g, 1) AS Yag
                               FROM GunlukTuketim gt
                               INNER JOIN Besinler b ON gt.BesinID = b.BesinID
                               INNER JOIN Ogunler o ON gt.OgunID = o.OgunID
                               WHERE gt.KullaniciID = @uid AND gt.TuketimTarihi = @tarih
                               ORDER BY o.SiraNo";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@uid", kullaniciID);
                cmd.Parameters.AddWithValue("@tarih", tarih.Date);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public DataTable GetDailySummary(int kullaniciID, DateTime tarih)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                string sql = @"SELECT 
                               ISNULL(ROUND(SUM((gt.MiktarGram / 100.0) * b.KaloriPer100g), 0), 0) AS ToplamKalori,
                               ISNULL(ROUND(SUM((gt.MiktarGram / 100.0) * b.ProteinPer100g), 1), 0) AS ToplamProtein,
                               ISNULL(ROUND(SUM((gt.MiktarGram / 100.0) * b.KarbonhidratPer100g), 1), 0) AS ToplamKarbonhidrat,
                               ISNULL(ROUND(SUM((gt.MiktarGram / 100.0) * b.YagPer100g), 1), 0) AS ToplamYag
                               FROM GunlukTuketim gt
                               INNER JOIN Besinler b ON gt.BesinID = b.BesinID
                               WHERE gt.KullaniciID = @uid AND gt.TuketimTarihi = @tarih";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@uid", kullaniciID);
                cmd.Parameters.AddWithValue("@tarih", tarih.Date);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public void DeleteConsumption(int tuketimID)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM GunlukTuketim WHERE TuketimID = @id", conn);
                cmd.Parameters.AddWithValue("@id", tuketimID);
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable GetBaseIngredients(string keyword)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                string sql = @"SELECT b.BesinID, b.BesinAdi, k.KategoriAdi,
                               b.KaloriPer100g, b.ProteinPer100g, b.KarbonhidratPer100g, b.YagPer100g
                               FROM Besinler b
                               INNER JOIN BesinKategorileri k ON b.KategoriID = k.KategoriID
                               WHERE b.BilesikMi = 0 AND b.BesinAdi LIKE @kw
                               ORDER BY b.BesinAdi";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@kw", "%" + keyword + "%");
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public DataTable FindRecipesByIngredients(List<int> ingredientIDs, List<string> ingredientNames)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                string idList = string.Join(",", ingredientIDs);

                string nameConditions = "";
                var parameters = new List<SqlParameter>();
                for (int i = 0; i < ingredientNames.Count; i++)
                {
                    nameConditions += $" OR b.BesinAdi LIKE @n{i}";
                    parameters.Add(new SqlParameter($"@n{i}", "%" + ingredientNames[i] + "%"));
                }

                string sql = $@"SELECT b.BesinID, b.BesinAdi AS TarifAdi, b.KaloriPer100g AS Kalori,
                               b.ProteinPer100g AS Protein, b.KarbonhidratPer100g AS Karb, b.YagPer100g AS Yag,
                               ISNULL(matched.EslesenMalzeme, 0) AS EslesenMalzeme,
                               (SELECT COUNT(*) FROM TarifBilesenleri t2 WHERE t2.TarifBesinID = b.BesinID) AS ToplamMalzeme
                               FROM Besinler b
                               LEFT JOIN (
                                   SELECT TarifBesinID, COUNT(DISTINCT BilesenBesinID) AS EslesenMalzeme
                                   FROM TarifBilesenleri
                                   WHERE BilesenBesinID IN ({idList})
                                   GROUP BY TarifBesinID
                               ) matched ON b.BesinID = matched.TarifBesinID
                               WHERE b.BilesikMi = 1 AND (matched.EslesenMalzeme > 0 {nameConditions})
                               ORDER BY ISNULL(matched.EslesenMalzeme, 0) DESC, b.BesinAdi";

                SqlCommand cmd = new SqlCommand(sql, conn);
                foreach (var p in parameters) cmd.Parameters.Add(p);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public DataTable SearchRecipesByName(string keyword)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                string sql = @"SELECT b.BesinID, b.BesinAdi AS TarifAdi, b.KaloriPer100g AS Kalori,
                               b.ProteinPer100g AS Protein, b.KarbonhidratPer100g AS Karb, b.YagPer100g AS Yag,
                               (SELECT COUNT(*) FROM TarifBilesenleri t WHERE t.TarifBesinID = b.BesinID) AS MalzemeSayisi
                               FROM Besinler b
                               WHERE b.BilesikMi = 1 AND b.BesinAdi LIKE @kw
                               ORDER BY b.BesinAdi";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@kw", "%" + keyword + "%");
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public (string Name, string Instructions, string Ingredients, decimal Kalori, decimal Protein, decimal Karb, decimal Yag) GetRecipeDetails(int besinID)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                string sql = @"SELECT BesinAdi, ISNULL(HazirlamaTalimati, '') AS HazirlamaTalimati,
                               KaloriPer100g, ProteinPer100g, KarbonhidratPer100g, YagPer100g
                               FROM Besinler WHERE BesinID = @id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", besinID);
                var reader = cmd.ExecuteReader();
                string name = "", instructions = "";
                decimal kal = 0, pro = 0, kar = 0, yag = 0;
                if (reader.Read())
                {
                    name = reader.GetString(0);
                    instructions = reader.GetString(1);
                    kal = reader.GetDecimal(2);
                    pro = reader.GetDecimal(3);
                    kar = reader.GetDecimal(4);
                    yag = reader.GetDecimal(5);
                }
                reader.Close();

                string sqlIng = @"SELECT b.BesinAdi, tb.MiktarGram
                                  FROM TarifBilesenleri tb
                                  INNER JOIN Besinler b ON tb.BilesenBesinID = b.BesinID
                                  WHERE tb.TarifBesinID = @id
                                  ORDER BY b.BesinAdi";
                SqlCommand cmd2 = new SqlCommand(sqlIng, conn);
                cmd2.Parameters.AddWithValue("@id", besinID);
                var reader2 = cmd2.ExecuteReader();
                var ingredients = new System.Text.StringBuilder();
                while (reader2.Read())
                {
                    ingredients.AppendLine($"  - {reader2.GetString(0)}: {reader2.GetDecimal(1):F0}g");
                }
                reader2.Close();

                return (name, instructions, ingredients.ToString(), kal, pro, kar, yag);
            }
        }

        public int CreateRecipe(string name, int kategoriID, decimal kalori, decimal protein,
                                decimal karb, decimal yag, decimal toplamGram, int kullaniciID)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                string sql = @"INSERT INTO Besinler (BesinAdi, KategoriID, KaloriPer100g, ProteinPer100g,
                               KarbonhidratPer100g, YagPer100g, BilesikMi, ToplamAgirlikGram,
                               OlusturanKullaniciID, VarsayilanPorsiyonGram)
                               OUTPUT INSERTED.BesinID
                               VALUES (@ad, @kat, @kal, @pro, @kar, @yag, 1, @gram, @uid, @gram)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ad", name);
                cmd.Parameters.AddWithValue("@kat", kategoriID);
                cmd.Parameters.AddWithValue("@kal", kalori);
                cmd.Parameters.AddWithValue("@pro", protein);
                cmd.Parameters.AddWithValue("@kar", karb);
                cmd.Parameters.AddWithValue("@yag", yag);
                cmd.Parameters.AddWithValue("@gram", toplamGram);
                cmd.Parameters.AddWithValue("@uid", kullaniciID);
                return (int)cmd.ExecuteScalar();
            }
        }

        public void AddRecipeIngredient(int recipeID, int ingredientID, decimal gram)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                string sql = "INSERT INTO TarifBilesenleri (TarifBesinID, BilesenBesinID, MiktarGram) VALUES (@rid, @bid, @g)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@rid", recipeID);
                cmd.Parameters.AddWithValue("@bid", ingredientID);
                cmd.Parameters.AddWithValue("@g", gram);
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateRecipeInstructions(int besinID, string instructions)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                string sql = "UPDATE Besinler SET HazirlamaTalimati = @talimat WHERE BesinID = @id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@talimat", instructions);
                cmd.Parameters.AddWithValue("@id", besinID);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
