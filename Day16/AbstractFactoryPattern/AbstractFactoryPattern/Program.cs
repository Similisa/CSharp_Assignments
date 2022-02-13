﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{

    public interface Animal
    {
        string speak();
    }

    public class Cat: Animal
    {
        public string speak()
        {
            return "Meow meow";
        }
    }

    public class Dog : Animal
    {
        public string speak()
        {
            return "Bow Bow";
        }
    }

    public class Lion: Animal
    {
        public string speak()
        {
            return "Roar";
        }
    }

    public class Octopus : Animal
    {
        public string speak()
        {
            return "squawck";
        }
    }

    public class Shark : Animal
    {
        public string speak()
        {
            return "I can not speak";
        }
    }

    public abstract class AnimalFactory
    {
        public abstract Animal GetAnimal(string animalType);
        public static AnimalFactory CreateAnimalFactory(string factoryType)
        {
            if (factoryType.Equals("Sea"))
            {
                return new SeaAnimalFactory();
            }

            else return new LandAnimalFactory();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
