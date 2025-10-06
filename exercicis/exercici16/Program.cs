namespace exercici16;

/* Ningú entén res del nou sistema d’avaluació. Necessitem un programa que calculi la part que és més senzilla: 
a partir de la mitjana de les notes les pràctiques i la nota de l’examen ens calculi la nota final

Nota de pràctiques: 8 (40%)
Nota de l’examen: 9   (60%)
La nota final és 8.7 o sigui un 9

*/

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("La meva nota de practiques");
        var examen = Console.ReadLine();
        int nota1 = Convert.ToInt32(examen);

        Console.WriteLine("La meva nota d'examen");
        var practiques = Console.ReadLine();
        int nota2 = Convert.ToInt32(practiques);

        double res = nota1 * 0.4 + nota2 * 0.6;
        double res2 = Math.Truncate(res);

        Console.WriteLine("La meva nota és: " + (nota1 * 0.3 + nota2 * 0.7) + " o sigui un " + res2);

    }
}
