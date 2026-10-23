//1
using System.ComponentModel.DataAnnotations;
string imie1="Wiktor";
char znak='@';
int poziom=12;
int zloto=123;
double waga=7;
bool mapa1=true;
Console.WriteLine("=== EKWIPUNEK ===");
Console.WriteLine($"Imię(string): {imie1}");
Console.WriteLine($"Znak(char): {znak}");
Console.WriteLine($"Poziom(int): {poziom}");
Console.WriteLine($"Złoto(int): {zloto}");
Console.WriteLine($"Waga(double): {waga}");
Console.WriteLine($"Mapa(bool): {mapa1}");






//2
int exp=20;
int gold=50;
Console.WriteLine($"Bohater ma {gold} złota i {exp} expa.");
exp +=25;
exp *= 2;
gold -=8;
gold +=15;
int trening=0;
int y=++trening;
Console.WriteLine($"Bohater ma {gold} złota i {exp} expa po treningu i ma {y} trening za sobą.");




//3
int racje=53;
int czlonkowie=4;
int dni=5;

Console.WriteLine($"Racje: {racje}");
Console.WriteLine($"Członkowie: {czlonkowie}");
Console.WriteLine($"Dni wyprawy: {dni}");

int racje_na_osobe=racje / czlonkowie;
Console.WriteLine($"Pełne racje na każdego członka: {racje_na_osobe}");

int racje_po_podziale=racje % czlonkowie;
Console.WriteLine($"Ile zostanie po podziale: {racje_po_podziale}");

int racje_na_dzien=racje/(czlonkowie*dni);
Console.WriteLine($"Na dzień na członka: {racje_na_dzien}");

double sr_racja=(double)racje/(czlonkowie*dni);
Console.WriteLine($"Średnia: {sr_racja}");




//4

Console.Write("Podaj ile punkty życia ");
int hp1 = int.Parse(Console.ReadLine()!);

Console.Write("Podaj ile mikstur ");
int mikstury = int.Parse(Console.ReadLine()!);

bool klucz=true;
bool mapa=false;

bool zyje1=(hp1>0);
bool mapelnezycie1=(hp1==100);
bool wymagaLeczenia=zyje1 && !mapelnezycie1;
bool mazaopatrzenie=(mikstury>0);
bool maPrzedmiotNawigacyjny= klucz || mapa;
bool gotowyDoWyprawy=  zyje1 && mazaopatrzenie && maPrzedmiotNawigacyjny;

Console.WriteLine($"Żyje: {zyje1}"); 
Console.WriteLine($"Ma pełne zdrowie: {mapelnezycie1}"); 
Console.WriteLine($"Wymaga leczenia: {wymagaLeczenia}");  
Console.WriteLine($"Ma zaopatrzenie: {mazaopatrzenie}");  
Console.WriteLine($"Ma klucz lub mapę: {maPrzedmiotNawigacyjny}"); 
Console.WriteLine($"Gotowy do wyprawy:  {gotowyDoWyprawy}"); 





//5
Console.Write("Podaj imie ");
string imie = Console.ReadLine()!;

Console.Write("Podaj ile maks punkty życia ");
double hp = int.Parse(Console.ReadLine()!);

Console.Write("Podaj ile ma hp teraz ");
double hpteraz = int.Parse(Console.ReadLine()!);

Console.Write("Podaj ile damage zadaje broń ");
int bron = int.Parse(Console.ReadLine()!);

Console.Write("Podaj premie do siły ");
int sila = int.Parse(Console.ReadLine()!);

Console.Write("Podaj mnożnik do ataku specjalnego ");
double mnoznik = double.Parse(Console.ReadLine()!);

Console.Write("Ile wykonałeś ataków ");
int ileatk = int.Parse(Console.ReadLine()!);

int atak= bron+sila;

int atkspe= (int)(atak*mnoznik);

int zadanydmg = (atak*ileatk)+atkspe;

double procenthp= (hpteraz/hp)*100;

bool zyje=(hp>0);

bool mapelnezycie=(hpteraz==100);

Console.WriteLine("========== RAPORT Z WALKI ==========");
Console.WriteLine($"Bohater: {imie}"); 
Console.WriteLine($"Zdrowie: {hpteraz}/100 ({procenthp}%)"); 
Console.WriteLine($"Zwykły atak: {atak}");  
Console.WriteLine($"Atak specjalny: {atkspe}");  
Console.WriteLine($"Zadany dmg: {zadanydmg}"); 
Console.WriteLine($"Żyje:  {zyje}");
Console.WriteLine($"Pełne zdrowie:  {mapelnezycie}");
Console.WriteLine("====================================");