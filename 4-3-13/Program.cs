namespace _4_3_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };

            int arrSum = 0;

            for(int i = 0; i < arr.Length; i++)
                arrSum += arr[i];

            Console.WriteLine(arrSum);
        }
    }
}