using ChallengeApp;
var employee = new Employee("Jan", "Kowalski");

Console.WriteLine("Witamy w Programie do oceny pracowników");
Console.WriteLine("Aby zakończyć wprowadzanie ocen wprowadź 'q'");
Console.WriteLine("=======================================");
Console.WriteLine();

var isItFirstLoop = true;

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
Console.WriteLine($"Max {statistics.Max}");