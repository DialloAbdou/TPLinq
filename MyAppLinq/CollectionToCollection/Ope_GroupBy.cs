using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAppLinq.CollectionToCollection
{
    public class Article
    {
        public int Id { get; set; }
        public string Titre { get; set; } = string.Empty;

        public int CategoryId { get; set; }
    }
    public class Ope_GroupBy
    {
        public static void methodeGroupBy()
        {
            var listeArticles = new List<Article>()
            {
                new Article {Id = 1, Titre ="Marteau", CategoryId= 1},
                new Article {Id = 2, Titre ="Ciseau", CategoryId= 1},
                new Article {Id = 1, Titre ="Couteau", CategoryId= 1},
                new Article {Id = 1, Titre ="Livre", CategoryId= 2},
                new Article {Id = 1, Titre ="ordianateur", CategoryId= 2},
            };

            var listeGrps = listeArticles.GroupBy(p => p.CategoryId);

            foreach (var items in listeGrps)
            {
                Console.WriteLine(items.Key);
                foreach (var item in items)
                {
                    Console.WriteLine(item.Titre);
                }
            }

        }
    }
}
