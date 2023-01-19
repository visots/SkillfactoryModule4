namespace _4_4_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            
            (string Name, string Type, double Age, int NameCount) Pet;

            Console.Write("Имя питомца: ");
            Pet.Name = Console.ReadLine();
            Pet.NameCount = Pet.Name.Length;
            
            Console.Write("Вид питомца: ");
            Pet.Type = Console.ReadLine();

            Console.Write("Возраст питомца: ");
            Pet.Age = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Имя вашего питомца " + Pet.Name);
            Console.WriteLine("Ваш питомец " + Pet.Type);
            Console.WriteLine("Его возраст " + Pet.Age);
            Console.WriteLine("К сведению, число букв в его имени: "+ Pet.NameCount);
        }
    }
}