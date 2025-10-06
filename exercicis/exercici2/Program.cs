namespace exercici2;

/* Declara variables per emmagatzemar l’adreça d’una persona: 
carrer, número, codi postal i població. Imprimeix el resultat 
en una sola línia */

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Carrer");
        var carrer = Console.ReadLine();

        Console.WriteLine("Número");
        var Número = Console.ReadLine();

        Console.WriteLine("Codi Postal");
        var Codi_Postal = Console.ReadLine();

        Console.WriteLine("Població");
        var Població = Console.ReadLine();

        Console.WriteLine($"Dades: Carrer - {carrer} , Número - {Número} , Codi Postal - {Codi_Postal} , Població - {Població } ");

    }
}
