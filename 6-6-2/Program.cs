namespace _6_6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    class User
    {
        private int age;

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                if (value < 18)
                {
                    Console.WriteLine("Возраст должен быть не меньше 18");
                }
                else
                {
                    age = value;
                }
            }
        }

        private string _login;

        public string Login
        {
            get { return _login; }
            set
            {
                if (value.Length < 3)
                    _login = value;
                else
                    Console.WriteLine("Логин должен содержать не менее трёх символов");
            }
        }

        private string _email;

        public string Email
        {
            get { return _email; }
            set
            {
                if (value.Contains('@'))
                    _email = value;
                else
                    Console.WriteLine("Введите корректный почтовый адрес");
            }
        }

    }
}