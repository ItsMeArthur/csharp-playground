using System;
using System.Collections;
using System.Collections.Generic;

namespace Grades
{
    public class GradeBook : IEnumerable
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

        public IEnumerator GetEnumerator()
        {
            return grades.GetEnumerator();
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
                    if (value != _name)
                    {
                        //Invoke the delegate
                        NameChanged(this, new NameChangedEventArgs { OldName = _name, NewName = value });
                    }
                    _name = value;
                }
            }
        }

        //This field allows people to hook code to this delegate. Code hooked up to this delegate
        //will be executed when the delegate it's "triggered".
        public event NameChangedDelegate NameChanged;

        //List of grades contained in the gradebook
        private List<float> grades;
    }
}
