namespace _7_1_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        class BaseClass
        {
            protected string Name;

            public BaseClass(string name)
            {
                Name = name;
            }
        }

        class DerivedClass : BaseClass
        {
            public string Description;

            public int Counter;

            public DerivedClass(string name, string description) : base(name)
            {
                Description = description;
            }

            public DerivedClass(string name, string description, string counter) : this (name,description)
            {
                Counter = Counter;
            }
        }
    }
}