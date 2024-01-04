using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAppLinq.CollectionToCollection
{
    public class Ope_Distinct
    {
        public class Materiau : IEqualityComparer<Materiau>
        {
            public string Nom { get; set; }

            public bool Equals(Materiau? x, Materiau? y)
            {
                return (x?.Nom == y?.Nom);
            }

            public int GetHashCode([DisallowNull] Materiau obj)
            {
                return obj.Nom.GetHashCode();
            }
        }
        public static void methodeDistinct()
        {
            List<Materiau> materiaux= new List<Materiau>()
            {
              new Materiau{ Nom ="Marteau"},
              new Materiau{ Nom ="Bourrin"},
              new Materiau{ Nom ="Scie"},
              new Materiau{ Nom ="Marteau"},

            };

            //int[] entiers = new int[10] { 1, 2, 3, 4, 5, 1, 2, 6, 7, 8 };

            //var entierDistinct = entiers.Distinct();
            //foreach (var entier in entierDistinct)
            //{
            //    Console.WriteLine($"{entier}");
            //}

            var materieauDisct = materiaux.Distinct(new Materiau()) ;
            foreach (var m in materieauDisct)
            {
                Console.WriteLine($"{m.Nom}");
            }

        }
    }
}
