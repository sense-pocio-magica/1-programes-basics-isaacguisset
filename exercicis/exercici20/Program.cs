namespace exercici20;

/* Ens cal un programa que quan li entrem un número de tres xifres i ens retorni 
el número amb els dígits invertits. 

Ex. 245 -> 542
Entra el número a invertir: 347
El número invertit és: 743
*/


    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entra el número a invertir: ");
            string numero = Console.ReadLine() ?? "0";

            char[] digitos = numero.ToCharArray();
            Array.Reverse(digitos);

            string numeroInvertido = new string(digitos);

            Console.WriteLine($"El número invertit és: {numeroInvertido}");
        }
    }


