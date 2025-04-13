// Decorator.cs
using System;

namespace DesignPatterns
{
    // 기본 컴포넌트
    public class Coffee
    {
        public virtual int Cost()
        {
            return 5;
        }
    }

    // 데코레이터 기본 클래스
    public abstract class CoffeeDecorator : Coffee
    {
        protected readonly Coffee _coffee;

        protected CoffeeDecorator(Coffee coffee)
        {
            _coffee = coffee;
        }

        public override int Cost()
        {
            return _coffee.Cost();
        }
    }

    // 우유 데코레이터
    public class MilkDecorator : CoffeeDecorator
    {
        public MilkDecorator(Coffee coffee) : base(coffee) { }

        public override int Cost()
        {
            return _coffee.Cost() + 2;
        }
    }

    // 설탕 데코레이터
    public class SugarDecorator : CoffeeDecorator
    {
        public SugarDecorator(Coffee coffee) : base(coffee) { }

        public override int Cost()
        {
            return _coffee.Cost() + 1;
        }
    }

    public class DecoratorDemo
    {
        public static void Run()
        {
            Coffee coffee = new Coffee();
            Console.WriteLine($"Coffee: {coffee.Cost()}");  // 5

            Coffee coffeeWithMilk = new MilkDecorator(coffee);
            Console.WriteLine($"Coffee with milk: {coffeeWithMilk.Cost()}");  // 7

            Coffee coffeeWithSugar = new SugarDecorator(coffee);
            Console.WriteLine($"Coffee with sugar: {coffeeWithSugar.Cost()}");  // 6

            Coffee coffeeWithMilkAndSugar = new SugarDecorator(coffeeWithMilk);
            Console.WriteLine($"Coffee with milk and sugar: {coffeeWithMilkAndSugar.Cost()}");  // 8
        }
    }
}