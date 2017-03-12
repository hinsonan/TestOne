using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat c = new Cat(5, 12, true);
            c.Move();
            Console.ReadKey();
        }
    }
}
