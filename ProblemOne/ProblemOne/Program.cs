using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog d = new Dog(3, 25, "Poodle", false);
            d.Move();
            Console.ReadKey();
        }
    }
}
