using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiziAlistirma2
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            int[] sayilar = { 5, 12, 3, 7, 19 };

           
            int enKucuk = sayilar[0];
            int enBuyuk = sayilar[0];

           
            foreach (var sayi in sayilar)
            {
                if (sayi < enKucuk)
                {
                    enKucuk = sayi; 
                }

                if (sayi > enBuyuk)
                {
                    enBuyuk = sayi; 
                }
            }

            Console.WriteLine("Dizideki En Küçük Eleman: " + enKucuk);
            Console.WriteLine("Dizideki En Büyük Eleman: " + enBuyuk);
        }
    }
}
