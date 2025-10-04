
/* Hi ha una secta d’adoradors dels decimals que volen que els hi feu un programa que a partir d’un nombre real, 
ex. 4.56, només ens retorni els decimals, 0,56. Als números que només tenen decimals els anomenen “nombres meravellosos”

Número lleig: 23,45
Nombre meravellós: 0,45


Número lleig: 8,5
Nombre meravellós: 0,5
*/

namespace exercici17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introdueix un número: ");
            double nombrelleig = double.Parse(Console.ReadLine());

            double nombremaravellos = nombrelleig - Math.Floor(nombrelleig);

            nombremaravellos = Math.Round(nombremaravellos, 2);

            Console.WriteLine($"El número lleig és {nombrelleig}");
            Console.WriteLine($"Nombre meravellós: {nombremaravellos:F2}");
        }
    }
}

