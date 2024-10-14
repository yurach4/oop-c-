using System;
using System.Collections.Generic;

public class Person
{
    private string name;
    private DateTime birthYear;

    public string Name
    {
        get { return name; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Ім'я не може бути пустим");
            }
            name = value;
        }
    }

    public DateTime BirthYear
    {
        get { return birthYear; }
        set
        {
            if (value > DateTime.Now)
            {
                throw new ArgumentException("Рік народження не може бути в майбутньому");
            }
            birthYear = value;
        }
    }

}

class Program
{
    static void Main(string[] args)
    {

        var names = new HashSet<string>();
        foreach (var person in people)
        {
            if (!names.Add(person.Name))
            {
                Console.WriteLine($"Знайдено дублікат імені: {person.Name}");
            }
        }
    }
}