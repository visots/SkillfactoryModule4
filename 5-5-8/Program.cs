namespace _5_5_8
{
    internal class Program
    {

        ///Задания с 5.5.5 по 5.5.8
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine(Factorial(20));

            Console.WriteLine(PowerUp(2,2));
        }

        static decimal Factorial(int x)
        {
            if (x == 0)
            {
                return 1;
            }
            else
            {
                return x * Factorial(x - 1);
            }
        }

        private static int PowerUp(int n, byte pow)
        {

            if (pow == 0)
            {
                return 1;

            }
            else if (pow == 1)
            {
                return n;
            }
            else
            {
                return n * PowerUp(n, --pow);
            }
        }
    }
}