﻿using ChallengeApp;

int gradeInInt = 1;
double gradeInDouble = 50.5;
long gradeInLong = 67;

var employee = new Employee("Jan", "Kowalski");
employee.AddGrade("x");
employee.AddGrade(40);
employee.AddGrade(2);
employee.AddGrade(8);
employee.AddGrade(gradeInInt);
employee.AddGrade(gradeInDouble);
employee.AddGrade(gradeInLong);

var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");