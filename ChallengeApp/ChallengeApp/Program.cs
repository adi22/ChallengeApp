using ChallengeApp;
var employee = new Employee("Jan", "Kowalski");

Console.WriteLine("Witamy w Programie do oceny pracowników");
Console.WriteLine("Aby zakończyć wprowadzanie ocen wprowadź 'q'");
Console.WriteLine("=======================================");
Console.WriteLine();

var counter = 0;

while (true)
{
    if (counter == 0)
    {
        Console.WriteLine("Podaj ocenę:");
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
        employee.AddGrade(result);

    }
    else
    {
        employee.AddGrade(input);
    }
    counter++;
}

var statistics = employee.GetStatistics();
Console.WriteLine();
Console.WriteLine($"Średnia: {Math.Round(statistics.Average,2)}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max {statistics.Max}");

