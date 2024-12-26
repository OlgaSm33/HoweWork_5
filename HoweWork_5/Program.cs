namespace HoweWork_5
{
    class Program
    {
        static void Main()
        {
            ShowUser(GetUser());
            
        }

        static (string FirstName, string LastName, int Age, string[] PetsName, string[] FavColors) GetUser()
        {
            var User = (FirstName: "", LastName : "",
            Age : 0, PetsName : new string[0], FavColors : new string[0]);

            Console.Write("Введите Ваше имя: ");
            User.FirstName = Console.ReadLine();
            Console.Write("Введите Вашу фамилию: ");
            User.LastName = Console.ReadLine();
            Console.Write("Введите Ваш возраст: ");
            User.Age = CheckNumber();
            Console.Write("Есть ли у Вас домашние питомцы? (Да или Нет): ");
            bool HasPet;
            int PetCount;
            if (Console.ReadLine() == "Да")
                HasPet = true;
            else
                HasPet = false;
            if (HasPet)
            {
                Console.WriteLine("Введите количество Ваших питомцев");
                PetCount = CheckNumber();
                User.PetsName = PetName(PetCount);
                
            }

            int FavColorsCount;
            Console.WriteLine("Введите количество Ваших любимых цветов");
            FavColorsCount = CheckNumber();
            User.FavColors = FavColor(FavColorsCount);
            return User;
        }

        static string[] PetName(int PetCount)
        {
            Console.WriteLine("Введите клички всех Ваших питомцев");
            string[] PetsName = new string[PetCount];
            for (int i = 0; i < PetCount; i++)
            {
                PetsName[i] = Console.ReadLine();
            }
            return PetsName;
        }

        static string[] FavColor(int FavColorsCount)
        {
            Console.WriteLine("Введите все Ваши любимые цвета");
            string[] FavColor = new string[FavColorsCount];
            for (int i = 0; i < FavColorsCount; i++)
            {
                FavColor[i] = Console.ReadLine();
            }
            return FavColor;
        }

        static int CheckNumber()
        {
            int number;
            bool tryNumber = int.TryParse(Console.ReadLine(), out number) && (number > 0);
            while (!tryNumber)
            {
                Console.WriteLine("Вы ввели некорретное число, введите число ещё раз");
                tryNumber = int.TryParse(Console.ReadLine(), out number) && (number > 0);
            }
            return number;


        }

        static void ShowUser((string FirstName, string LastName, int Age, string[] PetsName, string[] FavColors) User)
        {
            Console.WriteLine($"Имя пользователя: {User.Item1}");
            Console.WriteLine($"Фамилия пользователя: {User.Item2}");
            Console.WriteLine($"Возраст пользователя: {User.Item2}");
            if (User.PetsName.Length > 0)
            {
                Console.WriteLine("У пользователя есть домашние животные, их клички:");
                for (int i = 0; i < User.PetsName.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {User.PetsName[i]}");
                }
            }
            else
            {
                {
                    Console.WriteLine("У пользователя нет домашних животных");
                }
            }

            Console.WriteLine("Любимые цвета пользователя:");
            for (int i = 0; i < User.FavColors.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {User.FavColors[i]}");
            }

        }

    }
}
