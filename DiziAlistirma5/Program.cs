using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiziAlistirma5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] urun = { "Ekmek", "Süt", "Yumurta", "Peynir", "Gazete", "Zeytin" };
            double[] urunFiyat = { 10.0, 25.0, 40.0, 15.0, 12.0, 20.0 };

            Console.WriteLine("Ürün Fiyat Listesi:");
            for (int i = 0; i < urun.Length; i++)
            {
                Console.WriteLine($"{urun[i]} - {urunFiyat[i]}S");
            }
        }
    }
}
