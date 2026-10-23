using System.ComponentModel.DataAnnotations;

//1
Console.Write("Podaj liczbe ");
int liczba = int.Parse(Console.ReadLine()!);
int czyparz =liczba %2;
if (czyparz == 0){
    Console.WriteLine("Liczba jest parzysta");
}
else
{
    Console.WriteLine("Liczba nie jest parzysta");
}








//2 

Console.Write("Podaj kierunek ");
string kierunek = Console.ReadLine()!;

switch (kierunek)
{
    case "północ":
        Console.WriteLine("Idziesz w stronę gór.");
        break;
    case "południe":
        Console.WriteLine("Idziesz w stronę pustyni.");
        break;
    case "wschód":
        Console.WriteLine("Idziesz w stronę lasu.");
        break;
    case "zachód":
        Console.WriteLine("Idziesz w stronę morza.");
        break;
    default:
        Console.WriteLine("Nieznany kierunek.");
        break;
}









//3
Console.Write("Podaj wiek ");
int wiek = int.Parse(Console.ReadLine()!);

if (wiek < 0)
{
    Console.WriteLine("Niepoprawny wiek");
    
}
else if (wiek <= 12)
{
    Console.WriteLine("Dziecko");
   
} 
else if (wiek <= 17)
{
    Console.WriteLine("Nastolatek");
   
} 
else if (wiek <= 64)
{
    Console.WriteLine("Dorosły");
   
}
else
{
    Console.WriteLine("Senior");
}







//4
Console.Write("Podaj hp ");
int hp = int.Parse(Console.ReadLine()!);
Console.Write("Czy znasz hasło ");
string haslo = Console.ReadLine()!;
bool znahaslo=(haslo=="tak");
Console.Write("Czy masz klucz ");
string klucz = Console.ReadLine()!;
bool czymaklucz=(klucz=="tak");
if (hp > 0 && (znahaslo || czymaklucz))
{
    Console.Write("Może wejść ");
}
else
{
    Console.Write("Nie może wejść ");
}








//5
Console.Write("Podaj hp ");
int hp = int.Parse(Console.ReadLine()!);
Console.Write("Podaj dmg ataku ");
int atk = int.Parse(Console.ReadLine()!);
Console.Write("Czy masz miksture ");
string miksture = Console.ReadLine()!;
bool czymamiksture=(miksture=="tak");
if (hp <= 0)
{
    Console.Write("Nie żyjesz ");
}
else
{
    if (hp <= 20)
    {
        Console.WriteLine("Masz mało hp ");
    
    Console.Write("1-atak, 2-leczenie, 3-ucieczka ");
    int akcja = int.Parse(Console.ReadLine()!);

switch (akcja)
{
    case 1:
        Console.WriteLine($"Zadałeś {atk} obrażeń");
        break;
    case 2:
            if (czymamiksture)
            {
                Console.WriteLine("Uleczyłeś się");
            }
            else
            {
                Console.WriteLine("Nie masz mikstury");
            }
        break;
    case 3:
        Console.WriteLine("Uciekłeś");
        break;
    default:
        Console.WriteLine("Nieznany akcja");
        break;
}
    }
    else
    {
            Console.Write("1-atak, 2-leczenie, 3-ucieczka ");
    int akcja = int.Parse(Console.ReadLine()!);
        switch (akcja)
{
    case 1:
        Console.WriteLine($"Zadałeś {atk} obrażeń");
        break;
    case 2:
            if (czymamiksture)
            {
                Console.WriteLine("Uleczyłeś się");
            }
            else
            {
                Console.WriteLine("Nie masz mikstury");
            }
        break;
    case 3:
        Console.WriteLine("Uciekłeś");
        break;
    default:
        Console.WriteLine("Nieznany akcja");
        break;
}
    }
}