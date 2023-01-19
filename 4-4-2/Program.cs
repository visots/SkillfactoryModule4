namespace _4_4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            (string name, int age) anketa;
            Console.WriteLine("Enter your name:");
            anketa.name = Console.ReadLine();
            Console.WriteLine("Enter your age:");
            anketa.age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your name: "+anketa.name);
            Console.WriteLine("Your age: " + anketa.age);

            Console.ReadKey();
        }
    }
}