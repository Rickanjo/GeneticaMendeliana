Console.WriteLine("--- Genética Mendeliana ---");

Console.Write("Alelos do indivíduo 1 (AA, Aa ou aa)...: ");
string alelosIndividuo1 = Console.ReadLine()!;

Console.Write("Alelos do indivíduo 2 (AA, Aa ou aa)...: ");
string alelosIndividuo2 = Console.ReadLine()!;

Console.Write("Tipo de dominância (C/I)...............: ");
char tipoDominancia = Console.ReadKey().KeyChar;
Console.WriteLine();

Console.WriteLine();
Console.WriteLine("  | A  |  a");
Console.WriteLine("-----------");
Console.WriteLine($"a | {alelosIndividuo1} | {alelosIndividuo2}");
Console.WriteLine("-----------");

int probabilidadeAA = 0;
int probabilidadeAa = 0;
int probabilidadeaa = 0;

if (tipoDominancia == 'C')
{
    if (alelosIndividuo1 == "aa" && alelosIndividuo2 == "aa")
    {
        probabilidadeaa = 100;
    }
    else if (alelosIndividuo1 == "aa" || alelosIndividuo2 == "aa")
    {
        probabilidadeaa = 100;
    }
}
else if (tipoDominancia == 'I')
{
    if (alelosIndividuo1 == "AA" && alelosIndividuo2 == "AA")
    {
        probabilidadeAA = 100;
    }
    else if (alelosIndividuo1 == "aa" && alelosIndividuo2 == "aa")
    {
        probabilidadeaa = 100;
    }
    else
    {
        probabilidadeAa = 50;
        probabilidadeaa = 50;
    }
}

Console.WriteLine($"AA:  {probabilidadeAA}% - não apresenta a característica recessiva");
Console.WriteLine($"Aa:  {probabilidadeAa}% - não apresenta a característica recessiva");
Console.WriteLine($"aa:  {probabilidadeaa}% - apresenta a característica recessiva");
        
    


