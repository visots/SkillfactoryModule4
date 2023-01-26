namespace _5_2_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = GetArrayFromConsole();
            ShowArray(result, true);
        }

        static int[] GetArrayFromConsole(int arrLength = 5)
        {
            var result = new int[arrLength];

            Console.WriteLine($"Введите {arrLength} цифр через запятую:");

            var userValues = Console.ReadLine().Split(',');

            for (int i = 0; i < userValues.Length; i++)
                result[i] = Int32.Parse(userValues[i]);



            return result;
        }

        static int[] SortArray(int[] arr)
        {
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

            return arr;
        }

        static void ShowArray(int[] arr, bool isSort = false)
        {
            if (isSort)
                arr = SortArray(arr);

            foreach (var el in arr)
                Console.Write(el);
            Console.WriteLine();
        }
    }
}