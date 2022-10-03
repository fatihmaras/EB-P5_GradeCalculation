using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade
{
    internal class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("Lütfen 1.notunuzu giriniz");
            int birinci_not = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen 2.notunuzu giriniz");
            int ikinci_not = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen 3.notunuzu giriniz");
            int ucuncu_not = Convert.ToInt32(Console.ReadLine());


            if (birinci_not <= 100 && birinci_not >= 0 && ikinci_not <= 100 && ikinci_not >= 0 && ucuncu_not <= 100 && ucuncu_not >= 0)
            {
                int Sonuc = (birinci_not + ikinci_not + ucuncu_not) / 3;

                if (Sonuc >= 80 && Sonuc < 100)
                {
                    Console.WriteLine("Not Degeriniz:A+");
                }


                else if (Sonuc >= 60 && Sonuc < 80)
                {
                    Console.WriteLine("Not Değeriniz:A");
                }
                else if (Sonuc >= 40 && Sonuc < 60)
                {
                    Console.WriteLine("Not Değeriniz: B+");
                }

                else if (Sonuc < 40)
                {

                    Console.WriteLine("Not Değeriniz :F");
                }
            }
            else
            {
                Console.WriteLine(" Geçersiz Not girdiniz kontrol ediniz");
            }

            Console.ReadLine();

        }
    }
}


