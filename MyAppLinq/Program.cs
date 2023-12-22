// See https://aka.ms/new-console-template for more information
using MyAppLinq;


//var liste = new MaListe(10);

//foreach (var val in liste)
//{
//    Console.WriteLine(val );
//}
//Console.ReadLine();

Console.WriteLine("Utlisation de Extension");

int[] tableau = new[] { 1, 2, 3, 4, 5, 6 };

var NbrePaire = tableau.CompterPair();
Console.WriteLine($"le nombre Paire est: {NbrePaire}");

Console.ReadLine();


