namespace exercici4
{
    /* Un avi encara no sap quin és el valor de les coses perquè a tot arreu li parlen d’euros, 
    però ell s’ha negat a canviar i encara té un pot ple de monedes de pesseta.
    Necessita un programa amb el qual posi el valor de l'article que vol comprar en 
    euros i li digui quin és el valor en les antigues pessetes.
    Nota: 1 euro = 166.386 pessetes i les pessetes no tenien cap decimal. */

    class Program
    {
        static void Main()
        {
            const double CONVERSIO = 166.386; 

            Console.Write("Hola avi, introdueix el valor en euros: ");
            string input = Console.ReadLine();

            if (double.TryParse(input, out double euros)) // comprova que sigui un número valid
            {
                int pessetes = (int)Math.Round(euros * CONVERSIO); // les pessetes no tenen decimals per tant fem mathround
                Console.WriteLine($"{euros}€ equivalen a {pessetes} pessetes.");
            }
            else
            {
                Console.WriteLine("Has d'introduir un número vàlid.");
            }
        }
    }
}
