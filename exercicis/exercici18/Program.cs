namespace exercici18;

/* Un rellotger està perdent la memòria i necessita un programa que a partir de l'hora actual li puguem dir
 quina hora serà d’aquí un nombre determinat d’hores.

Hora actual: 9
Hores a incrementar: 3
D'aquí a 3 hores seran les 12


Hora actual: 11
Hores a incrementar: 3
D'aquí a 3 hores seran les 2
*/ 

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hora actual");
        var hora = Console.ReadLine();
        int horaactual = Convert.ToInt32(hora);

        Console.WriteLine("Hores a incrementar");
        var hores = Console.ReadLine();
        int horesincrementar = Convert.ToInt32(hores);

        Console.WriteLine("D'aquí a " + horesincrementar + " hores seran les " + (horaactual + horesincrementar)    % 12); 
    }
}
