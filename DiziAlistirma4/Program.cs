using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiziAlistirma4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] notlar = { 60, 70, 80, 90, 100 };

            int ortalama = 0;
            int toplam = 0;

            foreach(var item in notlar)
            {
                toplam = toplam + item;

                ortalama = toplam / notlar.Length;

                
            }
            Console.WriteLine("Not Ortalaması : " + ortalama);
            Console.WriteLine(" ------------------------------------------------------- ");

            foreach(var item in notlar)
            {
                if(item < ortalama)
                {
                    Console.WriteLine("Ortalama altında kalan Notlar : " + item);
                }
            }


        }
    }
}
