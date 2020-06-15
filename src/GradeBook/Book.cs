using System;
using System.Collections.Generic;


namespace GradeBook
{
    class Book
    {

        public Book(string name)
        {
            this.name = name;
            this.grades = new List<double>();
        }

        public void AddGrade(double grade)
        {
            this.grades.Add(grade);
        }

        public void showStatistics()
        {
            var result = 0.0;
            var lowGrade = double.MaxValue;
            var highGrade = double.MinValue;
            foreach (double number in grades)
            {
                result += number;
                lowGrade = Math.Min(number, lowGrade);
                highGrade = Math.Max(number, highGrade);
            }
            Console.WriteLine($"The average grade is {result / this.grades.Count}");
            Console.WriteLine($"The highest grade is { highGrade}");
            Console.WriteLine($"The lowest grade is { lowGrade}");
        }

        private List<double> grades;
        private string name;
    }

}