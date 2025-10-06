namespace exercici5;

/* Feu un programa que demani un nom i l’any de naixement i imprimeixi per pantalla 
“Hola [nom]!  Ja tens [edat] anys? 
nom i edat seran el nom introduït i l'edat la resta de l’any actual i l’any de naixement. */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Nom");
        var nom = Console.ReadLine();

        Console.WriteLine("Any de naixement");
        var edat = Console.ReadLine();
        int any_naixement = Convert.ToInt16(edat);

        int any_actual = 2025;

        int resta = any_actual - any_naixement;
        Console.WriteLine($"Hola {nom}! Ja tens {resta} anys?");


    }
}
