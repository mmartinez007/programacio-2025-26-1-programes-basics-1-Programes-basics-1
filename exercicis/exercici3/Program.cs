namespace exercici3;

/* Defineix quatre variables per al nom d’un producte, el seu preu 
i si està en estoc o no. Imprimeix la informació de forma clara. */
class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Producte");
        var producte = Console.ReadLine();

        Console.WriteLine("Preu");
        var preu = Console.ReadLine();

        Console.WriteLine("Està en estoc?");
        var estoc = Console.ReadLine();
        
        Console.WriteLine($"Dades del producte : Producte - {producte} , Preu - {preu} , Estoc? {estoc} ");

    }
}
