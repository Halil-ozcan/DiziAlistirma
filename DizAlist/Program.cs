using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DizAlistirma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 1,2,3,4,5,6,7,8,9 };
            int toplam = 0;
            foreach (var item in sayilar)
            {
                toplam = toplam + item;

                Console.WriteLine("Sonuc : " + toplam);
            }
        }
    }
}
