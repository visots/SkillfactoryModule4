

namespace _7_5_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int n = 5;

            int[] arr = new int[] { 1, 3, -5, 2, -1, 8 };

            foreach (int i in arr)
            {
                Console.WriteLine(i.GetNegative() +" " + i.GetPositive());
            }
        }
    }

    static class IntExtensions
    {
        public static int GetNegative(this int value)
        {
            return value < 0 ? value : -value;
        }

        public static int GetPositive(this int value)
        {
            return value > 0 ? value : -value;
        }


    }
}