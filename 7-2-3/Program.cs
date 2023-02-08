namespace _7_2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            DerivedClass derived = new DerivedClass();
            derived.Display();
        }

       

    }

    class BaseClass
    {
       public virtual void Display()
        {
            Console.WriteLine("Метод класса BaseClass");
        }
    }

    class DerivedClass : BaseClass
    {
       public override void Display()
        {
            base.Display();
            Console.WriteLine("Метод класса DerivedClass");
        }
    }
}