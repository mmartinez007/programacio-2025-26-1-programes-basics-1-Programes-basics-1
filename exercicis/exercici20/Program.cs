namespace exercici20;

/* Ens cal un programa que quan li entrem un número de tres xifres i ens retorni 
el número amb els dígits invertits. 

Ex. 245 -> 542
Entra el número a invertir: 347
El número invertit és: 743
*/

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Numero:");
        var num = Console.ReadLine();
        string Dig1 = num.Substring(0, 1);
        string Dig2 = num.Substring(1, 1);
        string Dig3 = num.Substring(2);
        Console.WriteLine("El número invertit és: " + (Dig3) + (Dig2) + (Dig1));
    }
}
