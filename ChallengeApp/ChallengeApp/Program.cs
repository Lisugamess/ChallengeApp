using ChallengeApp;
using System.Runtime.CompilerServices;

var employee = new Employee("Alana", "Nowak");
employee.AddGrade("Adam");
employee.AddGrade("4000");
employee.AddGrade(2);
employee.AddGrade(6);
var staistics = employee.GetStatistics();
Console.WriteLine($"Average: {staistics.Average:N2}");
Console.WriteLine($"Min: {staistics.Min}");
Console.WriteLine($"Max: {staistics.Max}");

var statistic1 = employee.GetStatisticsWithForEache();
Console.WriteLine("Foreach");
Console.WriteLine($"Average: {staistics.Average:N2}");
Console.WriteLine($"Min: {staistics.Min}");
Console.WriteLine($"Max: {staistics.Max}");

var statistic2 = employee.GetStatisticsWithFor();
Console.WriteLine("For");
Console.WriteLine($"Average: {staistics.Average:N2}");
Console.WriteLine($"Min: {staistics.Min}");
Console.WriteLine($"Max: {staistics.Max}");

var statistic3 = employee.GetStatisticsWithDoWhile();
Console.WriteLine("Do While");
Console.WriteLine($"Average: {staistics.Average:N2}");
Console.WriteLine($"Min: {staistics.Min}");
Console.WriteLine($"Max: {staistics.Max}");

var statistic4 = employee.GetStatisticsWhiteWhile();
Console.WriteLine("While");
Console.WriteLine($"Average: {staistics.Average:N2}");
Console.WriteLine($"Min: {staistics.Min}");
Console.WriteLine($"Max: {staistics.Max}");