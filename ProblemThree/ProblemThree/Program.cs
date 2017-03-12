using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemThree
{
    class Program
    {
        static void Main(string[] args)
        {
            ParameterModifiers p = new ParameterModifiers();
            

            double a = p.computeAverage(1, 2, 3, 4, 5);
            Console.WriteLine(a);
            double b = p.computeAverage(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
            Console.WriteLine(b);

            double[] numbers = { 1, 2, 3, 4, 5 };
            double average;
            p.computeAverage(numbers, out average);
            Console.WriteLine(average);



            
            p.removeFirst(ref numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
