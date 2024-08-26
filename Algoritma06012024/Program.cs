using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritma06012024
{
    internal class Program
    {
        // Algorithm of the function that finds the largest number in the set of numbers as a array!!
        static void Main(string[] mehmetler)
        {
            int[] sayilar = { 1, 5, 80, 62, 92, 54, 3 };
            Console.WriteLine( maxSayiyiBul(sayilar));
            Console.ReadKey();
        }

        static int maxSayiyiBul(int[] sayilar)
        {
           int  maxSayi = 0;
            for(int i=0; i<sayilar.Length; i++)
            {
                if (sayilar[i] > maxSayi)
                    maxSayi = sayilar[i];
                else
                    continue;
            }
            return maxSayi;
        }
    }
}
