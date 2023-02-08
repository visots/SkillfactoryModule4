namespace _7_2_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    class Obj
    {
        public int Value;

        public static Obj operator + (Obj a, Obj b)
        {
            return new Obj { Value = a.Value + b.Value };
        }

        public static Obj operator  - (Obj a, Obj b)
        {
            return new Obj { Value = a.Value - b.Value };
        }
    }
}