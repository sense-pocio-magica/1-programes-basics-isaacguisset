namespace exercici14;

// Declara una paraula i fes que el programa imprimeixi només la primera lletra, l'última lletra i la lletra del mig 
class Program
{
    static void Main(string[] args)
    {
        var paraula = "pastanaga";
        char primercaracter = paraula[0];
        char caracterdelmig = paraula[paraula.Length / 2];
        char caracterfinal = paraula[paraula.Length - 1];
        Console.WriteLine($"El primer caràcter és {primercaracter}, el caràcter del mig és {caracterdelmig} i el caràcter del final és {caracterfinal}");
    }
}

