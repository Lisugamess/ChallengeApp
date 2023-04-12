using System.Diagnostics;
using System.Xml.Serialization;

namespace ChallengeApp
{
    public class Employee
    {
        private List<float> grades = new List<float>();

        public Employee(string name, string surname, string age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }
        public string Name { get; private set; }

        public string Surname { get; private set; }

        public string Age { get; private set; }

        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("invalid grade value" + " " + this.Name + " " + this.Surname);
            }
        }
        public void AddGrade(string grade)
        {
            if (grade.Length == 1)
            {
                char resultChar = grade[0];
                switch (resultChar)
                {
                    case 'A':
                    case 'a':
                    case 'B':
                    case 'b':
                    case 'C':
                    case 'c':
                    case 'D':
                    case 'd':
                    case 'E':
                    case 'e':
                        this.AddGrade(resultChar);
                        break;
                    default:

                        if (float.TryParse(grade, out float result))
                        {
                            this.AddGrade(result);
                        }
                        else
                        {
                            Console.WriteLine("String is not float");
                        }
                        break;
                }
            }
            else
            {
                if (float.TryParse(grade, out float result))
                {
                    this.AddGrade(result);
                }
                else
                {
                    Console.WriteLine("Podana wartość nie jest floatem");
                }
            }
        }
        public void AddGrade(double grade)
        {
            float result = (float)grade;
            this.AddGrade(result);
        }
        public void AddGrade(int grade)
        {
            this.AddGrade((float)grade);
        }
        public void AddGrade(long grade)
        {
            this.AddGrade((float)grade);
        }
        public void AddGrade(decimal grade)
        {
            this.AddGrade((float)grade);
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
                    Console.WriteLine("Wrong letter");
                    
                    break;
            }
        }
        
        public Statistcis GetStatistics()
        {
            var statistcis = new Statistcis();
            statistcis.Average = 0;
            statistcis.Max = float.MinValue;
            statistcis.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistcis.Max = Math.Max(statistcis.Max, grade);
                statistcis.Min = Math.Min(statistcis.Min, grade);
                statistcis.Average += grade;
            }

            switch (statistcis.Average)
            {
                case var average when average >= 80:
                    statistcis.AverageLetter = 'A';
                    statistcis.AverageLetter = 'a';
                    break;
                case var average when average >= 60:
                    statistcis.AverageLetter = 'B';
                    statistcis.AverageLetter = 'b';
                    break;
                case var average when average >= 40:
                    statistcis.AverageLetter = 'C';
                    statistcis.AverageLetter = 'c';
                    break;
                case var average when average >= 20:
                    statistcis.AverageLetter = 'D';
                    statistcis.AverageLetter = 'd';
                    break;
                
                default:
                    statistcis.AverageLetter = 'F';
                    statistcis.AverageLetter = 'e';
                    break;
            }
            if (grades.Count == 0)
            {
                statistcis.Max = 0;
                statistcis.Min = 0;
                statistcis.Average = 0;
            }
            return statistcis;
        }
    }
}
