class Program
{
    static void Main(string[] args)
    {
        Player player = new Player("Maciuś", 100, 50);
        player.AddItem(new Item("Mała Mikstura", 30, 2));
        player.AddItem(new Item("Wielka Mikstura", 60, 1));

        Random rng = new Random();

        List<Enemy> enemies = new List<Enemy>
        {
            new Enemy("Goblin Zwiadowca", 25, 7, "Sztylet", 10, 15),
            new Enemy("Nietoperz Jaskiniowy", 20, 5, "Krycie", 5, 10),
            new Enemy("Ork Wojownik", 70, 16, "Topor", 20, 40),
            new Enemy("Szkielet Wojownik", 45, 12, "Miecz", 15, 25),
            new Enemy("Troll Górski", 100, 22, "Maczuga", 25, 70)
        };

        int defeatedEnemiesCount = 0;
        bool playing = true;

        Console.WriteLine("=== WITAJ NA MINI-ARENIE! ===");

        while (playing && player.IsAlive())
        {
            bool anyEnemyAlive = false;
            foreach (var e in enemies)
            {
                if (e.IsAlive()) anyEnemyAlive = true;
            }

            if (!anyEnemyAlive)
            {
                Console.WriteLine("\nGratulacje! Pokonałeś wszystkich przeciwników na arenie!");
                break;
            }

            Console.WriteLine("\n--- DOSTĘPNI PRZECIWNICY ---");
            for (int i = 0; i < enemies.Count; i++)
            {
                string status = enemies[i].IsAlive() ? $"{enemies[i].Health}/{enemies[i].MaxHealth} HP" : "POKONANY";
                Console.WriteLine($"{i + 1}. {enemies[i].Name} - {status} | Nagroda: {enemies[i].GoldReward} złota");
            }

            Enemy selectedEnemy = null;
            while (selectedEnemy == null)
            {
                Console.Write("\nWybierz numer przeciwnika do walki (lub 0, aby zakończyć grę): ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out int choice))
                {
                    Console.WriteLine("Błąd: Wprowadzono tekst zamiast liczby! Spróbuj ponownie.");
                    continue;
                }

                if (choice == 0)
                {
                    playing = false;
                    break;
                }

                if (choice < 1 || choice > enemies.Count)
                {
                    Console.WriteLine($"Błąd: Numer spoza zakresu (1-{enemies.Count}). Wybierz poprawny numer.");
                    continue;
                }

                Enemy target = enemies[choice - 1];

                if (!target.IsAlive())
                {
                    Console.WriteLine($"Błąd: {target.Name} jest już pokonany! Wybierz żywego przeciwnika.");
                    continue;
                }

                selectedEnemy = target;
            }

            if (!playing) break;

            Console.WriteLine($"\n-> Rozpoczyna się starcie z: {selectedEnemy.Name}!\n");

            int round = 1;
            while (player.IsAlive() && selectedEnemy.IsAlive())
            {
                Console.WriteLine($"=== TURA {round} ===");
                Console.WriteLine($"[Stan] {player.Name}: {player.Health}/{player.MaxHealth} HP | {selectedEnemy.Name}: {selectedEnemy.Health}/{selectedEnemy.MaxHealth} HP");

                Console.WriteLine("\nWybierz akcję:");
                Console.WriteLine("1. Atakuj przeciwnika");
                Console.WriteLine("2. Przyjmij postawę obronną");
                Console.WriteLine("3. Użyj przedmiotu z ekwipunku");
                Console.Write("Twój wybór (1-3): ");

                string actionInput = Console.ReadLine();

                if (actionInput == "1")
                {
                    Console.WriteLine($"\n-> {player.Name} atakuje {selectedEnemy.Name}!");
                    selectedEnemy.TakeDamage(25);
                }
                else if (actionInput == "2")
                {
                    Console.WriteLine($"\n-> {player.Name} przyjmuje postawę obronną!");
                    player.SetDefending(true);
                }
                else if (actionInput == "3")
                {
                    Console.WriteLine();
                    player.ShowInventory();
                    Console.Write("Wybierz numer przedmiotu (0 aby anulować): ");
                    if (int.TryParse(Console.ReadLine(), out int itemIdx) && itemIdx > 0)
                    {
                        player.UseItem(itemIdx - 1);
                    }
                    else
                    {
                        Console.WriteLine("Anulowano użycie przedmiotu.");
                    }
                }
                else
                {
                    Console.WriteLine("\nBłąd: Nieznana akcja! Straciłeś turę.");
                }

                if (!selectedEnemy.IsAlive())
                {
                    Console.WriteLine($"\n[ZWYCIĘSTWO] {selectedEnemy.Name} został pokonany!");
                    Console.WriteLine($"Zyskano {selectedEnemy.GoldReward} złota!");
                    player.Gold += selectedEnemy.GoldReward;
                    player.GainExperience(30);
                    defeatedEnemiesCount++;
                    break;
                }

                Console.WriteLine($"\n-> Tura przeciwnika ({selectedEnemy.Name}):");
                if (rng.Next(1, 101) <= selectedEnemy.DefenseChance)
                {
                    selectedEnemy.SetDefending(true);
                    Console.WriteLine($"{selectedEnemy.Name} przygotowuje obronę!");
                }
                else
                {
                    Console.WriteLine($"{selectedEnemy.Name} wykonuje atak: {selectedEnemy.AttackType}!");
                    selectedEnemy.AttackTarget(player, rng);
                }

                if (!player.IsAlive())
                {
                    Console.WriteLine($"\n[PORAŻKA] {player.Name} poległ w walce...");
                    break;
                }

                Console.WriteLine();
                round++;
            }

            if (player.IsAlive() && playing)
            {
                Console.WriteLine("\nPowrót do menu głównego areny.\n");
            }
        }

        Console.WriteLine("\n========================================");
        Console.WriteLine("       PODSUMOWANIE MINI-ARENY         ");
        Console.WriteLine("========================================");
        Console.WriteLine($"Imię gracza:          {player.Name}");
        Console.WriteLine($"Poziom gracza:        {player.Level}");
        Console.WriteLine($"Doświadczenie:        {player.Experience} XP");
        Console.WriteLine($"Końcowe zdrowie:      {player.Health}/{player.MaxHealth} HP");
        Console.WriteLine($"Posiadane złoto:      {player.Gold} szt.");
        Console.WriteLine($"Liczba pokonanych:    {defeatedEnemiesCount}");
        Console.WriteLine("========================================");
        Console.WriteLine("Dziękujemy za grę!");
    }
}