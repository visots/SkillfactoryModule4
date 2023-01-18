namespace _4_3_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var arr = new int[] { 5, 6, 9, 1, 2, 3, 4, -1, 22, -10, 12, -4 };

            int positiveNumCount = 0;

            for (int i = 0; i < arr.Length; i++)
                if (arr[i]>0)
                    positiveNumCount++;

            Console.WriteLine(positiveNumCount.ToString());
        }
    }
}