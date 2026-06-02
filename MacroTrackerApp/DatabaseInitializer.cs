using System;
using System.IO;
using System.Text;
using Microsoft.Data.SqlClient;

namespace MacroTrackerApp
{
    public static class DatabaseInitializer
    {
        public static void EnsureDatabaseExists()
        {
            string sqlPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "projedb.sql");
            if (!File.Exists(sqlPath))
            {
                System.Windows.Forms.MessageBox.Show(
                    "Hata: 'projedb.sql' dosyası bulunamadı!\n\n" +
                    "Lütfen sıkıştırılmış ZIP dosyasını tamamen bir klasöre ayıkladığınızdan emin olun. " +
                    "Arşiv dosyasının içerisindeki çalıştırılabilir dosyayı doğrudan çalıştırmak bu hataya sebep olur.",
                    "Dosya Eksik",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error
                );
                Environment.Exit(0);
                return;
            }

            string masterConnStr = "Server=(localdb)\\MSSQLLocalDB;Database=master;Trusted_Connection=True;TrustServerCertificate=True;";

            try
            {
                bool dbExists = false;
                using (var conn = new SqlConnection(masterConnStr))
                {
                    try
                    {
                        conn.Open();
                    }
                    catch (SqlException ex)
                    {
                        System.Windows.Forms.MessageBox.Show(
                            "SQL Server LocalDB sunucusuna bağlanılamadı!\n\n" +
                            "Bu uygulamanın çalışabilmesi için sistemde SQL Server LocalDB servisinin kurulu ve çalışır durumda olması gerekmektedir.\n\n" +
                            "Hata Detayı: " + ex.Message,
                            "Veritabanı Bağlantı Hatası",
                            System.Windows.Forms.MessageBoxButtons.OK,
                            System.Windows.Forms.MessageBoxIcon.Error
                        );
                        Environment.Exit(0);
                        return;
                    }

                    string checkSql = "SELECT database_id FROM sys.databases WHERE name = 'projedb'";
                    using (var cmd = new SqlCommand(checkSql, conn))
                    {
                        var result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            dbExists = true;
                        }
                    }
                }

                if (!dbExists)
                {
                    using (var conn = new SqlConnection(masterConnStr))
                    {
                        conn.Open();
                        using (var reader = new StreamReader(sqlPath, true))
                        {
                            var sb = new StringBuilder();
                            string? line;
                            while ((line = reader.ReadLine()) != null)
                            {
                                string trimmed = line.Trim();
                                if (trimmed.Equals("GO", StringComparison.OrdinalIgnoreCase))
                                {
                                    string query = sb.ToString().Trim();
                                    if (!string.IsNullOrEmpty(query))
                                    {
                                        using (var cmd = new SqlCommand(query, conn))
                                        {
                                            cmd.ExecuteNonQuery();
                                        }
                                    }
                                    sb.Clear();
                                }
                                else
                                {
                                    sb.AppendLine(line);
                                }
                            }

                            string finalQuery = sb.ToString().Trim();
                            if (!string.IsNullOrEmpty(finalQuery))
                            {
                                using (var cmd = new SqlCommand(finalQuery, conn))
                                {
                                    cmd.ExecuteNonQuery();
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(
                    "Veritabanı otomatik yapılandırılırken bir hata oluştu:\n\n" + ex.Message,
                    "Yapılandırma Hatası",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Warning
                );
            }
        }
    }
}
