namespace exercici16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nota de pràctiques: ");
            double practiques = double.Parse(Console.ReadLine() ?? "0");

            Console.Write("Nota de l'examen: ");
            double examen = double.Parse(Console.ReadLine() ?? "0");

            double notaFinal = practiques * 0.3 + examen * 0.7;

            double notaDecimal = Math.Round(notaFinal * 10) / 10.0;

            // no sé com hem de calcular la nota  :/

            Console.WriteLine($"La nota final és {notaDecimal} o sigui un {notaEntera}");
        }
    }
}
