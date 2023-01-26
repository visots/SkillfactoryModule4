namespace _5_5_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                Console.Write("Напишите что-то: ");
                var str = Console.ReadLine();

                Console.Write("Укажите глубину эха: ");
                var deep = int.Parse(Console.ReadLine());

                Echo(str, deep);

                Console.ReadKey();
            }

            static void Echo(string phrase, int deep)
            {
                string modif = phrase;
                if (modif.Length > 2)
                    modif = modif.Remove(0, 2);

                Console.BackgroundColor = (ConsoleColor)deep;
                Console.WriteLine("..." + modif);

                if (deep > 1)
                {
                    Echo(modif, deep - 1);
                }
            }
        }
    }
}