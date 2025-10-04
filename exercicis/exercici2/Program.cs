namespace exercici2;

/* Declara variables per emmagatzemar l’adreça d’una persona: 
carrer, número, codi postal i població. Imprimeix el resultat 
en una sola línia */

class Program
{
    static void Main(string[] args)
    {
        var carrer = "narcis munturiol";
        var n_carrer = 5;
        var codipostal = 17600;
        var poblacio = "Figueres";

        Console.WriteLine($"La direcció introduida és carrer {carrer} numero {n_carrer},{codipostal}, {poblacio} ");



    }
}
