 //1       
    /*    
        
        Console.WriteLine(" 1. Pętla while (1 do 10)");
        int i = 1;
        while (i <= 10)
        {
            Console.Write(i + " ");
            i++;
        }
        Console.WriteLine("\n");


        Console.WriteLine("2. Pętla do-while (1 do 10)");
        i = 1; 
        do
        {
            Console.Write(i + " ");
            i++;
        } while (i <= 10);
        Console.WriteLine("\n");

        Console.WriteLine("3. Pętla for (1 do 10)");
        for (int j = 1; j <= 10; j++)
        {
            Console.Write(j + " ");
        }
        Console.WriteLine("\n");
        Console.Write("Rosnąco: ");
        for (int j = 1; j <= 10; j++)
        {
        Console.Write(j + " ");
        }
        Console.WriteLine();

        Console.Write("Malejąco: ");
        for (int j = 10; j >= 1; j--)
        {
            Console.Write(j + " ");
        }
        Console.WriteLine();

        Console.Write("Parzyste: ");
        for (int j = 0; j <= 20; j += 2)
        {
            Console.Write(j + " ");
        }
        Console.WriteLine();

        Console.WriteLine("Start!");
    




//2

        Console.Write("Ile dni trwa wyprawa? ");
        int liczbaDni = int.Parse(Console.ReadLine());

        int sumaZlota = 0;
        int dniPowyzej10 = 0;

        for (int dzien = 1; dzien <= liczbaDni; dzien++)
        {
            Console.Write($"Złoto w dniu {dzien}: ");
            int zlotoDnia = int.Parse(Console.ReadLine());

            sumaZlota += zlotoDnia;

            if (zlotoDnia > 10)
            {
                dniPowyzej10++;
            }
        }

        Console.WriteLine();
        Console.WriteLine($"Łącznie znaleziono: {sumaZlota} sztuk złota.");
        Console.WriteLine($"Dni z wynikiem powyżej 10: {dniPowyzej10}.");





//3

Console.Write("Podaj wysokość choinki (od 2 do 10): ");
        int wysokosc = int.Parse(Console.ReadLine());

        for (int i = 0; i < wysokosc; i++)
        {
            for (int s = 0; s < wysokosc - 1 - i; s++)
            {
                Console.Write(" ");
            }

            for (int g = 0; g < 2 * i + 1; g++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }

        for (int s = 0; s < wysokosc - 1; s++)
        {
            Console.Write(" ");
        }
        Console.WriteLine("*");




//4

int tury = 0;

        while (true)
        {
            Console.Write("Podaj liczbę tur od 1 do 10: ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out tury))
            {
                Console.WriteLine("Wpisz liczbę całkowitą.");
                continue; 
            }

            if (tury < 1)
            {
                Console.WriteLine("Liczba musi należeć do zakresu 1–10.");
                continue; 
            }

            if (tury > 10)
            {
                Console.WriteLine("Liczba musi należeć do zakresu 1–10.");
                continue; 
            }

            break;
        }

        Console.WriteLine($"Rozpoczynam grę na {tury} tury.");

        for (int i = 1; i <= tury; i++)
        {
            Console.WriteLine($"Trwa tura nr {i}");
        }
*/


//5


int zdrowieBohatera = 50;
        int zdrowiePrzeciwnika = 45;
        int liczbaMikstur = 2;
        int numerTury = 1;
        bool ucieczka = false;

        Random losowanie = new Random();

        while (zdrowieBohatera > 0 && zdrowiePrzeciwnika > 0 && !ucieczka)
        {
            Console.WriteLine($"Tura {numerTury}");
            Console.WriteLine($"Zdrowie bohatera: {zdrowieBohatera} | Zdrowie przeciwnika: {zdrowiePrzeciwnika} | Mikstury: {liczbaMikstur}");

            Console.WriteLine("Wybierz akcję:");
            Console.WriteLine("1. Atak");
            Console.WriteLine("2. Mikstura");
            Console.WriteLine("3. Ucieczka");

            string akcja = Console.ReadLine();
            bool poprawnaAkcja = true; 

            switch (akcja)
            {
                case "1":
                    int obrazeniaBohatera = losowanie.Next(8, 16);
                    zdrowiePrzeciwnika -= obrazeniaBohatera;
                    Console.WriteLine($"Bohater atakuje i zadaje {obrazeniaBohatera} dmg");
                    break;

                case "2":
                    if (liczbaMikstur > 0)
                    {
                        zdrowieBohatera += 15;
                        liczbaMikstur--;
                        Console.WriteLine("Bohater wypija miksturę i odzyskuje 15 hp.");
                    }
                    else
                    {
                        Console.WriteLine("Nie masz już żadnych mikstur. Wybierz inną akcję.");
                        poprawnaAkcja = false; 
                    }
                    break;

                case "3":
                    ucieczka = true;
                    Console.WriteLine("-> Uciekasz z pola walki");
                    break;

                default:
                    Console.WriteLine("Nieznana opcja. Wybierz 1, 2 lub 3.");
                    poprawnaAkcja = false; 
                    break;
            }

            if (ucieczka)
            {
                break;
            }

            if (zdrowiePrzeciwnika <= 0)
            {
                break;
            }

            if (poprawnaAkcja)
            {
                int obrazeniaPrzeciwnika = losowanie.Next(4, 10);
                zdrowieBohatera -= obrazeniaPrzeciwnika;
                Console.WriteLine($"Przeciwnik kontratakuje i zadaje {obrazeniaPrzeciwnika} dmg.");
                
                numerTury++;
            }
        }

        if (ucieczka)
        {
            Console.WriteLine("Ucieczka. Walka została przerwana.");
        }
        else if (zdrowiePrzeciwnika <= 0 && zdrowieBohatera > 0)
        {
            Console.WriteLine("Zwycięstwo. Pokonałeś przeciwnika.");
        }
        else if (zdrowieBohatera <= 0)
        {
            Console.WriteLine("Porażka. Zostałeś pokonany przez przeciwnika.");
        }
        else
        {
            Console.WriteLine("Koniec gry.");
        }