﻿namespace exercici8;

/* Assigna un nombre total de minuts a una variable. 
Calcula quantes hores senceres i minuts restants són i imprimeix el resultat. */

class Program
{
    static void Main(string[] args)
    {
        var minuts = 120;
        var hores_minut = 60;
        var hores = minuts / hores_minut;
        var minutsrestants = minuts % hores_minut;
        Console.WriteLine($"{hores} hores i  {minutsrestants} minuts");
    }
}
