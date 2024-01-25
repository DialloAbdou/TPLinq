using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAppLinq.CollectionToCollection
{
    public class ArticleJoin
    {
        public int Id { get; set; }
        public string Titre { get; set; } = string.Empty;
        public int CategorieId { get; set; }
    }
    public class Categorie
    {
        public int Id { get; set; }
        public string Titre { get; set; }

    }
    public class Ope_Join
    {
        // Initialisation de deux tableau pour utiliser les joins
        public static void MethodJoin()
        {

            var articles = new ArticleJoin[3]
            {
                new ArticleJoin { Id = 1, Titre = "Marteau", CategorieId = 1 },
                new ArticleJoin { Id = 2, Titre = "Tournevis", CategorieId = 1 },
                new ArticleJoin { Id = 3, Titre = "Manteau", CategorieId = 2 },
            };
            var categories = new Categorie[2]
            {
                 new Categorie{ Id = 1 , Titre = "Outils"},
                 new Categorie{ Id = 2 , Titre = "Vêtement"},

            };
            var articlesCategories = articles.Join(categories, a => a.CategorieId, c => c.Id, (article, categorie) => new { article, categorie });

            foreach (var item in articlesCategories)
            {
                Console.WriteLine($"Article {item.article.Titre}, dans la Categorie {item.categorie.Titre}");
            }
        }


    }
}
