// Builder.cs
using System;

namespace DesignPatterns
{
    // 계산기 클래스 (메소드 체이닝)
    public class Calculator
    {
        private double _result;

        public Calculator()
        {
            _result = 0;
        }

        public Calculator Add(double value)
        {
            _result += value;
            return this;
        }

        public Calculator Subtract(double value)
        {
            _result -= value;
            return this;
        }

        public Calculator Multiply(double value)
        {
            _result *= value;
            return this;
        }

        public Calculator Divide(double value)
        {
            if (value != 0)
            {
                _result /= value;
            }
            return this;
        }

        public double GetResult()
        {
            return _result;
        }
    }

    // Person 클래스 (빌더 패턴 + 메소드 체이닝)
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        
        public void Display()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Address: {Address}");
        }
    }

    public class PersonBuilder
    {
        private readonly Person _person = new Person();

        public PersonBuilder WithName(string name)
        {
            _person.Name = name;
            return this;
        }

        public PersonBuilder WithAge(int age)
        {
            _person.Age = age;
            return this;
        }

        public PersonBuilder WithAddress(string address)
        {
            _person.Address = address;
            return this;
        }

        public Person Build()
        {
            return _person;
        }
    }

    public class BuilderDemo
    {
        public static void Run()
        {
            // 계산기 예제 - 메소드 체이닝
            Calculator calc = new Calculator();
            double result = calc.Add(5).Multiply(2).Subtract(3).Divide(2).GetResult();
            Console.WriteLine($"Calculator result: {result}");

            // Person 빌더 예제
            Person person = new PersonBuilder()
                .WithName("홍길동")
                .WithAge(20)
                .WithAddress("양산시 부산대학로")
                .Build();
            
            person.Display();
        }
    }
}