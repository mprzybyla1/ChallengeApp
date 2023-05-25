using ChallengeApp;

Console.WriteLine("Witamy w Programie XYZ do oceny Pracowników");
Console.WriteLine("===========================================");
Console.WriteLine();

var employee = new Employee();

while (true)
{
    Console.WriteLine("Podaj kolejną ocenę Pracownika: ");
    var input = Console.ReadLine();
    if(input == "q")
    {
        break;
    }

    try
    {
        employee.AddGrade(input);
    }
    catch(Exception e) 
    {
        Console.WriteLine($"Exception catched: {e.Message}");
    }
}

var statistics = employee.GetStatistics();

Console.WriteLine("============================================");
Console.WriteLine("Summary: ");
Console.WriteLine($"--> Average: {statistics.Average}");
Console.WriteLine($"--> Average grade as letter: {statistics.AverageLetter}");
Console.WriteLine($"--> Min: {statistics.Min}");
Console.WriteLine($"--> Max: {statistics.Max}");