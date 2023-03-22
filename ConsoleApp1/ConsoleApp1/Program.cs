using System;
using System.Linq;

class Employee
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public int[] Scores { get; set; }

    public int TotalScore
    {
        get { return Scores.Sum(); }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Employee[] employees = new Employee[]
        {
            new Employee { FirstName = "Anna", LastName = "Nowak", Age = 30, Scores = new int[] { 7, 8, 9, 7, 6 } },
            new Employee { FirstName = "Jan", LastName = "Kowalski", Age = 35, Scores = new int[] { 8, 8, 7, 9, 6 } },
            new Employee { FirstName = "Maria", LastName = "Lewandowska", Age = 25, Scores = new int[] { 9, 9, 8, 10, 7 } }
        };

        Employee bestEmployee = employees.OrderByDescending(e => e.TotalScore).First();

        Console.WriteLine("Najlepszy pracownik:");
        Console.WriteLine($"Imię: {bestEmployee.FirstName}");
        Console.WriteLine($"Nazwisko: {bestEmployee.LastName}");
        Console.WriteLine($"Wiek: {bestEmployee.Age}");
        Console.WriteLine($"Wynik: {bestEmployee.TotalScore}");
    }
}