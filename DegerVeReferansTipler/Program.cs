using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 = 30 olarak kalır.
            //değer tip

            int[] sayilar1 = { 10, 20, 30 };
            int[] sayilar2 = { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1 = 999 olur.
            // ref tip
            // new -> bellekte bir adres olustur

            // int, decimal, bool, float, double ==> değer tip
            // array, class, interface ==> referans tip
        }
    }
}
