namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeBase
    {
        public event GradeAddedDelegate GradeAdded;
        private const string fileName = "grades.txt";

        public EmployeeInFile(string name, string surname) 
            : base(name, surname)
        {
        }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(grade);

                    if (GradeAdded != null)
                    {
                        GradeAdded(this, new EventArgs());
                    }
                }
            }
            else
            {
                throw new Exception("Invalid grade value");
            }
        }

        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                throw new Exception("String is not float");
            }
        }

        public override void AddGrade(int grade)
        {
            float result = (float)grade;
            this.AddGrade(result);
        }

        public override void AddGrade(char grade)
        {
            using (var writer = File.AppendText(fileName))
            {
                switch (grade)
                {
                    case 'A':
                    case 'a':
                        writer.WriteLine(100);
                        if (GradeAdded != null)
                        {
                            GradeAdded(this, new EventArgs());
                        }
                        break;
                    case 'B':
                    case 'b':
                        writer.WriteLine(80);
                        if (GradeAdded != null)
                        {
                            GradeAdded(this, new EventArgs());
                        }
                        break;
                    case 'C':
                    case 'c':
                        writer.WriteLine(60);
                        if (GradeAdded != null)
                        {
                            GradeAdded(this, new EventArgs());
                        }
                        break;
                    case 'D':
                    case 'd':
                        writer.WriteLine(40);
                        if (GradeAdded != null)
                        {
                            GradeAdded(this, new EventArgs());
                        }
                        break;
                    case 'E':
                    case 'e':
                        writer.WriteLine(20);
                        if (GradeAdded != null)
                        {
                            GradeAdded(this, new EventArgs());
                        }
                        break;
                    default:
                        throw new Exception("Wrong letter");
                }

            }
        }

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();

            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            if (File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();
                    var counter = 0;
                    var areThereAnyFloat = false;
                    while (line != null)
                    {
                        if (float.TryParse(line, out float result))
                        {
                            var number = float.Parse(line);
                            statistics.Max = Math.Max(statistics.Max, number);
                            statistics.Min = Math.Min(statistics.Min, number);
                            statistics.Average += number;

                            line = reader.ReadLine();
                            counter++;
                            areThereAnyFloat = true;
                        }
                        else
                        {
                            line = reader.ReadLine();
                        }
                    }
                    if (areThereAnyFloat == false)
                    {
                        statistics.Average = 0;
                        statistics.Max = 0;
                        statistics.Min = 0;
                    }
                    else
                    {
                        statistics.Average /= counter;

                        switch (statistics.Average)
                        {
                            case var average when average >= 80:
                                statistics.AverageLetter = 'A';
                                break;
                            case var average when average >= 60:
                                statistics.AverageLetter = 'B';
                                break;
                            case var average when average >= 40:
                                statistics.AverageLetter = 'C';
                                break;
                            case var average when average >= 20:
                                statistics.AverageLetter = 'D';
                                break;
                            default:
                                statistics.AverageLetter = 'E';
                                break;
                        }
                    }
                }
                return statistics;
            }
            else
            {
                statistics.Average = 0;
                statistics.Max = 0;
                statistics.Min = 0;
                return statistics;
            }
        }
    }
}
