namespace exercici9;

/* Demana un valor en metres. Converteix el valor a peus (1 metre = 3,28084 metres) 
i imprimeix el resultat. */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introdueix el valor en metres per tal de convertir-lo a peus");
        var metres = Convert.ToInt32(Console.ReadLine());
        double peu = 3.28084;
        var resultat = metres * peu;
        Console.WriteLine(resultat);
    }
}
