using System;

namespace GradeBook
{
    class Program
    {
        // pass params to application via array of strings
        static void Main(string[] args)
        {
           
            if(args.Length > 0)
            Console.WriteLine($"Hello {args[0]} !");
        }
    }
}
