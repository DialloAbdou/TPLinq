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

var personnethirty = personnes.Where(p => p.Age > 30);

foreach (Personne person in personnethirty)
{
    Console.WriteLine($" Nom: {person.Nom}, Prenom: {person.Prenom}, Age: {person.Age}");
}

Console.ReadLine();

// afficher 0nom, prenom, age , des personnes qui ont plus de 30ans

// take : afficher les 10 première personnes de la liste 
// Recuperer les personnes qui ont moins de 50 ans 