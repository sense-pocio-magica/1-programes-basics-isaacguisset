namespace exercici15;

// Assigna un nom i un cognom en variables. Imprimeix el nom complet, 
// assegurant-te que la primera lletra de cada paraula estigui en majúscula
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introdueix el teu nom");
        var nom = Console.ReadLine();
        Console.WriteLine("Introdueix el teu cognom");
        var cognom = Console.ReadLine();
        string nomconvertit = nom.Substring(0, 1).ToUpper() + nom.Substring(1).ToLower(); 
        string cognomconvertit = cognom.Substring(0, 1).ToUpper() + cognom.Substring(1).ToLower();
        Console.WriteLine($"El nom abans del format el nom era {nom}, i el cognom era {cognom}");
        Console.WriteLine($"El nom convertit és {nomconvertit}, el cognom convertit es {cognomconvertit}");

    }
}
