//1
/*
int[] zlotoWTurach = { 5, 12, 0, 8, 15 };

        int suma = 0;
        int turyPowyzejDziesieciu = 0;

        for (int i = 0; i < zlotoWTurach.Length; i++)
        {
            Console.WriteLine($"Tura {i + 1}: {zlotoWTurach[i]} sztuk złota");
            suma += zlotoWTurach[i];

            if (zlotoWTurach[i] >= 10)
            {
                turyPowyzejDziesieciu++;
            }
        }

        double srednia = (double)suma / zlotoWTurach.Length;

        Console.WriteLine();
        Console.WriteLine($"Łącznie: {suma}");
        Console.WriteLine($"Średnio na turę: {srednia:F2}");
        Console.WriteLine($"Tury z wynikiem co najmniej 10: {turyPowyzejDziesieciu}");

        Console.Write("Od końca: ");
        for (int i = zlotoWTurach.Length - 1; i >= 0; i--)
        {
            Console.Write($"{zlotoWTurach[i]} ");
        }

//2
List<string> plecak = new List<string>
        {
            "Miecz",
            "Mikstura",
            "Pochodnia"
        };

        int maksymalnaPojemnosc = 6;

        Console.WriteLine($"Plecak ({plecak.Count}/{maksymalnaPojemnosc}):");
        for (int i = 0; i < plecak.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {plecak[i]}");
        }
        Console.WriteLine();

        Console.Write("Podaj nazwę nowego przedmiotu do podniesienia: ");
        string nowyPrzedmiot = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(nowyPrzedmiot))
        {
            nowyPrzedmiot = "Klucz";
        }

        plecak.Add(nowyPrzedmiot);
        Console.WriteLine($"Znaleziony przedmiot: {nowyPrzedmiot}");
        Console.WriteLine($"Dodano: {nowyPrzedmiot}");
        Console.WriteLine();
        if (plecak.Contains("Mikstura"))
        {
            bool usunieto = plecak.Remove("Mikstura");
            if (usunieto)
            {
                Console.WriteLine("Użyto mikstury.");
            }
        }
        else
        {
            Console.WriteLine("Brak mikstury w plecaku.");
        }
        Console.WriteLine($"Plecak ({plecak.Count}/{maksymalnaPojemnosc}):");
        for (int i = 0; i < plecak.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {plecak[i]}");
        }

//3
Dictionary<string, int> ceny = new Dictionary<string, int>
        {
            { "Mikstura", 15 },
            { "Pochodnia", 5 },
            { "Miecz", 40 }
        };

        Console.WriteLine($"Liczba pozycji w cenniku: {ceny.Count}");
        Console.WriteLine();

        Console.WriteLine("Aktualny cennik:");
        foreach (KeyValuePair<string, int> pozycja in ceny)
        {
            Console.WriteLine($"- {pozycja.Key}: {pozycja.Value} szt. złota");
        }
        Console.WriteLine();

        Console.Write("Wpisz nazwę przedmiotu do sprawdzenia (np. Miecz lub Tarcza): ");
        string szukanyPrzedmiot = Console.ReadLine();

        if (ceny.ContainsKey(szukanyPrzedmiot))
        {
            Console.WriteLine($"Cena przedmiotu '{szukanyPrzedmiot}': {ceny[szukanyPrzedmiot]} szt. złota");
        }
        else
        {
            Console.WriteLine($"Niestety, przedmiotu '{szukanyPrzedmiot}' nie ma w cenniku.");
        }
        Console.WriteLine();

        ceny["Mikstura"] = 12;
        Console.WriteLine("Zmieniono cenę 'Mikstura' na 12.");
        Console.WriteLine();

        Console.WriteLine("Zaktualizowany cennik:");
        foreach (var pozycja in ceny)
        {
            Console.WriteLine($"- {pozycja.Key}: {pozycja.Value} szt. złota");
        }

//4
int liczbaTur = 0;
        while (true)
        {
            Console.Write("Podaj liczbę tur (od 1 do 10): ");
            if (int.TryParse(Console.ReadLine(), out liczbaTur) && liczbaTur >= 1 && liczbaTur <= 10)
            {
                break;
            }
            Console.WriteLine("Nieprawidłowa wartość. Podaj liczbę całkowitą z zakresu od 1 do 10.");
        }

        int[] zlotoWTurach = new int[liczbaTur];

        for (int i = 0; i < liczbaTur; i++)
        {
            while (true)
            {
                Console.Write($"Podaj ilość złota w turze {i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out int zloto) && zloto >= 0)
                {
                    zlotoWTurach[i] = zloto;
                    break;
                }
                Console.WriteLine("Ilość złota nie może być ujemna. Spróbuj ponownie.");
            }
        }

        int suma = zlotoWTurach[0];
        int minimum = zlotoWTurach[0];
        int maksimum = zlotoWTurach[0];
        int pierwszyNajlepszyTura = 1;
        int liczbaTurMaksimum = 1;
        int pierwszaTuraBezZlota = (zlotoWTurach[0] == 0) ? 1 : -1;

        for (int i = 1; i < zlotoWTurach.Length; i++)
        {
            suma += zlotoWTurach[i];

            if (zlotoWTurach[i] < minimum)
            {
                minimum = zlotoWTurach[i];
            }

            if (zlotoWTurach[i] > maksimum)
            {
                maksimum = zlotoWTurach[i];
                pierwszyNajlepszyTura = i + 1; 
                liczbaTurMaksimum = 1;      
            }
            else if (zlotoWTurach[i] == maksimum)
            {
                liczbaTurMaksimum++;         

            if (zlotoWTurach[i] == 0 && pierwszaTuraBezZlota == -1)
            {
                pierwszaTuraBezZlota = i + 1;
            }
        }

        Console.WriteLine();
        Console.WriteLine($"Suma: {suma}");
        Console.WriteLine($"Minimum: {minimum}");
        Console.WriteLine($"Maksimum: {maksimum}");
        Console.WriteLine($"Pierwszy najlepszy wynik: tura {pierwszyNajlepszyTura}");
        Console.WriteLine($"Liczba tur z maksimum: {liczbaTurMaksimum}");

       if (pierwszaTuraBezZlota != -1)
        {
            Console.WriteLine($"Pierwsza tura bez złota: {pierwszaTuraBezZlota}");
        }
        else
        {
            Console.WriteLine("Brak tur bez złota.");
        }
        }

//5
List<string> przedmioty = new List<string>
        {
            "Miecz",
            "Tarcza",
            "Mikstura",
            "Klucz"
        };

        if (przedmioty.Count == 0)
        {
            Console.WriteLine("Lista przedmiotów jest pusta.");
            return;
        }

        WyswietlListe(przedmioty);

        int wybranyIndeks = -1;

        while (true)
        {
            Console.Write("Wybierz przedmiot do usunięcia: ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int numer))
            {
                Console.WriteLine("Wpisz liczbę całkowitą.");
                continue;
            }

            if (numer < 1 || numer > przedmioty.Count)
            {
                Console.WriteLine($"Numer musi należeć do zakresu 1–{przedmioty.Count}.");
                continue;
            }

            wybranyIndeks = numer - 1;
            break;
        }

        string usunietyPrzedmiot = przedmioty[wybranyIndeks];

        przedmioty.RemoveAt(wybranyIndeks);

        Console.WriteLine($"Usunięto: {usunietyPrzedmiot}");
        Console.WriteLine();

        WyswietlListe(przedmioty);
    
    static void WyswietlListe(List<string> lista)
    {
        for (int i = 0; i < lista.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {lista[i]}");
        }
    }

//6
Dictionary<string, int> magazyn = new Dictionary<string, int>
        {
            { "Mikstura", 3 },
            { "Pochodnia", 2 },
            { "Klucz", 1 }
        };

        bool dziala = true;

        while (dziala)
        {
            Console.WriteLine("\n=== SYSTEM ZARZĄDZANIA MAGAZYNEM ===");
            Console.WriteLine("1. Pokaż magazyn");
            Console.WriteLine("2. Przyjmij dostawę");
            Console.WriteLine("3. Wydaj przedmiot");
            Console.WriteLine("4. Usuń pustą pozycję");
            Console.WriteLine("5. Zakończ");
            Console.Write("Wybierz opcję (1-5): ");

            string wybor = Console.ReadLine();
            Console.WriteLine();

            switch (wybor)
            {
                case "1":
                    PokazMagazyn(magazyn);
                    break;
                case "2":
                    PrzyjmijDostawę(magazyn);
                    break;
                case "3":
                    WydajPrzedmiot(magazyn);
                    break;
                case "4":
                    UsunPustaPozycje(magazyn);
                    break;
                case "5":
                    dziala = false;
                    Console.WriteLine("Zakończono działanie programu.");
                    break;
                default:
                    Console.WriteLine("Nieznana opcja. Wybierz liczbę od 1 do 5.");
                    break;
            }
        }

    static void PokazMagazyn(Dictionary<string, int> magazyn)
    {
        if (magazyn.Count == 0)
        {
            Console.WriteLine("Magazyn jest obecnie pusty.");
            return;
        }

        Console.WriteLine("Aktualny stan magazynu:");
        foreach (KeyValuePair<string, int> pozycja in magazyn)
        {
            Console.WriteLine($"- {pozycja.Key}: {pozycja.Value} szt.");
        }
    }

    static void PrzyjmijDostawę(Dictionary<string, int> magazyn)
    {
        Console.Write("Podaj nazwę przedmiotu: ");
        string nazwa = Console.ReadLine().Trim();

        if (string.IsNullOrEmpty(nazwa))
        {
            Console.WriteLine("Błąd: Nazwa przedmiotu nie może być pusta.");
            return;
        }

        Console.Write("Podaj liczbę sztuk do dostarczenia: ");
        if (!int.TryParse(Console.ReadLine(), out int ilosc) || ilosc <= 0)
        {
            Console.WriteLine("Błąd: Liczba sztuk musi być dodatnią liczbą całkowitą większą od 0.");
            return;
        }

        if (magazyn.ContainsKey(nazwa))
        {
            magazyn[nazwa] += ilosc;
            Console.WriteLine($"Sukces: Zwiększono stan przedmiotu '{nazwa}' o {ilosc}. Nowy stan: {magazyn[nazwa]} szt.");
        }
        else
        {
            magazyn.Add(nazwa, ilosc);
            Console.WriteLine($"Sukces: Dodano nowy przedmiot '{nazwa}' w ilości {ilosc} szt.");
        }
    }

    static void WydajPrzedmiot(Dictionary<string, int> magazyn)
    {
        if (magazyn.Count == 0)
        {
            Console.WriteLine("Błąd: Magazyn jest pusty, brak przedmiotów do wydania.");
            return;
        }

        Console.Write("Podaj nazwę przedmiotu do wydania: ");
        string nazwa = Console.ReadLine().Trim();

        if (!magazyn.ContainsKey(nazwa))
        {
            Console.WriteLine($"Błąd odmowy: Przedmiot '{nazwa}' nie istnieje w magazynie.");
            return;
        }

        Console.Write("Podaj liczbę sztuk do wydania: ");
        if (!int.TryParse(Console.ReadLine(), out int ilosc) || ilosc <= 0)
        {
            Console.WriteLine("Błąd: Liczba sztuk musi być dodatnią liczbą całkowitą większą od 0.");
            return;
        }

        if (magazyn[nazwa] < ilosc)
        {
            Console.WriteLine($"Błąd odmowy: Niewystarczający stan magazynowy. Dostępne: {magazyn[nazwa]} szt., żądano: {ilosc} szt.");
            return;
        }

        magazyn[nazwa] -= ilosc;
        Console.WriteLine($"Sukces: Wydano {ilosc} szt. przedmiotu '{nazwa}'. Pozostały stan: {magazyn[nazwa]} szt.");
    }

    static void UsunPustaPozycje(Dictionary<string, int> magazyn)
    {
        if (magazyn.Count == 0)
        {
            Console.WriteLine("Błąd: Magazyn jest pusty.");
            return;
        }

        Console.Write("Podaj nazwę przedmiotu do usunięcia: ");
        string nazwa = Console.ReadLine().Trim();

        if (!magazyn.ContainsKey(nazwa))
        {
            Console.WriteLine($"Błąd odmowy: Przedmiot '{nazwa}' nie istnieje w magazynie.");
            return;
        }

        if (magazyn[nazwa] != 0)
        {
            Console.WriteLine($"Błąd odmowy: Nie można usunąć pozycji '{nazwa}', ponieważ jej stan wynosi {magazyn[nazwa]} szt. (wymagany stan to 0).");
            return;
        }

        magazyn.Remove(nazwa);
        Console.WriteLine($"Sukces: Pusta pozycja '{nazwa}' została usunięta z magazynu.");
    }

//7
List<string> historia = new List<string>();
        bool dziala = true;

        while (dziala)
        {
            Console.WriteLine("\n--- MENU GRY ---");
            Console.WriteLine("1 - Eksploruj");
            Console.WriteLine("2 - Odpocznij");
            Console.WriteLine("3 - Znajdź przedmiot");
            Console.WriteLine("4 - Pokaż całą historię");
            Console.WriteLine("5 - Pokaż ostatnie trzy wpisy");
            Console.WriteLine("6 - Policz wybraną akcję");
            Console.WriteLine("7 - Wyczyść historię");
            Console.WriteLine("8 - Zakończ");
            Console.Write("Wybierz opcję (1-8): ");

            string wybor = Console.ReadLine();
            Console.WriteLine();

            switch (wybor)
            {
                case "1":
                    historia.Add("Eksploracja");
                    Console.WriteLine(">> Wykonano akcję: Eksploracja");
                    break;

                case "2":
                    historia.Add("Odpoczynek");
                    Console.WriteLine(">> Wykonano akcję: Odpoczynek");
                    break;

                case "3":
                    historia.Add("Znaleziono przedmiot");
                    Console.WriteLine(">> Wykonano akcję: Znaleziono przedmiot");
                    break;

                case "4":
                    if (historia.Count == 0)
                    {
                        Console.WriteLine("Historia jest pusta.");
                    }
                    else
                    {
                        Console.WriteLine("Cała historia (od najstarszego):");
                        for (int i = 0; i < historia.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {historia[i]}");
                        }
                    }
                    break;

                case "5":
                    if (historia.Count == 0)
                    {
                        Console.WriteLine("Historia jest pusta.");
                    }
                    else
                    {
                        Console.WriteLine("Ostatnie wpisy (maksymalnie 3):");
                        int start = (historia.Count > 3) ? historia.Count - 3 : 0;
                        for (int i = start; i < historia.Count; i++)
                        {
                            Console.WriteLine($"- {historia[i]}");
                        }
                    }
                    break;

                case "6":
                    if (historia.Count == 0)
                    {
                        Console.WriteLine("Historia jest pusta, brak akcji do policzenia.");
                    }
                    else
                    {
                        Console.Write("Podaj nazwę akcji do policzenia (Eksploracja / Odpoczynek / Znaleziono przedmiot): ");
                        string szukanaAkcja = Console.ReadLine();
                        int licznik = 0;

                        for (int i = 0; i < historia.Count; i++)
                        {
                            if (historia[i] == szukanaAkcja)
                            {
                                licznik++;
                            }
                        }

                        Console.WriteLine($"Akcja '{szukanaAkcja}' wystąpiła w historii {licznik} razy.");
                    }
                    break;

                case "7":
                    Console.Write("Czy na pewno chcesz wyczyścić historię? (t/n): ");
                    string potwierdzenie = Console.ReadLine()?.Trim().ToLower();

                    if (potwierdzenie == "t")
                    {
                        historia.Clear();
                        Console.WriteLine("Historia została wyczyszczona.");
                    }
                    else
                    {
                        Console.WriteLine("Anulowano czyszczenie historii.");
                    }
                    break;

                case "8":
                    dziala = false;
                    Console.WriteLine("Zakończono działanie programu.");
                    break;

                default:
                    Console.WriteLine("Nieznana opcja. Wybierz liczbę od 1 do 8.");
                    break;
            }
        }
*/
//9
Dictionary<string, int> punktyZycia = new Dictionary<string, int>();
        Dictionary<string, int> liczbaPokonanych = new Dictionary<string, int>();

        bool dziala = true;

        while (dziala)
        {
            Console.WriteLine("\n--- ZARZĄDZANIE BESTIARIUSZEM ---");
            Console.WriteLine("1. Dodaj gatunek");
            Console.WriteLine("2. Wyświetl bestiariusz");
            Console.WriteLine("3. Zarejestruj zwycięstwo");
            Console.WriteLine("4. Zmień punkty życia (HP)");
            Console.WriteLine("5. Usuń gatunek");
            Console.WriteLine("6. Wyszukaj gatunek");
            Console.WriteLine("7. Pokaż raport");
            Console.WriteLine("8. Zakończ program");
            Console.Write("Wybierz opcję (1-8): ");

            string wybor = Console.ReadLine();
            Console.WriteLine();

            switch (wybor)
            {
                case "1":
                    DodajGatunek(punktyZycia, liczbaPokonanych);
                    break;
                case "2":
                    WyswietlBestiariusz(punktyZycia, liczbaPokonanych);
                    break;
                case "3":
                    ZarejestrujZwyciestwo(liczbaPokonanych);
                    break;
                case "4":
                    ZmienPunktyZycia(punktyZycia);
                    break;
                case "5":
                    UsunGatunek(punktyZycia, liczbaPokonanych);
                    break;
                case "6":
                    WyszukajGatunek(punktyZycia, liczbaPokonanych);
                    break;
                case "7":
                    PokazRaport(punktyZycia, liczbaPokonanych);
                    break;
                case "8":
                    dziala = false;
                    Console.WriteLine("Zakończono działanie programu.");
                    break;
                default:
                    Console.WriteLine("Nieznana opcja. Wybierz liczbę od 1 do 8.");
                    break;
            }
        }

    static void DodajGatunek(Dictionary<string, int> hpDict, Dictionary<string, int> pokonaneDict)
    {
        Console.Write("Podaj nazwę nowego gatunku: ");
        string nazwa = Console.ReadLine().Trim();

        if (string.IsNullOrEmpty(nazwa))
        {
            Console.WriteLine("Błąd: Nazwa gatunku nie może być pusta.");
            return;
        }

        if (hpDict.ContainsKey(nazwa))
        {
            Console.WriteLine($"Błąd odmowy: Gatunek '{nazwa}' już istnieje w bestiariuszu.");
            return;
        }

        Console.Write("Podaj bazowe punkty życia (HP): ");
        if (!int.TryParse(Console.ReadLine(), out int hp) || hp < 0)
        {
            Console.WriteLine("Błąd: Nieprawidłowa wartość punktów życia.");
            return;
        }

        hpDict.Add(nazwa, hp);
        pokonaneDict.Add(nazwa, 0); 
        Console.WriteLine($"Sukces: Dodano gatunek '{nazwa}' (HP: {hp}, Pokonane: 0).");
    }

    static void WyswietlBestiariusz(Dictionary<string, int> hpDict, Dictionary<string, int> pokonaneDict)
    {
        if (hpDict.Count == 0)
        {
            Console.WriteLine("Bestiariusz jest pusty.");
            return;
        }

        Console.WriteLine("--- AKTUALNY BESTIARIUSZ ---");
        foreach (var kvp in hpDict)
        {
            string nazwa = kvp.Key;
            int hp = kvp.Value;
            int pokonane = pokonaneDict[nazwa];
            Console.WriteLine($"- {nazwa}: HP = {hp}, Pokonane = {pokonane}");
        }
    }

    static void ZarejestrujZwyciestwo(Dictionary<string, int> pokonaneDict)
    {
        if (pokonaneDict.Count == 0)
        {
            Console.WriteLine("Błąd: Bestiariusz jest pusty.");
            return;
        }

        Console.Write("Podaj nazwę pokonanego gatunku: ");
        string nazwa = Console.ReadLine().Trim();

        if (!pokonaneDict.ContainsKey(nazwa))
        {
            Console.WriteLine($"Błąd odmowy: Gatunek '{nazwa}' nie istnieje w bestiariuszu.");
            return;
        }

        pokonaneDict[nazwa]++;
        Console.WriteLine($"Sukces: Zarejestrowano zwycięstwo nad gatunkiem '{nazwa}'. Łącznie pokonano: {pokonaneDict[nazwa]}.");
    }

    static void ZmienPunktyZycia(Dictionary<string, int> hpDict)
    {
        if (hpDict.Count == 0)
        {
            Console.WriteLine("Błąd: Bestiariusz jest pusty.");
            return;
        }

        Console.Write("Podaj nazwę gatunku do edycji HP: ");
        string nazwa = Console.ReadLine().Trim();

        if (!hpDict.ContainsKey(nazwa))
        {
            Console.WriteLine($"Błąd odmowy: Gatunek '{nazwa}' nie istnieje w bestiariuszu.");
            return;
        }

        Console.Write("Podaj nowe punkty życia (HP): ");
        if (!int.TryParse(Console.ReadLine(), out int noweHp) || noweHp < 0)
        {
            Console.WriteLine("Błąd: Nieprawidłowa wartość punktów życia.");
            return;
        }

        hpDict[nazwa] = noweHp;
        Console.WriteLine($"Sukces: Zmieniono HP gatunku '{nazwa}' na {noweHp}.");
    }

    static void UsunGatunek(Dictionary<string, int> hpDict, Dictionary<string, int> pokonaneDict)
    {
        if (hpDict.Count == 0)
        {
            Console.WriteLine("Błąd: Bestiariusz jest pusty.");
            return;
        }

        Console.Write("Podaj nazwę gatunku do usunięcia: ");
        string nazwa = Console.ReadLine().Trim();

        if (!hpDict.ContainsKey(nazwa))
        {
            Console.WriteLine($"Błąd odmowy: Gatunek '{nazwa}' nie istnieje w bestiariuszu.");
            return;
        }

        hpDict.Remove(nazwa);
        pokonaneDict.Remove(nazwa);
        Console.WriteLine($"Sukces: Gatunek '{nazwa}' został całkowicie usunięty z obu słowników.");
    }

    static void WyszukajGatunek(Dictionary<string, int> hpDict, Dictionary<string, int> pokonaneDict)
    {
        if (hpDict.Count == 0)
        {
            Console.WriteLine("Błąd: Bestiariusz jest pusty.");
            return;
        }

        Console.Write("Podaj nazwę szukanego gatunku: ");
        string nazwa = Console.ReadLine().Trim();

        if (!hpDict.ContainsKey(nazwa))
        {
            Console.WriteLine($"Błąd odmowy: Gatunek '{nazwa}' nie został znaleziony w bestiariuszu.");
            return;
        }

        int hp = hpDict[nazwa];
        int pokonane = pokonaneDict[nazwa];
        Console.WriteLine($"Wynik wyszukiwania -> Gatunek: {nazwa} | HP: {hp} | Pokonane: {pokonane}");
    }

    static void PokazRaport(Dictionary<string, int> hpDict, Dictionary<string, int> pokonaneDict)
    {
        if (hpDict.Count == 0)
        {
            Console.WriteLine("Raport: Bestiariusz jest pusty. Brak danych do obliczeń.");
            return;
        }

        int liczbaGatunkow = hpDict.Count;
        int sumaPokonanych = 0;
        int sumaHp = 0;

        foreach (var kvp in hpDict)
        {
            sumaHp += kvp.Value;
        }

        foreach (var kvp in pokonaneDict)
        {
            sumaPokonanych += kvp.Value;
        }

        double sredniaHp = (double)sumaHp / liczbaGatunkow;

        int maxPokonanych = -1;
        foreach (var kvp in pokonaneDict)
        {
            if (kvp.Value > maxPokonanych)
            {
                maxPokonanych = kvp.Value;
            }
        }

        List<string> najczestszeGatunki = new List<string>();
        foreach (var kvp in pokonaneDict)
        {
            if (kvp.Value == maxPokonanych)
            {
                najczestszeGatunki.Add(kvp.Key);
            }
        }

        List<string> niePokonane = new List<string>();
        foreach (var kvp in pokonaneDict)
        {
            if (kvp.Value == 0)
            {
                niePokonane.Add(kvp.Key);
            }
        }

        Console.WriteLine("================ RAPORT Z BESTIARIUSZA ================");
        Console.WriteLine($"- Liczba gatunków: {liczbaGatunkow}");
        Console.WriteLine($"- Łączna liczba pokonanych przeciwników: {sumaPokonanych}");

        if (najczestszeGatunki.Count == 1)
        {
            Console.WriteLine($"- Najczęściej pokonywany gatunek: {najczestszeGatunki[0]} (liczba pokonanych: {maxPokonanych})");
        }
        else if (najczestszeGatunki.Count > 1)
        {
            Console.WriteLine($"- Najczęściej pokonywane gatunki (remis): {string.Join(", ", najczestszeGatunki)} (liczba pokonanych: {maxPokonanych})");
        }

        Console.WriteLine($"- Średnia liczba punktów życia (HP): {sredniaHp:F2}");

        if (niePokonane.Count > 0)
        {
            Console.WriteLine($"- Gatunki, których jeszcze nie pokonano: {string.Join(", ", niePokonane)}");
        }
        else
        {
            Console.WriteLine("- Gatunki, których jeszcze nie pokonano: brak (wszystkie mają co najmniej 1 pokonanego przeciwnika).");
        }
        Console.WriteLine("=======================================================");
    }
