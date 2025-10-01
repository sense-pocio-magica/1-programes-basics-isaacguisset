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

            double notaArrodonida = Math.Round(notaFinal);

            
            Console.WriteLine($"La nota final és {notaFinal} o sigui un {notaArrodonida}");
        }
    }
}
