// Factory.cs
using System;

namespace DesignPatterns
{
    // 추상 클래스
    public abstract class Animal
    {
        public abstract string Speak();
    }

    // 구체 클래스들
    public class Dog : Animal
    {
        public override string Speak()
        {
            return "Woof!";
        }
    }

    public class Cat : Animal
    {
        public override string Speak()
        {
            return "Meow!";
        }
    }

    // 팩토리 클래스
    public class AnimalFactory
    {
        public Animal CreateAnimal(string animalType)
        {
            return animalType.ToLower() switch
            {
                "dog" => new Dog(),
                "cat" => new Cat(),
                _ => throw new ArgumentException($"Animal type {animalType} is not supported.")
            };
        }
    }

    public class FactoryDemo
    {
        public static void Run()
        {
            AnimalFactory factory = new AnimalFactory();
            
            Animal dog = factory.CreateAnimal("dog");
            Console.WriteLine($"Dog says: {dog.Speak()}");
            
            Animal cat = factory.CreateAnimal("cat");
            Console.WriteLine($"Cat says: {cat.Speak()}");
        }
    }
}