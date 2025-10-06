namespace exercici10;

/* Declara dues variables: una per al nom i una altra per l’any de naixement. 
Combina-les per crear una contrasenya bàsica (per exemple, Pere i 1982 -> Pere1982). 
Imprimeix la contrasenya generada (i sobretot no la facis servir mai que és molt dolenta) */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Nom");
        var nom = Console.ReadLine();

        Console.WriteLine("Any_Naixement");
        var any_naixement = Console.ReadLine();

        Console.WriteLine($"La teva passwd és : {nom}{any_naixement}");

    }
}
