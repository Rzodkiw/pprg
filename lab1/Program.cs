//1
using System.ComponentModel.DataAnnotations;

Console.Write("Wiktor   ");
Console.WriteLine("Informatyka");
Console.WriteLine("Chce sie nauczyć ");

//2
string imie = "Wiktor";
int wiek= 19;
string gra = "Diaboł płacze 3";

Console.WriteLine("+--------------------------+");
Console.WriteLine("|        WIZYTÓWKA         |");
Console.WriteLine("+--------------------------+");
Console.WriteLine($"| Imię: {imie}             |");
Console.WriteLine($"| Wiek: {wiek}                 |");
Console.WriteLine($"| Gra: {gra}     |");
Console.WriteLine("+--------------------------+");





//3
Console.Write("Jak masz na imię? ");
string imie1 = Console.ReadLine()!;

Console.Write("Jaki jest Twój ulubiony kolor? ");
string kolor = Console.ReadLine()!;

Console.WriteLine($"Cześć, {imie1}! Twój ulubiony kolor to {kolor}.");




//4
Console.Write("Podaj wiek: ");
string wiekza = Console.ReadLine()!;
int wiek1 = int.Parse(wiekza);

Console.WriteLine($"Za rok będziesz mieć {wiek1 + 1} lat.");
Console.WriteLine($"Za 5 lat będziesz mieć {wiek1 + 5} lat.");



//5
Console.Write("Podaj ile km masz do przejścia: ");
int ilekm = int.Parse(Console.ReadLine()!);

Console.Write("Podaj ile km idziesz w ciągu dnia: ");
int ileidzie = int.Parse(Console.ReadLine()!);

int podroz = ilekm / ileidzie;
Console.WriteLine($"Tyle masz km: {ilekm}");
Console.WriteLine($"Z takim tempę idziesz: {ileidzie}");
Console.WriteLine($"Twoja podróż zajmie {podroz} dni");


//6
Console.Write("Podaj ile masz miedzianych monet: ");
int miedz = int.Parse(Console.ReadLine()!);

Console.Write("Podaj ile masz srebnych monet: ");
int srebro = int.Parse(Console.ReadLine()!);

Console.Write("Podaj ile masz złotych monet: ");
int zloto = int.Parse(Console.ReadLine()!);

int suma= (zloto*100)+(srebro*10)+miedz;
Console.WriteLine($"Tyle masz miedziaków: {suma}.");




//7
Console.Write("Ile chcesz zrobić potek? ");
int potki = int.Parse(Console.ReadLine()!);

int krysztal =potki*3;
int ziolo = potki*2;
Console.WriteLine($"Aby zrobić {potki} potek potrzebujesz {krysztal} kryształów i {ziolo} ziół.");



//8
Console.Write("Cena za nocy ");
decimal nocleg = decimal.Parse(Console.ReadLine()!);

Console.Write("Na ile chcesz zostać nocy ");
int noc = int.Parse(Console.ReadLine()!);

decimal suma1= nocleg*noc;

Console.WriteLine($"Koszt za nocleg wyniesie {suma1}");





//9
Console.Write("Podaj ile sekund ");
int czas = int.Parse(Console.ReadLine()!);

int min = czas/60;
int sek = czas%60;
Console.WriteLine($"{min} minuty i {sek} sekundy.");




//10
Console.Write("Podaj ile monet za zabicie bossa ");
int boss = int.Parse(Console.ReadLine()!);

Console.Write("Podaj ilu graczy ");
int gracz = int.Parse(Console.ReadLine()!);

int loot = boss/gracz;
int loot2= boss%gracz;

Console.WriteLine($"Po uczciwym podziale gracz dostanie: {loot} monet, a pozostanie {loot2} monet.");




//11
Console.Write("Podaj ile dmg zadajesz ");
int dmg = int.Parse(Console.ReadLine()!);

Console.Write("Podaj jaką masz premie do siły ");
int premia = int.Parse(Console.ReadLine()!);

int atk = dmg+premia;
int specjalny = atk*2;
int combo = (atk*3)+specjalny;
Console.WriteLine($"Atak zwykły: {atk} dmg");
Console.WriteLine($"Atak specjalny: {specjalny} dmg");
Console.WriteLine($"Combo: {combo} dmg");







//12
Console.Write("Jak ma na imię twój bohater? ");
string imie2 = Console.ReadLine()!;

Console.Write("Jak nazywa sie kraina? ");
string kraina = Console.ReadLine()!;

Console.Write("Długość twojej wyprawy ");
int wyprawa = int.Parse(Console.ReadLine()!);

Console.Write("Ilość zdobytego doświadczenia ");
decimal exp = decimal.Parse(Console.ReadLine()!);

Console.Write("Ilość zdobytego złota ");
decimal gold = decimal.Parse(Console.ReadLine()!);

decimal sr_exp = exp/wyprawa;
decimal sr_gold = gold/wyprawa;

Console.WriteLine("+--------------------------+");
Console.WriteLine("|        Gracz             |");
Console.WriteLine("+--------------------------+");
Console.WriteLine($"| Imię: {imie2}             |");
Console.WriteLine($"| Kraina: {kraina}                 |");
Console.WriteLine($"| Dni wyprawy: {wyprawa}     |");
Console.WriteLine($"| Exp: {exp}     |");
Console.WriteLine($"| Złoto: {gold}     |");
Console.WriteLine("+--------------------------+");
Console.WriteLine($"| Śr_Expa: {sr_exp}     |");
Console.WriteLine($"| Śr_Złota: {sr_gold}     |");
Console.WriteLine("+--------------------------+");