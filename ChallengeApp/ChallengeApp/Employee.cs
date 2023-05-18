namespace ChallengeApp
{
    public class Employee
    {
        private List<float> grades = new List<float>();

        public Employee (string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }
                
        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade < 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Invalid grade value");
            }
        }

        public void AddGrade(string grade)
        {
            if(float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine("String is not float");
            }
        }

        public void AddGrade(double grade)
        {
            grade = Math.Round(grade, 2);
            float valueDouble = (float)grade;
            this.AddGrade(valueDouble);
        }

        public void AddGrade(long grade)
        {
            float valueLong = (float)grade;
            this.AddGrade(valueLong);
        }

        public void AddGrade(char grade)
        {
            var result = char.ToString(grade);
            this.AddGrade(result);
        }

        //Przygotowanie metody, która zwróci oceny.
        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }

            statistics.Average /= this.grades.Count;

            return statistics;
        }

        public Statistics GetStatisticsWithFor()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            for (var grade = 0; grade < this.grades.Count; grade++)
            {
                statistics.Max = Math.Max(statistics.Max, this.grades[grade]);
                statistics.Min = Math.Min(statistics.Min, this.grades[grade]);
                statistics.Average += this.grades[grade];
            }

            statistics.Average /= this.grades.Count;

            return statistics;
        }

        public Statistics GetStatisticsWithDoWhile()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            var grade = 0;

            do
            {
                statistics.Max = Math.Max(statistics.Max, this.grades[grade]);
                statistics.Min = Math.Min(statistics.Min, this.grades[grade]);
                statistics.Average += this.grades[grade];
                grade++;
            } while (grade < this.grades.Count);

            statistics.Average /= this.grades.Count;

            return statistics;
        }

        public Statistics GetStatisticsWithWhile()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            var grade = 0;

            while (grade < this.grades.Count)
            {
                statistics.Max = Math.Max(statistics.Max, this.grades[grade]);
                statistics.Min = Math.Min(statistics.Min, this.grades[grade]);
                statistics.Average += this.grades[grade];
                grade++;
            }

            statistics.Average /= this.grades.Count;

            return statistics;
        }
    }
}