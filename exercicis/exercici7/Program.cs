namespace exercici7;

/* Defineix tres variables amb tres notes numèriques. 
Calcula la mitjana i mostra el resultat per pantalla. */ 

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Nota 1");
        var nota1 = Console.ReadLine();
        int nota11 = Convert.ToInt16(nota1);

        Console.WriteLine("Nota 2");
        var nota2 = Console.ReadLine();
        int nota22 = Convert.ToInt16(nota2);

        Console.WriteLine("Nota 3");
        var nota3 = Console.ReadLine();
        int nota33 = Convert.ToInt16(nota3);

        int suma = (nota11 + nota22 + nota33) / 3;
        Console.WriteLine($"La mitjana és: {suma}");
    }
}
