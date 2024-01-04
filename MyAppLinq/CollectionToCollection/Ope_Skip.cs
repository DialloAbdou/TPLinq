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
            
            Console.WriteLine("utilisation Skip ");
            foreach (int entier in entierSkip)
            {
                Console.WriteLine(entier);
            }
            var entierLastSkip = entiers.SkipLast(2);
           
            Console.WriteLine("utilisation LastSkip ");

            foreach (int entier in entierLastSkip)
            {
                Console.WriteLine(entier);
            }

            var entierSkipWhile = entiers.SkipWhile(e => e < 4);

            Console.WriteLine("utilisation SkipWhile ");

            foreach (var item in entierSkipWhile)
            {
                Console.WriteLine(item);
            }

        }
    }
}
