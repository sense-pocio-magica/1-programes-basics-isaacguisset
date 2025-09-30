namespace exercici7;

/* Defineix tres variables amb tres notes numèriques. 
Calcula la mitjana i mostra el resultat per pantalla. */ 

class Program
{
    static void Main(string[] args)
    {
        double n_matematiques = 5.50;
        double n_angles = 3.50;
        double n_basedades = 7;
        var suma = n_matematiques + n_angles + n_basedades;
        var mitjana = suma / 3;
        Console.WriteLine($"La mitjana és {mitjana}");
    }
}
