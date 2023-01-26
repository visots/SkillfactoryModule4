namespace _5._3._13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int[] array = new int[] { 3, 5, 1, 7, 9 };

            int[] sortedAsc = new int[] { };
            int[] sortedDesc = new int[] { };
            SortArray( array,out sortedAsc, out sortedDesc);
            
            ShowArray(sortedAsc);
            ShowArray(sortedDesc);

        }

        static void SortArray(in int[] array,out int [] sortedAsc,out int [] sortedDesc)
        {
            sortedDesc = SortArrayDesc(array);
            sortedAsc = SortArrayAsc(array);
        }

        static int[] SortArrayAsc(int[] arr)
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

        static int[] SortArrayDesc(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                for (int k = i + 1; k < arr.Length; k++)
                {
                    if (arr[i] < arr[k])
                    {
                        int temp = arr[i];
                        arr[i] = arr[k];
                        arr[k] = temp;
                    }
                }
            return arr;
        }

        static void ShowArray(int[] arr)
        {
            foreach (var el in arr)
                Console.Write(el);
            Console.WriteLine();
        }
    }
}