namespace _6_2_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    class Rectangle
    {
        int a;
        int b;

        public Rectangle()
        {
            a = 6;
            b = 4;
        }

        public Rectangle(int a, int b)
        {

        }

        public Rectangle(int a)
        {
            this.a = a;
            b = a;
        }

        public int Square(int a, int b) => a * b;

    }
}