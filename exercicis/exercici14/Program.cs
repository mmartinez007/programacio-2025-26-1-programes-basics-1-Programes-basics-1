namespace exercici14;

// Declara una paraula i fes que el programa imprimeixi només la primera lletra, l'última lletra i la lletra del mig 
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Paraula per analitzar");
        var paraula = Console.ReadLine();

        Console.WriteLine($"La primera lletra és: " + paraula[0]);
        Console.WriteLine($"La lletra del mig és: " + paraula[paraula.Length / 2]);
        Console.WriteLine($"La ultima lletra és: " + paraula[paraula.Length - 1]);
    }

}
