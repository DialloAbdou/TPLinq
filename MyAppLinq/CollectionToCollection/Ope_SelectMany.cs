using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAppLinq.CollectionToCollection
{
    public class SacDEntier
    {
        public List<int> Entiers { get; set; }
    }
    public class SacElement
    {
        public List<int> Entiers { get; set; }
        public List<DateTime> Dates { get; set; }
    }
    public static class Ope_SelectMany
    {
        /// <summary>
        /// Cette fonction permet de mettre les entiers à plats
        /// </summary>
        public static void methodeSelectManyEntier()
        {
            SacDEntier[] sacs = new SacDEntier[3]
            {
            new SacDEntier { Entiers = new List<int>{1,2,3,4,5}},
            new SacDEntier { Entiers = new List<int>{6,7,8,9,10}},
            new SacDEntier { Entiers = new List<int>{11,12,13,14,15}}
            };
            // Mettre ses entiers à plats
            var mesEntiers = sacs.SelectMany(e => e.Entiers);

            foreach (int i in mesEntiers)
            {
                Console.WriteLine(i);
            }
        }

        public static void methodeSelectManyDate()
        {
            SacElement[] sacElements = new SacElement[3]
            {
                new SacElement
                {
                  Entiers = new List<int>{1,2,3},
                  Dates = new List<DateTime>
                   {
                     DateTime.Today.AddDays(-3),
                     DateTime.Today.AddDays(-2),
                     DateTime.Today.AddDays(-1),
                  }
                },

                new SacElement
                {
                  Entiers = new List<int>{4,5,6},
                  Dates = new List<DateTime>
                  {
                     DateTime.Today

                  }
                },

                new SacElement
                {
                  Entiers = new List<int>{7,8,9},
                  Dates = new List<DateTime>
                   {
                     DateTime.Today.AddDays(1),
                     DateTime.Today.AddDays(2),
                     DateTime.Today.AddDays(3),
                  }
                }

            };

            // mettre des elements à plats

            var elements = sacElements.SelectMany(d => d.Dates, (e, d) => d.Day);

            foreach (var e in elements)
            {
                Console.WriteLine(e);
            }
        }
    }
}
