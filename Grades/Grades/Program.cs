using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args) 
        {
            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);

            book.NameChanged += OnNameChanged;
            book.NameChanged += (oldName, newName) => { Console.WriteLine("***"); };

            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine(stats.AverageGrade);
            Console.WriteLine(stats.HighestGrade);
            Console.WriteLine(stats.LowestGrade);

            book.Name = "NewBookName";
            book.Name = "TheBookOfLies";
            book.Name = "TheBookOfTruth";

            Console.Read();
        }

        static void OnNameChanged(object sender, NameChangedEventArgs args) => 
            Console.WriteLine($"Old Name: {args.OldName} | New Name: {args.NewName}");        

    }
}
