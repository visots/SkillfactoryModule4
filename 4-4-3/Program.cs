namespace _4_4_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var (name, age) = ("Vasya", 25);
            Console.WriteLine("Name " + name);
            Console.WriteLine("Age " + age);


            (string name, int age) anketa;
            Console.WriteLine("Enter your name:");
            anketa.name = Console.ReadLine();
            Console.WriteLine("Enter your age:");
            anketa.age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your name: " + anketa.name);
            Console.WriteLine("Your age: " + anketa.age);

            Console.ReadKey();
        }
    }
}