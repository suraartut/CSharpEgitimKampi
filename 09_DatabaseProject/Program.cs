using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ado.net->C# dilinde SQL yapılarını kullanabilmemizi sağlayan çerçeve.
            Console.WriteLine("***** C# Veri Tabanlı Ürün-Kategori Bilgi Sistemi *****\n\n");
            Console.WriteLine("----------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4Çıkış Yap");
            Console.Write("Lütfen getirmek istediğiniz tablo numarasını giriniz: ");
            string tableNumber = Console.ReadLine();
            Console.WriteLine("----------------------------");

            // Bağlantıyı oluşturmak için (Sunucu adı;Veritabanı adı;güvenli bağlantı)
            SqlConnection connection = new SqlConnection("Data Source=ASUSFX505GD;initial Catalog=EgitimKampiDb;integrated security=true");
            connection.Open(); // Bağlantıyı açmak için
            SqlCommand command = new SqlCommand("Select * from TblCategory", connection); // Sorgu yazmak için
            SqlDataAdapter adapter = new SqlDataAdapter(command); // C# tarafındaki kodlar ile SQL sunucu arasında köprü
            DataTable dataTable = new DataTable(); //Verileri geçici belleğe almamı sağlayacak
            adapter.Fill(dataTable); // dataTable'ı adapter ile doldur (adapterın içinde sorgu (command) var)

            foreach (DataRow row in dataTable.Rows) // Gelen verileri ekranda göstermek için
            {
                foreach (var item in  row.ItemArray)
                {
                    Console.Write(item.ToString());
                }
                Console.WriteLine();
            }

            connection.Close(); // Bağlantıyı kapatmak için

            Console.Read();
        }
    }
}
