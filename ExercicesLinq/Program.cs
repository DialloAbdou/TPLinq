// See https://aka.ms/new-console-template for more information
using Bogus;
using ExercicesLinq;

Console.WriteLine("Hello, World!");

Randomizer.Seed = new Random(1);
var faker = new Faker<Personne>()
    .RuleFor(p => p.Nom, f => f.Person.LastName)
    .RuleFor(p => p.Prenom, f => f.Person.FirstName)
    .RuleFor(p => p.Age, f => (int)DateTime.Today.Subtract(f.Person.DateOfBirth).TotalDays / 365);

var personnes = faker.Generate(100);

//foreach (var person in personnes)
//{
//    Console.WriteLine($" Nom: {person.Nom}, Prenom: {person.Prenom}, Age: {person.Age}");

//}

//var personnethirty = personnes.Where(p => p.Age > 30);

//foreach (Personne person in personnethirty)
//{
//    Console.WriteLine($" Nom: {person.Nom}, Prenom: {person.Prenom}, Age: {person.Age}");
//}


// afficher 0nom, prenom, age , des personnes qui ont plus de 30ans

// take : afficher les 10 première personnes de la liste 
//var Firsten = personnes.Take(10);

//Console.WriteLine("les 10 premères Personnes");

//foreach (var person in Firsten)
//{
//    Console.WriteLine($"Nom: {person.Nom}, Prenom: {person.Prenom}, Age :{person.Age} ans ");
//}
//// Recuperer les personnes qui ont moins de 50 ans 

//var PeronnLessFifty = personnes.TakeWhile(p => p.Age <= 70);

//Console.WriteLine("====les personnes dont l'âge est inferieur à 50===");

//foreach (var person in PeronnLessFifty)
//{
//    Console.WriteLine($"Nom: {person.Nom}, Prenom: {person.Prenom}, Age :{person.Age} ans ");

//}

// Skip  Saisir la page qu'il v voir et nombre d'élement par page en se servant de skip et de take

Console.WriteLine("Veuillez saisir la taille de page ");
int taille = int.Parse(Console.ReadLine());
Console.WriteLine("veuillez saisir le numes de pages");
int pages = int.Parse(Console.ReadLine());
var personneParPages = personnes.Skip((pages-1)*taille).Take(taille);

Console.WriteLine("les personnes pour cette pages");

foreach (var person in personneParPages)
{
  Console.WriteLine($"Nom: {person.Nom}, Prenom: {person.Prenom}, Age :{person.Age} ans ");

}

Console.ReadLine();