using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DizAlistirma2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayi = { 5, 12, 3, 7, 19 };

            int enkucuk = sayi[0];
            int enbuyuk = sayi[0];

            foreach (var item in sayi)
            {
                if(item < enkucuk)
                {
                    enkucuk = item;
                }
                if(item > enbuyuk)
                {
                    enbuyuk = item;
                }
            }

            Console.WriteLine("Dizideki En Kucuk Sayi : " + enkucuk);
            Console.WriteLine("Dizideki En Buyuk Sayi : " + enbuyuk);
        }
    }
}
