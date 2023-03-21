using ChallengeApp;

Employee employee1 = new Employee("Adam", "nowak", "33");
Employee employee2 = new Employee("Tomasz", "nowak", "23");
Employee employee3 = new Employee("Kacper", "nowak", "28");


employee1.AddScore(5);
employee1.AddScore(2);
employee1.AddScore(7);
employee1.AddScore(7);
employee1.AddScore(3);

employee2.AddScore(3);
employee2.AddScore(8);
employee2.AddScore(6);
employee2.AddScore(3);
employee2.AddScore(2);

employee3.AddScore(9);
employee3.AddScore(6);
employee3.AddScore(1);
employee3.AddScore(2);
employee3.AddScore(7);

List<Employee> employee = new List<Employee>()
{
    employee1, employee2, employee3
};

int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach (var employe in employee)
{
    if (employe.Rseult > maxResult)
    {
        employeeWithMaxResult = employe;
    }
}
Console.WriteLine("Najwyższą liczbą ocen ma : " + employeeWithMaxResult.Name);
Console.WriteLine("Name:" + employeeWithMaxResult.Name);
Console.WriteLine("Surname:" + employeeWithMaxResult.Surname);
Console.WriteLine("Age:" + employeeWithMaxResult.Age);
Console.WriteLine("Suma punktów: " + employeeWithMaxResult.Rseult);


