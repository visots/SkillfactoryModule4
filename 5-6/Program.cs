namespace _5_6
{
    internal class Program
    {
        //Итоговый проект 5-6
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var userProfile = AskUser();
            ShowUserProfile(userProfile);
            Console.ReadKey();
        }

        static (string Name, string LastName, int Age, string[] PetNames, string[] FavColors) AskUser()
        {
            (string Name, string LastName, int Age, string[] PetNames, string[] FavColors) User = ("", "", 0, new string[] { }, new string[] { });

            Console.Write("Введите имя: ");
            User.Name = Console.ReadLine();

            Console.Write("Введите фамилию: ");
            User.LastName = Console.ReadLine();

            Console.Write("Введите ваш возраст: ");
            User.Age = CheckAge();

            Console.Write("Есть ли у вас питомцы (Да\\Нет):");
            if (CheckYesNo())
            {
                Console.Write("\t Сколько у вас питомцев?:");
                int petsCount = Convert.ToInt32(Console.ReadLine());

                Console.Write("\tВведите клички питомцев через запятую:");
                User.PetNames = Console.ReadLine().Split(',');
            }

            Console.Write("Есть ли у вас любимые цвета?: ");
            if (CheckYesNo())
            {
                Console.Write("\t Сколько у вас любимых цветов?:");
                int colorsCount = Convert.ToInt32(Console.ReadLine());

                Console.Write("\tТри ваших любимых цвета через запятую:");
                User.FavColors = Console.ReadLine().Split(',');
            }

            return User;
        }

        static void ShowUserProfile((string Name, string LastName, int Age, string[] PetNames, string[] FavColors) User)
        {
            Console.WriteLine();
            Console.WriteLine("Имя: " + User.Name);
            Console.WriteLine("Фамилия " + User.LastName);
            Console.WriteLine("Возраст " + User.Age);

            if (User.PetNames.Length > 0)
            {
                Console.WriteLine("Имена питомцев:");
                foreach (var pet in User.PetNames)
                    Console.WriteLine("\t" + pet);
            }
            else
                Console.WriteLine("Одинок");

            if (User.FavColors.Length > 0)
            {
                Console.WriteLine("Любимые цвета:");
                foreach (var color in User.FavColors)
                    Console.WriteLine("\t" + color);
            }
            else
                Console.WriteLine("Депрессивен");

        }

        static bool CheckYesNo()
        {
            string input = Console.ReadLine();

            while (input != "Да" && input != "Нет")
            {
                Console.Write("Введите Да или Нет: ");
                input = Console.ReadLine();
            }

            if (input == "Да")
                return true;
            else
                return false;

        }

        static int CheckAge()
        {
            var input = Console.ReadLine();

            int res = 0;
            bool inNum = Int32.TryParse(input, out res);

            while ((res < 3 || res > 100) || !inNum)
            {
                Console.Write("\tВведите число от 3 до 99:");
                inNum = Int32.TryParse(Console.ReadLine(), out res);
            }

            return res;
        }
    }
}