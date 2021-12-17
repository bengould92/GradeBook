using System;
using System.Collections.Generic;
using System.Linq;

namespace GradeBook
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var grades = new List<double> { 12.7, 15.5, 10.0 };
            grades.Add(56.1);

            var result = 0.0;
            foreach (var number in grades)
            {
                result += number;
            }
            result /= grades.Count;
            Console.WriteLine($"The average grade is: {result:N1}");
            // var average = Queryable.Average(grades.AsQueryable());
            // Console.WriteLine($"The average grade is: {average:N1}");
            // Console.WriteLine(average);



            /* if (args.Length > 0)
             {
                 Console.WriteLine($"Hello, {args[0]}!");
             }
             else 
             {
                 Console.WriteLine("Hello!");
             } */
            Console.ReadLine();
            
        }
    }
}
 