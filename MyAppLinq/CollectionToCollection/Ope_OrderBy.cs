using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAppLinq.CollectionToCollection
{
    public class Ope_OrderBy
    {
       
        public static void getOperOrderBy()
        {
            int[] entiers = new int[8] { 2, 1, 8, 7, 5, 3, 4, 6 };

            var orderByEntier = entiers.OrderBy(e => e);
            Console.WriteLine("==Par Ordre de Croissante===");
            foreach (var entier in orderByEntier)
            {
                Console.WriteLine(entier.ToString());
            }

        }
        public static void getOperOrderByDescending()
        {
            int[] entiers = new int[8] { 2, 1, 8, 7, 5, 3, 4, 6 };
            var entierOrderByDesc = entiers.OrderByDescending(e=> e);
            Console.WriteLine("==Par Ordre DeCroissante===");
            foreach (var ent in entierOrderByDesc)
            {
                Console.WriteLine(ent);
            }

        }
    }
}
