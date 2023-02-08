namespace _7_2_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }


    class IndexingClass
    {
        private int[] array;

        public IndexingClass(int[] array)
        {
            this.array = array;
        }

        public int this [int index]
        {
            get
            {
                return array[index];   
            }
            private set
            {
                array[index] = value;
            }
        }
    }
}