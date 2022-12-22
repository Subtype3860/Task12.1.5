namespace Task;

class Program
{
    public static void Main()
    {
        var users = new List<User>
        {
            new() { Login = "ivanov", Name = "Иват", IsPremium = true },
            new(){Login = "sidorov", Name = "Сидр", IsPremium = false},
            new(){Login = "bulbul_agly", Name = "Илья", IsPremium = true},
            new(){Login = "chelyabinsk", Name = "Анастасия", IsPremium = false},
            new(){Login = "Yuuto_Shimoto", Name = "Yuuto", IsPremium = true}
        };
        Console.WriteLine("Укажите логин");
        var login = Console.ReadLine();
        var log = false;
        var user = new User();
        foreach (var us in users)
        {
            if (login!.ToLower().Equals(us.Login!.ToLower()))
            {
                user = us;
                log = true;
            }
        }
        if (user.IsPremium && log)
        {
            Console.WriteLine($"Преветствую {user.Name}");
        }
        else
        {
            ShowAds();
            Console.WriteLine($"Преветствую {login}");
        }
    }
    private static void ShowAds()
    {
        Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
        // Остановка на 1 с
        Thread.Sleep(1000);

        Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
        // Остановка на 2 с
        Thread.Sleep(2000);

        Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
        // Остановка на 3 с
        Thread.Sleep(3000);
    }
}