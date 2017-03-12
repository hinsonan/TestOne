using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemThree
{
    class ParameterModifiers
    {
        public double computeAverage(params double[] numbers)
        {
            double total = 0;
            double average = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                total += numbers[i];
            }

            average = total / numbers.Length;
            return average;
        }

        public double computeAverage(double[] numbers, out double average)
        {
            double total = 0;
            
            for (int i = 0; i < numbers.Length; i++)
            {
                total += numbers[i];
            }

            average = total / numbers.Length;
            return average;
        }

        public double[] removeFirst(ref double[] numbers)
        {
            
            


            return numbers = numbers.Skip(1).ToArray(); 
        }
    }
}
