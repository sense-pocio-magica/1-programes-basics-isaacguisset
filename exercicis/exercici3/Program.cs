namespace exercici3;

/* Defineix quatre variables per al nom d’un producte, el seu preu 
i si està en estoc o no. Imprimeix la informació de forma clara. */
class Program
{
    static void Main(string[] args)
    {
        var nom = "Ratolí ThunderX3";
        float preu = 35.99;
        bool estoc = false;
        if (estoc == false)
        {
            var estocverbose = "disponible";
        }
        else
        {
            var estocverbose = "no disponible";
        }
        float compres_ultim_any = 300;
        Console.WriteLine($"El producte {nom} amb preu {preu} esta {estocverbose} i té {compres_ultim_any} compres l'últim any.");


    }
}
