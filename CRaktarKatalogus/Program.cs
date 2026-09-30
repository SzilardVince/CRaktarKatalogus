using CRaktarKatalogus;
    Console.WriteLine("=== Raktárkészlet Rögzítése ===");
List<Termék> osszes = new List<Termék>();
for(int i=0;i<3;i++)
{
    Console.WriteLine($"{i+1}. termék addatai:");
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
