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
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");