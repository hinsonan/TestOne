using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemTwo
{
    class Cat : IAnimal
    {
        public int Age { get; set; }
        public double Weight { get; set; }
        public bool IsVaccinated { get; set; }

        public Cat(int age, double weight, bool isItVaccinated)
        {
            Age = age;
            Weight = weight;
            IsVaccinated = isItVaccinated;
        }

        public void Move()
        {
            Console.WriteLine("I’m a cat and I’m moving!");
        }
    }
}
