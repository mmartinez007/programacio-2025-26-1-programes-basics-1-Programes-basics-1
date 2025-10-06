namespace exercici8;

/* Assigna un nombre total de minuts a una variable. 
Calcula quantes hores senceres i minuts restants són i imprimeix el resultat. */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Cuants munits?");
        var minuts = Console.ReadLine();
        int minutsint = Convert.ToInt32(minuts);

        int hores = minutsint / 60;
        int minutsrestans = minutsint % 60;
        Console.WriteLine($"Són {hores} hores i {minutsrestans} minuts");
    }
}
