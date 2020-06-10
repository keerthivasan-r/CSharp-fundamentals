using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        // pass params to application via array of strings
        static void Main(string[] args)
        {
            var book = new Book();
            var result = 0.0;
            List<double> grades = new List<double>(){21.3,32.7};
            foreach(var number in grades){
                result += number;
            }
            result /= grades.Count;
            Console.WriteLine($"The average grade is {result:N2}");
        }
    }
}
