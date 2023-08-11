using ChallengeApp;

//Creating employees
Employee employee1 = new Employee("Marek", "Nowak", 23);
Employee employee2 = new Employee("Anna", "Kowalska", 27);
Employee employee3 = new Employee("Rafał", "Sasin", 43);

//Add score to employee1
employee1.AddScore(5);
employee1.AddScore(7);
employee1.AddScore(4);
employee1.AddScore(6);
employee1.AddScore(5);

//Add score to employee2
employee2.AddScore(8);
employee2.AddScore(3);
employee2.AddScore(4);
employee2.AddScore(4);
employee2.AddScore(7);

//Add score to employee3
employee3.AddScore(6);
employee3.AddScore(6);
employee3.AddScore(2);
employee3.AddScore(8);
employee3.AddScore(7);

//Find employee with best score
int score1 = employee1.GetScore;
int score2 = employee2.GetScore;
int score3 = employee3.GetScore;

if (score1>score2 && score1>score3)
{
    Console.WriteLine("Imię: " + employee1.Name);
    Console.WriteLine("Nazwisko: " + employee1.LastName);
    Console.WriteLine("Wiek: " + employee1.Age);
    Console.WriteLine("Suma ocen: " + employee1.GetScore);
}
else if (score2>score1 && score2>score3)
{
    Console.WriteLine("Imię: " + employee2.Name);
    Console.WriteLine("Nazwisko: " + employee2.LastName);
    Console.WriteLine("Wiek: " + employee2.Age);
    Console.WriteLine("Suma ocen: " + employee2.GetScore);
}
else if (score3>score1 && score3>score2)
{
    Console.WriteLine("Imię: " + employee3.Name);
    Console.WriteLine("Nazwisko: " + employee3.LastName);
    Console.WriteLine("Wiek: " + employee3.Age);
    Console.WriteLine("Suma ocen: " + employee3.GetScore);
}
else 
{
    Console.WriteLine("Przynajmniej dwóch pracowników ma najlepszy wynik");
}