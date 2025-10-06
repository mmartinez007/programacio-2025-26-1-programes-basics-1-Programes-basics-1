namespace exercici4;

/* Un avi encara no sap quin és el valor de les coses perquè a tot arreu li parlen d’euros, 
però ell s’ha negat a canviar i encara té un pot ple de monedes de pesseta.
Necessita un programa amb el qual posi el valor de l'article que vol comprar en 
euros i li digui quin és el valor en les antigues pessetes
Nota: 1 euro = 166.386 pessetes i les pessetes no tenien cap decimal */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Preu del article en €?");
        var euros = Console.ReadLine();
        int euros1 = Convert.ToInt16(euros);

        int pessetes1 = 166386;

        int multiplicació = euros1 * pessetes1;
        Console.WriteLine($"Són {multiplicació} pessetes");
    }
}
