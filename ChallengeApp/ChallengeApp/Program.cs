using ChallengeApp;


Console.WriteLine("Witamy w programie XYZ do oceny pracowników");
Console.WriteLine("===========================================");
Console.WriteLine();
Console.WriteLine("Aby zakończyć dodawanie ocen wciśnji litere : q");
Console.WriteLine();

var Employee = new Employee("Adam","Nowak", "45");

while (true)
{

        Console.WriteLine("Podaj kolejna ocene pracownika " + Employee.Name + " " + Employee.Surname + " " + Employee.Age);
    var input = Console.ReadLine();
    if(input == "q")
    {
        break;
    }
    Employee.AddGrade(input);
}
var statistcis = Employee.GetStatistics();
Console.WriteLine($"AverageLetter: {statistcis.AverageLetter}");
Console.WriteLine($"AVG: {statistcis.Average:N2}");
Console.WriteLine($"Min: {statistcis.Min}");
Console.WriteLine($"Max: {statistcis.Max}");


