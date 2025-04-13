// Adapter.cs
using System;

namespace DesignPatterns
{
    // 내부 클래스 (Target)
    public class InternalClass
    {
        public virtual string Fetch()
        {
            return "get user info";
        }
    }

    // 외부 클래스 (Adaptee)
    public class ExternalClass
    {
        public string Search()
        {
            return "get user info";
        }
    }

    // 어댑터 클래스
    public class Adapter : InternalClass
    {
        private readonly ExternalClass _external;

        public Adapter(ExternalClass external)
        {
            _external = external;
        }

        public override string Fetch()
        {
            return _external.Search();
        }
    }

    public class AdapterDemo
    {
        public static void Run()
        {
            InternalClass internal1 = new InternalClass();
            Console.WriteLine($"Internal class: {internal1.Fetch()}");

            ExternalClass external = new ExternalClass();
            Console.WriteLine($"External class: {external.Search()}");

            InternalClass adapter = new Adapter(external);
            Console.WriteLine($"Adapter: {adapter.Fetch()}");
        }
    }
}