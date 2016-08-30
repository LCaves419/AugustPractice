using System;
using System.Collections.Generic;

namespace Grades
{
    public class GradeBook
    {
        public event NameChangedDelegate NameChanged;
        private string _name;
        private List<float> grades;
        public string Name
        {
            get { return _name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null or empty");
                }
                if (!String.IsNullOrEmpty(value))
                {
                    if (_name != value && NameChanged != null)
                    {
                        NameChangedEventArgs args = new NameChangedEventArgs();
                        args.ExistingName = _name;
                        args.NewName = value;
                        NameChanged(this, args);
                    }
                    _name = value;
                }

            }
        }

        //Constructor
        public GradeBook()
        {
            _name = "Empty";
            grades = new List<float>();
        }

        public GradeStats ComputeStats()
        {
            GradeStats stats = new GradeStats();


            float sum = 0;
            foreach (var grade in grades)
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                sum = sum + grade;
                //sum += grade;
                stats.AverageGrade = sum / grades.Count;// ck for error handling
            }
            return stats;
        }

        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        //public void WriteGrades(List<float> grades)
        //{
        //    Console.WriteLine(grades);
        //}





    }
}
