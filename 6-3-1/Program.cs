namespace _6_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var department = GetCurrentDepartment();

            if(department?.Company?.Type == "Банк" && department?.City?.Name == "Санкт-Петербург")
            {
                string compName = department?.Company?.Name ?? "Неизвестная компания";
                Console.WriteLine($"У банка {compName} есть отделение в {department?.City?.Name}");
            }    
        }

        static Department GetCurrentDepartment()
        {
            return new Department();

        }

        class Company
        {

            public string Type;
            public string Name;
        }

        class Department
        {
            public Company Company;
            public City City;
        }

        class City
        {
            public string Name;
        }
    }

    
}