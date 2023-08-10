
int number = 4566;
string numberAsString = number.ToString();
char[] letters = numberAsString.ToArray();

string[] results = {"0 => ", "1 => ", "2 => " , "3 => ", "4 => ", "5 => ", "6 => ", "7 => ",
"8 => ", "9 => "};
int[] counters = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

foreach (char letter in letters)
{
    if (letter == '0') { counters[0]++; }
    else if (letter == '1') { counters[1]++; }
    else if (letter == '2') { counters[2]++; }
    else if (letter == '3') { counters[3]++; }
    else if (letter == '4') { counters[4]++; }
    else if (letter == '5') { counters[5]++; }
    else if (letter == '6') { counters[6]++; }
    else if (letter == '7') { counters[7]++; }
    else if (letter == '8') { counters[8]++; }
    else if (letter == '9') { counters[9]++; }
}

Console.WriteLine("Wyniki dla liczby "+ number);
for (int i=0; i<results.Length; i++)
{
    Console.WriteLine(results[i] + counters[i]);
}
