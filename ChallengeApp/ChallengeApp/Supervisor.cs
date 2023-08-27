namespace ChallengeApp
{
    public class Supervisor : IEmployee
    {
        private List<float> grades = new List<float>();

        public string Name { get; private set; }

        public string Surname { get; private set; }

        public Supervisor(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new Exception("Invalid grade value");
            }
        }

        public void AddGrade(string grade)
        {
            if (grade.Length == 1 || grade.Length == 2)
            {
                switch (grade)
                {
                    case "1":
                        this.grades.Add(0);
                        break;
                    case "2":
                        this.grades.Add(20);
                        break;
                    case "3":
                        this.grades.Add(40);
                        break;
                    case "4":
                        this.grades.Add(60);
                        break;
                    case "5":
                        this.grades.Add(80);
                        break;
                    case "6":
                        this.grades.Add(100);
                        break;
                    case "1+":
                    case "+1":
                        this.grades.Add(5);
                        break;
                    case "2+":
                    case "+2":
                        this.grades.Add(25);
                        break;
                    case "3+":
                    case "+3":
                        this.grades.Add(45);
                        break;
                    case "4+":
                    case "+4":
                        this.grades.Add(65);
                        break;
                    case "5+":
                    case "+5":
                        this.grades.Add(85);
                        break;
                    case "2-":
                    case "-2":
                        this.grades.Add(15);
                        break;
                    case "3-":
                    case "-3":
                        this.grades.Add(35);
                        break;
                    case "4-":
                    case "-4":
                        this.grades.Add(55);
                        break;
                    case "5-":
                    case "-5":
                        this.grades.Add(75);
                        break;
                    case "6-":
                    case "-6":
                        this.grades.Add(95);
                        break;
                    default:
                        throw new Exception("Wrong value");

                }
            }
            else
            {
                throw new Exception("Wrong value");
            }
        }

        public void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.grades.Add(100);
                    break;
                case 'B':
                case 'b':
                    this.grades.Add(80);
                    break;
                case 'C':
                case 'c':
                    this.grades.Add(60);
                    break;
                case 'D':
                case 'd':
                    this.grades.Add(40);
                    break;
                case 'E':
                case 'e':
                    this.grades.Add(20);
                    break;
                default:
                    throw new Exception("Wrong letter");
            }
        }

        public void AddGrade(int grade)
        {
            float result = (float)grade;
            this.AddGrade(result);
        }

        public void AddGrade(double grade)
        {
            float result = (float)grade;
            this.AddGrade(result);
        }

        public void AddGrade(long grade)
        {
            float result = (float)grade;
            this.AddGrade(result);
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();

            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            var index = 0;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }

            statistics.Average /= this.grades.Count;

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
                case var average when average >= 200:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
            }

            return statistics;
        }

        public float ReturnLastGrade()
        {
            if (this.grades.Count != 0)
            {
                return grades[grades.Count() - 1];
            }
            else
            {
                return 0;
            }
        }
    }
}
