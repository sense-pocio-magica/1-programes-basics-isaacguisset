namespace exercici11;

// A partir de dues variables (nom d'usuari i domini), crea i imprimeix una adreça de correu electrònic completa.
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introdueix el teu nom d'usuari: ");
        var nom_usuari = Console.ReadLine();
        Console.WriteLine("Introdueix el teu domini: ");
        var domini = Console.ReadLine();
        var correu = nom_usuari + "@"  + domini;
        Console.WriteLine($"La teva direcció de correu és {correu}");

    }
}
