using CRaktarKatalogus;
using System.Threading.Tasks.Dataflow;
Console.WriteLine("=== Raktárkészlet Rögzítése ===");
List<Termék> osszes = new List<Termék>();
for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"{i + 1}. termék addatai:");
    Console.Write($"\tnév: ");
    string nev = Console.ReadLine();
    Console.Write($"\tegységár: ");
    int egysegar = int.Parse(Console.ReadLine());
    Console.Write($"\tRaktárkészlet: ");
    int rakkeszlet = int.Parse(Console.ReadLine());
    Termék ujtermek = new Termék();
    ujtermek.Nev = nev;
    ujtermek.Ar = egysegar;
    ujtermek.Mennyiseg = rakkeszlet;
    osszes.Add(ujtermek);
    Console.WriteLine();
}
double teljesertek = 0;
double atlagar = 0;
int oszdb = 0;
foreach (Termék t in osszes)
{
    teljesertek += t.Ar * t.Mennyiseg;
    oszdb+=t.Mennyiseg;
}
atlagar = teljesertek / oszdb;
Console.WriteLine("Adatok feldolgozása...\n========================================\nRögzített termékek a raktárban:");
foreach (Termék t in osszes)
{
    Console.WriteLine($"\t {t.Nev}:  {t.Ar} Ft/db ({t.Mennyiseg}db)  ---> Érték: {t.Ar * t.Mennyiseg} FT");
}
Console.WriteLine("----------------------------------------");
Console.WriteLine($"A raktárkészlet teljes értéke: {teljesertek} Ft");
Console.WriteLine($"A raktárkészlet átlagos egységára: {atlagar:F2} Ft");
Console.WriteLine("========================================");