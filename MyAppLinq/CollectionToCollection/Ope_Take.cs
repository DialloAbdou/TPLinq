namespace MyAppLinq.CollectionToCollection
{
    public class Ope_Take
    {
        private static int[] entiers = new int[10] { 2, 28, 3, 4, 5, 6, 7, 8, 9, 10 };
        public static void mesthodesTake()
        {
            var mesFavoris = entiers.Take(5);
            Console.WriteLine(" Take(5)");
            foreach (var item in mesFavoris)
            {
                Console.WriteLine(item);
            }

            var sousEnsemble = entiers.Take(2..5);

            Console.WriteLine("===Take(2...5)==");

            foreach (var item in sousEnsemble)
            {
                Console.WriteLine(item);
            }

            var mesTakeLast = entiers.TakeLast(2);

            Console.WriteLine("Les derniers Elements TakeLast");

            foreach (var item in mesTakeLast)
            {
                Console.WriteLine(item);
            }

            var mesTakeWhile = entiers.TakeWhile(e => e <= 4);

            Console.WriteLine("Utilisation de TaekWhile");

            foreach (var item in mesTakeWhile)
            {
                Console.WriteLine(item);
            }
        }

    }
}
