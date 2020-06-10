using System;

namespace GradeBook
{
    class Program
    {
        // pass params to application via array of strings
        static void Main(string[] args)
        {
            var numbers = new[] {21.3,24,1.32};
            var result = 0.0;
            foreach(var number in numbers){
                result+=number;
            }
            Console.WriteLine(result);
           
        }
    }
}
