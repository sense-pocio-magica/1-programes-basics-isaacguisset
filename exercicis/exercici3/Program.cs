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
        string estocverbose;
        if (estoc == false)
        {
            estocverbose = "no disponible";
        }
        else
        {
            estocverbose = "disponible";
        }
        int compres_ultim_any = 300;

        Console.WriteLine($"El producte {nom} amb preu {preu} el seu estat és: {estocverbose} i té {compres_ultim_any} compres l'últim any.");
    }
}
