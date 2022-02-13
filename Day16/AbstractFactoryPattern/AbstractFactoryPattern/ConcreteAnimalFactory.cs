using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{

    public class LandAnimalFactory : AnimalFactory
    {
        public override Animal GetAnimal(string animalType)
        {
            if (animalType.Equals("Dog"))
            {
                return new Dog();

            }
            else if(animalType.Equals())
        }
    }
    class ConcreteAnimalFactory
    {
    }
}
