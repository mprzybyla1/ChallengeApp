using ChallengeApp;

Console.WriteLine("Welcome to XYZ Program to collect grades of your Employees and Supervisors and finally get statistics");
Console.WriteLine("======================================================");
Console.WriteLine();

var employee = new EmployeeInFile("A", "B");
employee.AddGrade(2.5f);
employee.AddGrade(20);
employee.AddGrade("B");

//var employee = new Employee("A1", "A2");
//var supervisor = new Supervisor("B1", "B2");

//while (true)
//{
//    Console.WriteLine("Type another grade of your Employee (A-E or 0-100)");
//    Console.WriteLine("or press 'z' to go to grading your Supervisor and get statistics");
//    var input = Console.ReadLine();
//    if (input == "z")
//    {
//        break;
//    }
//    try
//    {
//        employee.AddGrade(input);
//    }
//    catch (Exception e)
//    {
//        Console.WriteLine($"Exception catched: {e.Message}");
//    }
//}

//while (true)
//{
//    Console.WriteLine("Type another grade of your Supervisor (1-6 including +/-)");
//    Console.WriteLine("or press 'q' to get statistics");
//    var input = Console.ReadLine();
//    if (input == "q")
//    {
//        break;
//    }

//    try
//    {
//        supervisor.AddGrade(input);
//    }
//    catch (Exception e)
//    {
//        Console.WriteLine($"Exception catched: {e.Message}");
//    }
//}

var statisticsEmployee = employee.GetStatistics();
// var statisticsSupervisor = supervisor.GetStatistics();

Console.WriteLine("======================================================");
Console.WriteLine("Employee Summary: ");
Console.WriteLine($"--> Average: {statisticsEmployee.Average}");
Console.WriteLine($"--> Average grade as letter: {statisticsEmployee.AverageLetter}");
Console.WriteLine($"--> Min: {statisticsEmployee.Min}");
Console.WriteLine($"--> Max: {statisticsEmployee.Max}");

//Console.WriteLine();

//Console.WriteLine("Supervisor Summary: ");
//Console.WriteLine($"--> Average: {statisticsSupervisor.Average}");
//Console.WriteLine($"--> Average grade as letter: {statisticsSupervisor.AverageLetter}");
//Console.WriteLine($"--> Min: {statisticsSupervisor.Min}");
//Console.WriteLine($"--> Max: {statisticsSupervisor.Max}");