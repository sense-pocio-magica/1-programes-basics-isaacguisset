namespace exercici1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introdueix el teu nom");
        var nom = Console.ReadLine();
        Console.WriteLine("Introdueix el teu cognom");
        var cognom = Console.ReadLine();
        Console.WriteLine($"Em dic {cognom}, {nom}, {cognom}");
    }
}
