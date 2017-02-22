using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemOne
{
    abstract class Animal
    {
        public int Age { get; set; }
        public double Weight { get; set; }

        public Animal(int age, double weight)
        {
            Age = age;
            Weight = weight;
        }

        abstract public void Move();

    }
}
