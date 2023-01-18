namespace _4_2_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Цикл while");
            int k = 0;
            int lim = 0;//-1;

            while (k < lim)
            {
                Console.WriteLine(k);

                Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
                SelectColor();

                k++;
            }

            Console.WriteLine("Цикл do");
            int t = 0;

            do
            {
                Console.WriteLine(t);

                Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
                SelectColor();

                t++;
            } while (t < lim);
        }

        static void SelectColor()
        {
            switch (Console.ReadLine())
            {
                case "red":
                    //Console.BackgroundColor = ConsoleColor.Red;
                    //Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is red!");
                    break;

                case "green":
                    //Console.BackgroundColor = ConsoleColor.Green;
                    //Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is green!");
                    break;
                case "cyan":
                    //Console.BackgroundColor = ConsoleColor.Cyan;
                    //Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is cyan!");
                    break;
                default:
                    //Console.BackgroundColor = ConsoleColor.Yellow;
                    //Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Your color is yellow!");
                    break;
            }
        }
    }
}
