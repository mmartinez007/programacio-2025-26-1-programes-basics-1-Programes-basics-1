namespace exercici12;

/* Fes un programa que a partir de dos números imprimeixi per pantalla la seva suma, la seva resta, 
la seva multiplicació i la seva divisió

Entra el primer número: 3
Entra el segon número: 4

4 + 3 = 7
4 - 3 = 1
4 * 5 = 12
4 / 3 = 1  i en sobra 1


Entra el primer número: 25
Entra el segon número: 5

25 + 5 = 30
25 - 5 = 20
25 * 5 = 125
25 / 5 = 5  i en sobra 0
*/



class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Primer num");
        var num = Console.ReadLine();
        int numInt = Convert.ToInt16(num);

        Console.WriteLine("Segon num");
        var num2 = Console.ReadLine();
        int numInt2 = Convert.ToInt16(num2);

        int suma = numInt + numInt2;
        int resta = numInt - numInt2;
        int multiplicació = numInt * numInt2;
        int divisió = numInt / numInt2;

        Console.WriteLine($"Suma : {suma} , Resta : {resta} , Multiplicació : {multiplicació} , Divisió : {divisió}");

    }
}
