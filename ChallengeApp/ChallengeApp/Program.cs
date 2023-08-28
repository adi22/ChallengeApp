using ChallengeApp;
var employeeFromMemory = new EmployeeInMemory("Jan", "Kowalski");
var employeeFromFile = new EmployeeInFile("Jan", "Kowalski");

Console.WriteLine("Witamy w Programie do oceny pracowników");
Console.WriteLine("Aby zakończyć wprowadzanie ocen wprowadź 'q'");
Console.WriteLine("=======================================");
Console.WriteLine();

Console.WriteLine("Dane z pamięci:");
try
{
    employeeFromMemory.AddGrade(3);
}
catch(Exception e) 
{ 
    Console.WriteLine($"Exception catched: {e.Message}");
}
try 
{ 
    employeeFromMemory.AddGrade("76"); 
} 
catch (Exception e) 
{ 
    Console.WriteLine($"Exception catched: {e.Message}"); 
}
try 
{
    employeeFromMemory.AddGrade('C');
} 
catch (Exception e) 
{
    Console.WriteLine($"Exception catched: {e.Message}"); 
}

var statisticsFromMemory = employeeFromMemory.GetStatistics();
Console.WriteLine($"Min: {statisticsFromMemory.Min}");
Console.WriteLine($"Max: {statisticsFromMemory.Max}");
Console.WriteLine($"Średnia: {Math.Round(statisticsFromMemory.Average,2)}");
Console.WriteLine($"Ocena: {statisticsFromMemory.AverageLetter}");

Console.WriteLine();

Console.WriteLine("Dane z pliku:");
try
{
    employeeFromFile.AddGrade(3);
}
catch (Exception e)
{
    Console.WriteLine($"Exception catched: {e.Message}");
}
try
{
    employeeFromFile.AddGrade("76");
}
catch (Exception e)
{
    Console.WriteLine($"Exception catched: {e.Message}");
}
try
{
    employeeFromFile.AddGrade('C');
}
catch (Exception e)
{
    Console.WriteLine($"Exception catched: {e.Message}");
}

var statisticsFromFile = employeeFromFile.GetStatistics();
Console.WriteLine($"Min: {statisticsFromFile.Min}");
Console.WriteLine($"Max: {statisticsFromFile.Max}");
Console.WriteLine($"Średnia: {Math.Round(statisticsFromFile.Average,2)}");
Console.WriteLine($"Ocena: {statisticsFromFile.AverageLetter}");





/*var isItFirstLoop = true;

while (true)
{
    if (isItFirstLoop == true)
    {
        Console.WriteLine("Podaj ocenę:");
        isItFirstLoop = false;
    }
    else 
    {
        Console.WriteLine("Podaj kolejną ocenę:");
    }
    var input = Console.ReadLine();
    
    if (input == "q")
    {
        break;
    }

    if (input.Length == 1 && !(int.TryParse(input, out int i)))
    {
        char.TryParse(input, out char result);

        try
        {
            employee.AddGrade(result);
        }
        catch(Exception e)
        {
            Console.WriteLine($"Exception catched: {e.Message}");
        }
    }
    else
    {
        try
        {
            employee.AddGrade(input);
        }
        catch (Exception e)
        {
            Console.WriteLine($"Exception catched: {e.Message}");
        }
    }
}

var statistics = employee.GetStatistics();
Console.WriteLine();
Console.WriteLine($"Średnia: {Math.Round(statistics.Average,2)}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max {statistics.Max}");*/

