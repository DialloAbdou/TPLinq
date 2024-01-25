using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAppLinq.CollectionToCollection
{
    public class Ope_Chunk
    {
        public static void Methode_Chunk()
        {
            List<Article>? listeArticles = new List<Article>()
            {
                new Article {Id = 1, Titre ="Marteau", CategoryId= 1},
                new Article {Id = 2, Titre ="Ciseau", CategoryId= 1},
                new Article {Id = 1, Titre ="Couteau", CategoryId= 1},
                new Article {Id = 1, Titre ="Livre", CategoryId= 2},
                new Article {Id = 1, Titre ="ordianateur", CategoryId= 2},
            };

            IEnumerable<Article[]>? paquetsDArticles = listeArticles.Chunk(2);

            foreach (var tabArticles in paquetsDArticles)
            {
                Console.WriteLine($"il y'a {tabArticles.Length} articles dans le paquets");
                foreach (var art in tabArticles)
                {
                    Console.WriteLine(art.Titre);
                }
            }
        }
    }
}
