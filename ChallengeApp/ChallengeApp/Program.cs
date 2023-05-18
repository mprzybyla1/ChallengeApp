using ChallengeApp;

var employee = new Employee("Mateusz", "PPP");
employee.AddGrade("Mateusz");   //string
employee.AddGrade("4000");      //string
employee.AddGrade('2');         //char
employee.AddGrade("1.21");      //string
employee.AddGrade(1);           //long
employee.AddGrade(0.22f);       //float
employee.AddGrade(3.11111);     //double
var statistics = employee.GetStatistics();
var statistics1 = employee.GetStatisticsWithFor();
var statistics2 = employee.GetStatisticsWithDoWhile();
var statistics3 = employee.GetStatisticsWithWhile();

Console.WriteLine("-->" + "Foreach");
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine("-->" + "For");
Console.WriteLine($"Average: {statistics1.Average:N2}");
Console.WriteLine($"Min: {statistics1.Min}");
Console.WriteLine($"Max: {statistics1.Max}");
Console.WriteLine("-->" + "DoWhile");
Console.WriteLine($"Average: {statistics3.Average:N2}");
Console.WriteLine($"Min: {statistics2.Min}");
Console.WriteLine($"Max: {statistics2.Max}");
Console.WriteLine("-->" + "While");
Console.WriteLine($"Average: {statistics3.Average:N2}");
Console.WriteLine($"Min: {statistics3.Min}");
Console.WriteLine($"Max: {statistics3.Max}");