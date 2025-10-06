namespace exercici11;

// A partir de dues variables (nom d'usuari i domini), crea i imprimeix una adreça de correu electrònic completa.
class Program
{
    static void Main(string[] args)
    {
         Console.WriteLine("Nom d'usuari");
        var nom = Console.ReadLine();

        Console.WriteLine("Domini");
        var domini = Console.ReadLine();

        Console.WriteLine($"La teva adreça és : {nom}@{domini}");

    }
}
