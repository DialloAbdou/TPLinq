using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAppLinq.CollectionToCollection
{
    public static class Ope_Where
    {
        private static int[] entiers = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        /// <summary>
        /// Elle recupere les elements supérieurs du tableaux
        /// </summary>
        public static void getEntierSuperieur()
        {
            var supEntiers = entiers.Where(e => e > 3);
            foreach (var entier in supEntiers)
            {
                Console.WriteLine(entier);
            }
        }

        /// <summary>
        /// elle pârcourt les index du tableau impaire
        /// </summary>
        public static void getEntierIndexeImpaire()
        {
            // _ discard => car on utilise pas l'element au niveau memoire 
            var indexImpaire = entiers.Where((_, i) => i % 2 != 0).ToArray();

            foreach (var index in indexImpaire)
            {
                Console.WriteLine(index);
            }

        }

        /// <summary>
        /// elle renoie une liste des objets
        /// </summary>
        public static void getListeElmentObject()
        {
            var dates = new List<DateTime>()
            {
                DateTime.Today.AddDays(-2),
                DateTime.Today.AddDays(-1),
                DateTime.Today,
                DateTime.Today.AddDays(1),
                DateTime.Today.AddDays(2),
                DateTime.Today.AddDays(3),

            };

            var datetrie = dates.Where(d => d > DateTime.Today).ToArray();

            foreach (var date in datetrie)
            {
                Console.WriteLine(date);
            }
        }


    }
}
