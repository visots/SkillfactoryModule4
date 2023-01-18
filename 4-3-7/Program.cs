namespace _4_3_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string name = "Напу Амо Хала Она Она Анека Вехи Вехи Она Хивеа Нена Вава Кехо Онка Кахе Хеа Леке Еа Она Ней Нана Ниа Кеко Оа Ога Ван Ика Ванао"; //Это реальное имя, я загуглил
            string reverseName = "";

            for (int i = name.Length; i!=0; i--)
            {
                reverseName += name[i-1];
            }

            Console.WriteLine(name);
            Console.WriteLine(reverseName);

        }
    }
}