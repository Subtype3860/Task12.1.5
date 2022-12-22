# Task12.1.5

Для списка пользователей добавьте приветствие по имени. Если пользователь не имеет премиум-подписки, то ему нужно показать рекламу.

Класс пользователей:

	class User
	{
		public string Login { get; set; }
		public string Name { get; set; }
		public bool IsPremium { get; set; }
	}

В качестве метода для показа рекламы вы можно использовать:

	static void ShowAds()
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
