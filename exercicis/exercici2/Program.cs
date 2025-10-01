namespace exercici2;

/* Declara variables per emmagatzemar l’adreça d’una persona: 
carrer, número, codi postal i població. Imprimeix el resultat 
en una sola línia */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Aquest programa serveix per emmagatzemar la teva adreça");
        Console.WriteLine("Introdueix el teu carrer: ");
        var carrer = Console.ReadLine();
        Console.WriteLine("Introdueix el número de carrer: ");
        var numerodecarrer = Convert.ToInt(Console.ReadLine());
        Console.WriteLine("Introdueix el codi postal");
        var codipostal = Convert.ToInt(Console.ReadLine());
        Console.WriteLine("Introdueix la teva població");
        var poblacio = Console.ReadLine();

        Console.WriteLine($"La direcció introduida és carrer {carrer} numero {numerodecarrer},{codipostal}, {poblacio} ");



    }
}
