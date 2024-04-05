using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAppLinq.CollectionToCollection
{
    internal class Ope_Skip
    {
        public static void MehtodeSkip()
        {
            int[] entiers = new int[10] { 1, 2, 3, 4, 5, 1, 2, 6, 7, 8};
            
            var entierSkip = entiers.Skip(2);
            
            Console.WriteLine("utilisation Skip 2 => Commence 2 element du tableau ");
            foreach (int entier in entierSkip)
            {
                Console.WriteLine(entier);
            }
            //var entierLastSkip = entiers.SkipLast(2);

            //Console.WriteLine("utilisation LastSkip 2 recupere tout sauf les deux derniers du tableau ");

            //foreach (int entier in entierLastSkip)
            //{
            //    Console.WriteLine(entier);
            //}

            //var entierSkipWhile = entiers.SkipWhile(e => e < 4);

            //Console.WriteLine("utilisation SkipWhile < 4 il commence à partir des element qui est supérieur  4 ");

            //foreach (var item in entierSkipWhile)
            //{
            //    Console.WriteLine(item);
            //}

            //var entierSkipWhileandlast = entiers.SkipWhile(e => e < 4).SkipLast(2);

            //Console.WriteLine("utilisation SkipWhile < 4 il commence à partir des element qui est supérieur  4 et limiter avant derniers elements ");

            //foreach (var item in entierSkipWhileandlast)
            //{
            //    Console.WriteLine(item);
            //}

        }
    }
}
