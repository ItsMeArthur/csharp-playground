using System;
using System.Collections.Generic;

namespace Grades
{
    public class GradeBook
    {
        public GradeBook()
        {
            //Initialize the list of grades
            grades = new List<float>();
        }

        //Returns an GradeStatistics object with statistical information
        public GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats =  new GradeStatistics();

            float sum = 0;
            foreach(float grade in grades)
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                sum += grade;
            }
            stats.AverageGrade = sum / grades.Count;
            return stats;
        }

        //Adds a grade to the list
        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        //Public field that holds the name of the gradebook
        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _name = value;
                }
            }
        }

        //List of grades contained in the gradebook
        private List<float> grades;
    }
}
