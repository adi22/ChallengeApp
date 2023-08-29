using ChallengeApp;
void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano nową ocenę");
}

var employeeFromMemory = new EmployeeInMemory("Jan", "Kowalski");
employeeFromMemory.GradeAdded += EmployeeGradeAdded;

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
            employeeFromMemory.AddGrade(result);
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
            employeeFromMemory.AddGrade(input);
        }
        catch (Exception e)
        {
            Console.WriteLine($"Exception catched: {e.Message}");
        }
    }
}

var statistics = employeeFromMemory.GetStatistics();
Console.WriteLine();
Console.WriteLine($"Średnia: {Math.Round(statistics.Average,2)}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max {statistics.Max}");

