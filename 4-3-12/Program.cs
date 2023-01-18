namespace _4_3_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };

            for (int i = 0; i < arr.Length; i++)
                for (int k = i + 1; k < arr.Length; k++)
                {
                    if (arr[i] > arr[k])
                    {
                        int temp = arr[i];
                        arr[i] = arr[k];
                        arr[k] = temp;
                    }
                }

            foreach (int item in arr)
            {
                Console.Write(item);
            }
        }
    }
}