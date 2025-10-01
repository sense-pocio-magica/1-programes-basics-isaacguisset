namespace exercici12;

/* Fes un programa que a partir de dos números imprimeixi per pantalla la seva suma, la seva resta, 
la seva multiplicació i la seva divisió

Entra el primer número: 3
Entra el segon número: 4

4 + 3 = 7
4 - 3 = 1
4 * 5 = 12
4 / 3 = 1  i en sobra 1


Entra el primer número: 25
Entra el segon número: 5

25 + 5 = 30
25 - 5 = 20
25 * 5 = 125
25 / 5 = 5  i en sobra 0
*/


// He afegit un try catch per tal d'evitar que el programa peti quan l'usuari introdueixi  un valor no esperat com un string 
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Aquest programa a partir de dos números retorna la seva suma, la seva resta, la seva multiplicació i la seva divisió");
        Console.WriteLine("Introdueix el primer número");
        try
        {
            var a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introdueix el segon número");
            var b = Convert.ToInt32(Console.ReadLine());
            var suma = a + b;
            var resta = a - b;
            var multiplicacio = a * b;
            var divisio = a / b;
            var divisio_resta = a % b;

            Console.WriteLine($"{a} + {b} = {suma}");
            Console.WriteLine($"{a} - {b} = {resta}");
            Console.WriteLine($"{a} * {b} = {multiplicacio}");
            Console.WriteLine($"{a} / {b} = {divisio} i en sobra {divisio_resta}");
        }
        catch (Exception)
        {
            Console.WriteLine("Aixó que has introduit no és un número");
        }


    }

}
