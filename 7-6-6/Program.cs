namespace _7_6_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    class Record <T1,T2>
    {
        T1? Id = default(T1);
        T2? Value = default(T2);

        DateTime Date; 


    }
}