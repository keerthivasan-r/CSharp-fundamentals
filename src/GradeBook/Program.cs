using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        // pass params to application via array of strings
        static void Main(string[] args)
        {
            var book = new Book("Keerthi's Gradebook");
            book.AddGrade(22.3);
            book.AddGrade(12.3);
            book.AddGrade(8.3);
            book.AddGrade(2.3);
            book.GetStatistics();
        }
    }
}
