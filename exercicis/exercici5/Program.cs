namespace exercici5;

/* Feu un programa que demani un nom i l’any de naixement i imprimeixi per pantalla 
“Hola [nom]!  Ja tens [edat] anys? 
nom i edat seran el nom introduït i l'edat la resta de l’any actual i l’any de naixement. */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introdueix el teu nom");
        var nom = Console.ReadLine();
        Console.WriteLine("Introdueix el teu any de naixament");
        var any_naix = Convert.ToInt16(Console.ReadLine());
        int anyactual = 2025;
        var edat = anyactual - any_naix;
        Console.WriteLine($"Hola {nom}! ja tens {edat} anys ");


    }
}
