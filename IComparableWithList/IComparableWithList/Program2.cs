using System;
using System.Collections.Generic;

public class Person : IComparable<Person>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public int CompareTo(Person other)
    {
        if (other == null) return 1;

        // İlk olarak LastName'leri karşılaştır
        int lastNameComparison = LastName.CompareTo(other.LastName);
        if (lastNameComparison != 0)
        {
            return lastNameComparison;
        }

        // Eğer LastName'ler aynı ise, FirstName'leri karşılaştır
        return FirstName.CompareTo(other.FirstName);
    }

    public override string ToString()
    {
        return $"{FirstName} {LastName}";
    }
}

public class Program
{
    public static void Main()
    {
        List<Person> people = new List<Person>
        {
            new Person("John", "Doe"),
            new Person("Jane", "Smith"),
            new Person("Michael", "Johnson"),
            new Person("Emily", "Doe")
        };

        people.Sort();

        foreach (var person in people)
        {
            Console.WriteLine(person);
        }
    }
}
