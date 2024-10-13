using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230805_For_Ornek7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ornek 7
            //Çarpım Tablosu oluşturalım

            for (int sayi1 = 1; sayi1 <= 10; sayi1++)
            {
                Console.WriteLine(sayi1 + " Çarpım Tablosu");
                Console.WriteLine("------------------");

                for (int sayi2 = 1; sayi2 <= 10; sayi2++)
                {
                    int carpimSonucu = sayi1 * sayi2;
                    Console.WriteLine("{0} X {1} = {2}", sayi1, sayi2, carpimSonucu);
                    //Console.WriteLine(sayi1 + " X "+ sayi2+ " = "+carpimSonucu);
                }

                Console.WriteLine(" ------------------- ");
            }
            Console.ReadKey();
        }
    }
}
