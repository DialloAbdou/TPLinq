using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAppLinq.CollectionToCollection
{
    public static class Ope_Where
    {
        public static void Methode()
        {
            int[] entiers = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var supEntier = entiers.Where(supTree);
            //var supEntier = entiers.Where(e => e > 3);
            //var supEntier = entiers.Where((_, index) => _ % 2 == 0);

            //foreach ( var entier in supEntier)
            //{
            //    Console.WriteLine(entier);
            //}
            var dates = new DateTime[]
            {
                DateTime.Today.AddDays(-1),
                DateTime.Today,
                DateTime.Today.AddDays(1),
                DateTime.Today.AddDays(2),
                DateTime.Today.AddDays(3),
            };
            var dateTree = dates.Where(d => d >= DateTime.Today);

            foreach (var item in dateTree)
            {
                Console.WriteLine(item);
            }
        }
        private static bool supTree(int valeur)
        {
            return valeur > 3;
        }


    }
}
