namespace exercici15;

// Assigna un nom i un cognom en variables. Imprimeix el nom complet, 
// assegurant-te que la primera lletra de cada paraula estigui en majúscula
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Nom");
        var nom = Console.ReadLine();

        Console.WriteLine("Cognom");
        var cognom = Console.ReadLine();
        
        var inicial = nom.Substring(0, 1).ToUpper() + nom.Substring(1).ToLower();
        var inicialcognom = cognom.Substring(0, 1).ToUpper() + cognom.Substring(1).ToLower();

        Console.WriteLine($"Nom : {inicial} {inicialcognom}" );

    }
}
