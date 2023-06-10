﻿//namespace ChallengeApp
//{
//    public class SupervisorInMemory : EmployeeBase
//    {
//        public override event GradeAddedDelegate GradeAdded;

//        private List<float> grades = new List<float>();

//        public SupervisorInMemory(string name, string surname)
//           : base(name, surname)
//        {
//        }

//        public override void AddGrade(float grade)
//        {
//            if (grade >= 0 && grade <= 100)
//            {
//                this.grades.Add(grade);

//                if (GradeAdded != null)
//                {
//                    GradeAdded(this, new EventArgs());
//                }
//            }
//            else
//            {
//                throw new Exception("Invalid grade value");
//            }
//        }

//        public override void AddGrade(string grade)
//        {
//            {
//                switch (grade)
//                {
//                    case "6":
//                        AddGrade(100);
//                        break;
//                    case "-6":
//                    case "6-":
//                        AddGrade(95);
//                        break;
//                    case "+5":
//                    case "5+":
//                        AddGrade(85);
//                        break;
//                    case "5":
//                        AddGrade(80);
//                        break;
//                    case "-5":
//                    case "5-":
//                        AddGrade(75);
//                        break;
//                    case "+4":
//                    case "4+":
//                        AddGrade(65);
//                        break;
//                    case "4":
//                        AddGrade(60);
//                        break;
//                    case "-4":
//                    case "4-":
//                        AddGrade(55);
//                        break;
//                    case "+3":
//                    case "3+":
//                        AddGrade(45);
//                        break;
//                    case "3":
//                        AddGrade(40);
//                        break;
//                    case "-3":
//                    case "3-":
//                        AddGrade(35);
//                        break;
//                    case "+2":
//                    case "2+":
//                        AddGrade(25);
//                        break;
//                    case "2":
//                        AddGrade(20);
//                        break;
//                    case "-2":
//                    case "2-":
//                        AddGrade(15);
//                        break;
//                    case "+1":
//                    case "1+":
//                        AddGrade(5);
//                        break;
//                    case "1":
//                        AddGrade(0);
//                        break;
//                    default:
//                        throw new Exception("Wrong Figure. Type a grade between 1-6.");
//                }
//            }
//        }

//        public override void AddGrade(double grade)
//        {
//            grade = Math.Round(grade, 2);
//            float valueDouble = (float)grade;
//            this.AddGrade(valueDouble);
//        }

//        public override void AddGrade(long grade)
//        {
//            float valueLong = (float)grade;
//            this.AddGrade(valueLong);
//        }

//        public override Statistics GetStatistics()
//        {
//            var statistics = new Statistics();  

//            foreach (var grade in this.grades)
//            {
//                statistics.AddGrade(grade);
//            }

//            return statistics;
//        }
//    }
//}