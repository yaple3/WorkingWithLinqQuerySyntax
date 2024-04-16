using System;
using System.Linq;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections;

public class Program
{
    public static void Main()
    {
        // Famous People collection
        IList<FamousPeople> stemPeople = new List<FamousPeople>() {
                new FamousPeople() { Name= "Michael Faraday", BirthYear=1791,DeathYear=1867 },
                new FamousPeople() { Name= "James Clerk Maxwell", BirthYear=1831,DeathYear=1879 },
                new FamousPeople() { Name= "Marie Skłodowska Curie", BirthYear=1867,DeathYear=1934 },
                new FamousPeople() { Name= "Katherine Johnson", BirthYear=1918,DeathYear=2020 },
                new FamousPeople() { Name= "Jane C. Wright", BirthYear=1919,DeathYear=2013 },
                new FamousPeople() { Name = "Tu YouYou", BirthYear= 1930 },
                new FamousPeople() { Name = "Françoise Barré-Sinoussi", BirthYear=1947 },
                new FamousPeople() { Name = "Lydia Villa-Komaroff", BirthYear=1947},
                new FamousPeople() { Name = "Mae C. Jemison", BirthYear=1956},
                new FamousPeople() { Name = "Stephen Hawking", BirthYear=1942,DeathYear=2018 },
                new FamousPeople() { Name = "Tim Berners-Lee", BirthYear=1955 },
                new FamousPeople() { Name = "Terence Tao", BirthYear=1975 },
                new FamousPeople() { Name = "Florence Nightingale", BirthYear=1820,DeathYear=1910 },
                new FamousPeople() { Name = "George Washington Carver", DeathYear=1943 },
                new FamousPeople() { Name = "Frances Allen", BirthYear=1932,DeathYear=2020 },
                new FamousPeople() { Name = "Bill Gates", BirthYear=1955 }
        };

        // a) Retrieve people with birthdates after 1900 using LINQ Query Syntax
        var query1 = from s in stemPeople
                     where s.BirthYear > 1900
                     select s;
        Console.WriteLine();
        Console.WriteLine("**************************************************");
        Console.WriteLine();
        Console.WriteLine("<<<<<<<<<<     People with birthdates after 1900:     >>>>>>>>>>");
        Console.WriteLine();
        foreach (var person in query1)
        {
            Console.WriteLine(person.Name);
        }


        //B) Retrieve people who have two lowercase L's in their name using LINQ Query Syntax
        var query2 = from s in stemPeople
                     where s.Name.ToLower().Count(c => c == 'l') == 2
                     select s;
        Console.WriteLine();
        Console.WriteLine("**************************************************");
        Console.WriteLine();
        Console.WriteLine("\n<<<<<<<<<<     People with two lowercase L's in their name:     >>>>>>>>>>");
        Console.WriteLine();

        // Display the results
        foreach (FamousPeople person in query2)
        {
            Console.WriteLine(person.Name);
        }

        // c) Count the number of people with birthdays after 1950 using LINQ Query Syntax
        var query3 = (from s in stemPeople 
                      where s.BirthYear > 1950
                      select s).Count();
        Console.WriteLine();
        Console.WriteLine("**************************************************");
        Console.WriteLine();
        Console.WriteLine("\n<<<<<<<<<<     Number of people with birthdays after 1950:     >>>>>>>>>>");
        Console.WriteLine();
        Console.WriteLine(query3);

        // d) using LINQ Query Syntax d) Retrieve people with birth years between 1920 and 2000. Display their names and count the number of people in the list, then display the count.
        var query4 = from s in stemPeople
                     where s.BirthYear >= 1920 && s.BirthYear <= 2000
                     select s;
        Console.WriteLine();
        Console.WriteLine("**************************************************");
        Console.WriteLine();
        Console.WriteLine("\n<<<<<<<<<<     Names of people with birth years between 1920 and 2000:     >>>>>>>>>>");
        Console.WriteLine();
        foreach (FamousPeople person in query4)
        {
            Console.WriteLine(person.Name);
        }
        var birthCount = query4.Count();
        Console.WriteLine();
        Console.WriteLine("**************************************************");
        Console.WriteLine();
        Console.WriteLine("\n<<<<<<<<<<     Number of people with birth years between 1920 and 2000:     >>>>>>>>>>");
        Console.WriteLine();
        Console.WriteLine(birthCount);

        //e) Sort the list by BirthYear
        var query5 = from s in stemPeople
                     orderby s.BirthYear
                     select s;
        Console.WriteLine();
        Console.WriteLine("**************************************************");
        Console.WriteLine();
        Console.WriteLine("\n<<<<<<<<<<     List of people with birth years between 1920 and 2000, sorted by birth year:     >>>>>>>>>>");
        Console.WriteLine();
        foreach (FamousPeople person in query5)
        {
            Console.WriteLine(person.Name);
            Console.WriteLine(person.BirthYear);
        }

        //f) using LINQ query syntax retrieve people with a death year after 1960 and before 2015, sort the list by name in ascending order.
        var query6 = from s in stemPeople
                     where s.DeathYear > 1960 && s.DeathYear < 2015
                     orderby s.Name
                     select s;
        Console.WriteLine();
        Console.WriteLine("**************************************************");
        Console.WriteLine();
        Console.WriteLine("\nPeople with a death year after 1960 and before 2015, sorted by name in ascending order:");
        Console.WriteLine();
        foreach (FamousPeople person in query6)
        {
            Console.WriteLine(person.Name);
        }
    }
}
class FamousPeople
{
    public string Name { get; set; }
    public int? BirthYear { get; set; } = null;
    public int? DeathYear { get; set; } = null;
}