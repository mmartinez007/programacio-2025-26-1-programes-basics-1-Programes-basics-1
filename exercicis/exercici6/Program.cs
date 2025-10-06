namespace exercici6;

/* Declara una variable per al costat d'un quadrat. Calcula el seu perímetre (suma dels quatre costats) 
i imprimeix-lo. */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Costat del cuadrat");
        var costat = Console.ReadLine();
        int costat1 = Convert.ToInt16(costat);

        int cuadrat = 4;

        int suma_costats = costat1 * cuadrat;
        Console.WriteLine($"El perímetre és : {suma_costats}");

    }
}
