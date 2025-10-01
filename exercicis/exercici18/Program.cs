namespace exercici18;

/* Un rellotger està perdent la memòria i necessita un programa que a partir de l'hora actual li puguem dir
 quina hora serà d’aquí un nombre determinat d’hores.

Hora actual: 9
Hores a incrementar: 3
D'aquí a 3 hores seran les 12


Hora actual: 11
Hores a incrementar: 3
D'aquí a 3 hores seran les 2
*/ 

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hora actual: ");
        var hora_actual = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Hores a incrementar: ");
        var hores_a_incrementar = Convert.ToInt16(Console.ReadLine());
        var hores_diaries = 24;
        if (hora_actual + hores_a_incrementar >= 24)
        {
            var hora_final = hora_actual + hores_a_incrementar - hores_diaries;
            Console.WriteLine(hora_final);
        }
        else
        {
            var hora_final = hora_actual + hores_a_incrementar;
            Console.WriteLine(hora_final);
        }

    }
}
