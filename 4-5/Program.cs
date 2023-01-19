namespace _4_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Итоговая модуля 4
            Console.WriteLine("Hello, World!");

            (string Name,
                string LastName,
                string Login, 
                int LoginLength,
                bool HasPet,
                string[] favcolors,
                double Age) User;


            for (int i = 1;i<4;i++)
            {
                Console.WriteLine("Пользователь №:"+i);
                
                Console.Write("\tВведите имя: ");
                User.Name = Console.ReadLine();
                
                Console.Write("\tВведите фамилию: ");
                User.LastName = Console.ReadLine();
                
                
                Console.Write("\tВведите логин: ");
                User.Login = Console.ReadLine();

                Console.Write("\tВведите ваш возраст: ");
                User.Age = Convert.ToDouble(Console.ReadLine());

                Console.Write("\tЕсть ли у вас животные? (Да/Нет): ");
                User.HasPet = (Console.ReadLine() == "Да") ? true : false;

                User.LoginLength = User.Login.Length;

                Console.Write("\tТри ваших любимых цвета через запятую:");
                User.favcolors = Console.ReadLine().Split(',');

            }
            Console.ReadKey();
        }
    }
}