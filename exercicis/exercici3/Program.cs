namespace exercici1;

/* Defineix quatre variables per al nom d’un producte, el seu preu 
i si està en estoc o no. Imprimeix la informació de forma clara. */
class Program
{
    static void Main()
    {
        var nom = "Ratolí ThunderX3";
        double preu = 35.99;
        bool estoc = false;
        int compres_ultim_any = 300;
        string estocverbose = estoc ? "disponible" : "no disponible"; // no he utilitzat un if else ja que en un boolea no te gaire sentit i tenim aquesta expressió
        // més ràpido

    Console.WriteLine($"El producte {nom} amb preu {preu} el seu estat és: {estocverbose} i té {compres_ultim_any} compres l'últim any.");
    }
}
