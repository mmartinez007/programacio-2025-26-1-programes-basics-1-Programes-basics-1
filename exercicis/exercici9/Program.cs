namespace exercici9;

/* Demana un valor en metres. Converteix el valor a peus (1 metre = 3,28084 metres) 
i imprimeix el resultat. */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Metres");
        var metres = Console.ReadLine();
        int metresInt = Convert.ToInt16(metres);

        int peus = metresInt * 328084;
        Console.WriteLine($"Peus : {peus}");
    }
}
