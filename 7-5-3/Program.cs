namespace _7_5_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int num1 = 3;
            int num2 = 5;

            Helper.Swap(ref num1, ref num2);

            Console.WriteLine(num1 +" "+ num2);

        }
    }

    class Helper
    {
        public static void Swap(ref int x, ref int y)
        {
            int a = x;
            x= y;
            y= a;
        }
    }
}