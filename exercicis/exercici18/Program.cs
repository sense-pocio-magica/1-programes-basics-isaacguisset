namespace exercici18
/* Un rellotger està perdent la memòria i necessita un programa que a partir de l'hora actual li puguem dir
 quina hora serà d’aquí un nombre determinat d’hores.

Hora actual: 9
Hores a incrementar: 3
D'aquí a 3 hores seran les 12


Hora actual: 11
Hores a incrementar: 3
D'aquí a 3 hores seran les 2
*/



{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hora actual: ");
            int hora_actual = Convert.ToInt16(Console.ReadLine());

            Console.Write("Hores a incrementar: ");
            int hores_a_incrementar = Convert.ToInt16(Console.ReadLine());

            // utilitzem el modul
            int hora_final = (hora_actual + hores_a_incrementar) % 24;

            Console.WriteLine($"D'aquí a {hores_a_incrementar} hores seran les {hora_final}");
        }
    }
}
