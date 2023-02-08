namespace _6_3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    class Bus
    {
        public int? Load;

        public void PrintStatus()
        {
            if(Load.HasValue)
                Console.WriteLine("Количество пассажиров "+Load.Value);
            else
                Console.WriteLine("Автобус пуст");
            
        }
    }
}