// See https://aka.ms/new-console-template for more information
using Bogus;
using ExercicesLinq;

Console.WriteLine("Hello, World!");

Randomizer.Seed = new Random(1);
var faker = new Faker<Personne>()
    .RuleFor(p => p.Nom, f => f.Person.LastName)
    .RuleFor(p => p.Prenom, f => f.Person.FirstName)
    .RuleFor(p => p.Age, f => (int)DateTime.Today.Subtract(f.Person.DateOfBirth).TotalDays / 365);
var adresseFaker = new Faker<Adresse>()
    .RuleFor(p => p.Id, f => f.IndexFaker)
    .RuleFor(p => p.AdressePostal, f => f.Address.FullAddress());
var adresses = adresseFaker.Generate(100);
List<Personne>? personnes = faker.Generate(100);
foreach (var person in personnes)
{
    int nbEnfant = Random.Shared.Next(0, 6);    person.Enfants = faker.Generate(nbEnfant);
}
//// ici on recupere la liste des enfants 
//var enfants =  personnes.SelectMany(p=> p.Enfants).ToList();

//foreach (var enfant in enfants)
//{
//    Console.WriteLine($"Nom: {enfant.Nom}, Prenom : {enfant.Prenom}, Age : {enfant.Age}");
//}
////  recuperer les prenoms des enfants qui se trouve dans la liste

//var enfantPrenoms = personnes.SelectMany(p => p.Enfants,(Personne _, Personne enfan)=>enfan.Prenom);

//foreach(var prenom in enfantPrenoms)
//{
//    Console.WriteLine(prenom);
//}


//var personnethirty = personnes.Where(p=>p.Age > 30).ToList();

//foreach (Personne person in personnethirty)
//{
//    Console.WriteLine($" Nom: {person.Nom}, Prenom: {person.Prenom}, Age: {person.Age}");
//}


// afficher 0nom, prenom, age , des personnes qui ont plus de 30ans

// take : afficher les 10 première personnes de la liste 


//IEnumerable<Personne>? personnesTen = personnes.Take(10);

//Console.WriteLine("les 10 premières personnes de la Liste");

//foreach (var p in personnesTen)
//{
//    Console.WriteLine($" Nom : {p.Nom} Prénom {p.Prenom}, Age : {p.Age} ");
//}
//// Ensuite afficher les personnes tantque l'âge est inferieur à 69

//var personLessfifty = personnesTen.TakeWhile(p => p.Age <=69);

//Console.WriteLine("les afficher les persnne dont l'age est inferieur ");

//foreach (var p in personLessfifty)
//{
//    Console.WriteLine($" Nom : {p.Nom} Prénom {p.Prenom}, Age : {p.Age} ");

//}
//// Skip: L'utilisateur doit saisir la page qu'il veut voir et le nombre d'element par pages

//Console.WriteLine("Veuillez saisir la taille de page ");

//int taille = int.Parse(Console.ReadLine());

//Console.WriteLine("veuillez saisir le numes de pages");
//int pages = int.Parse(Console.ReadLine());
//var personneParPages = personnes.Skip((pages-1)*taille).Take(taille);

//Console.WriteLine("les personnes pour cette pages");

//foreach (var person in personneParPages)
//{
//    Console.WriteLine($"Nom: {person.Nom}, Prenom: {person.Prenom}, Age :{person.Age} ans ");
//}

////distinct : Afficher des personnes avec un age different
//var personndeDistinct = personnes.DistinctBy(p => p.Age).Take(20);

//Console.WriteLine("les distinct Ages");

//foreach (var person in personndeDistinct)
//{
//    Console.WriteLine($"Nom: {person.Nom}, Prenom: {person.Prenom}, Age :{person.Age} ans ");

////}
//var personName = personnes.Select(p => p.Prenom);

//foreach (var person in personName)
//{
//    Console.WriteLine(person);
//}

// Utilisation de Group by sur l'âge  des personnes
//Console.WriteLine("utilisation du groupBy");

//var personneGroup = personnes.GroupBy(p => p.Age, p=>new {p.Nom, p.Prenom});

//foreach (var person in personneGroup.OrderBy(p=>p.Key))
//{
//    Console.WriteLine($"{person.Key}");
//    foreach (var item in person)
//    {
//        Console.WriteLine(item.Prenom);
//    }
//}
// utilisation de  Join

var adressePersonnes = personnes.Join(adresses,p=>p.IdAdresse, a=>a.Id, (personne, adresse)=>new {personne,adresse});

foreach(var item in adressePersonnes.Take(10))
{
    Console.WriteLine($" la personne {item.personne.Nom}, {item.personne.Prenom} a pour adresse {item.adresse.AdressePostal}");
}
Console.ReadLine();