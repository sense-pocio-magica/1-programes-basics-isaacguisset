namespace exercici1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introdueix el teu nom");
        var nom = Console.ReadLine() ?? "0";
        if (nom.Length == 0)
        {
            Console.WriteLine("El teu nom no pot estar buit!! ");
        }
        else
        {

            Console.WriteLine("Introdueix el teu cognom");
            var cognom = Console.ReadLine() ?? "0";
            if (cognom.Length == 0)
            {
                Console.WriteLine("Introdueix alguna cosa ");

            }
            else
            {


                Console.WriteLine($"Em dic {cognom}, {nom}, {cognom}");
            }
        }
    }
}
