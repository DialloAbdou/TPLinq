namespace MyAppLinq.CollectionToCollection
{
    public class Ope_Take
    {
        private static int[] entiers = new int[10] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        public static void mesthodesTake()
        {
            IEnumerable<int>? mesFavoris = entiers.Take(5);
            Console.WriteLine(" elle recupere les 5 elements de la liste Take(5)");
            foreach (var item in mesFavoris)
            {
                Console.WriteLine(item);
            }

            var sousEnsemble = entiers.Take(2..5);

            Console.WriteLine("=== Recuperer des Elements dans un interval données à l'interval [2,5] : Take(2...5)==");

            foreach (var item in sousEnsemble)
            {
                Console.WriteLine(item);
            }

            //var mesTakeLast = entiers.TakeLast(3);

            //Console.WriteLine("Les 3 derniers Elements TakeLast");

            //foreach (var item in mesTakeLast)
            //{
            //    Console.WriteLine(item);
            //}

            ///*
            // * *
            // * TakeWhile permet de recuperer les élmement tantque le prédicat est vrai
            // */
            //var mesTakeWhile = entiers.TakeWhile(e => e<=5);

            //Console.WriteLine("Utilisation de TakeWhile");

            //foreach (var item in mesTakeWhile)
            //{
            //    Console.WriteLine(item);
            //}
        }

    }
}
