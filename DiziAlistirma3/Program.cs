using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiziAlistirma3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] kelime = { "Elma", "Armut", "Muz", "Kivi", "Çilek" };

            Console.WriteLine("Dizinin Ters Sırası");
            for(int i = kelime.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(kelime[i]);
            }
        }
    }
}
