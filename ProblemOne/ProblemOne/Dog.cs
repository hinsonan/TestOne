using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemOne
{
    class Dog : Animal
    {
        public String Breed { get; set; }
        public bool IsVaccinated { get; set; }

        public Dog(int age, double weight,String breed, bool isItVaccinated) : base(age, weight)
        {
            Breed = breed;
            IsVaccinated = isItVaccinated;
            Age = age;
            Weight = weight;
        }

        public override void Move()
        {
            Console.WriteLine("I'm a dog and I'm moving!");
        }
    }
}
