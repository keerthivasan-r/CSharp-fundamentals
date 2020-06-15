using System;
using System.Collections.Generic;


namespace GradeBook
{
    public class Book
    {

        public Book(string name)
        {
            this.Name = name;
            this.grades = new List<double>();
        }

        public void AddGrade(double grade)
        {
            this.grades.Add(grade);
        }

        public Statistics GetStatistics()
        {
            Statistics result = new Statistics();
            result.Low = double.MaxValue;
            result.High = double.MinValue;
            foreach (double grade in grades)
            {
                result.Average += grade;
                result.Low = Math.Min(grade, result.Low);
                result.High = Math.Max(grade, result.High);
            }
            result.Average /= grades.Count;
            return result;
        }

        private List<double> grades;
        public string Name;
    }

}