﻿using System;
namespace exercici4;

/* Un avi encara no sap quin és el valor de les coses perquè a tot arreu li parlen d’euros, 
però ell s’ha negat a canviar i encara té un pot ple de monedes de pesseta.
Necessita un programa amb el qual posi el valor de l'article que vol comprar en 
euros i li digui quin és el valor en les antigues pessetes
Nota: 1 euro = 166.386 pessetes i les pessetes no tenien cap decimal */


class Program
{
    static void Main()
    {
        Console.Write("Introdueix el valor en euros: ");
        string input = Console.ReadLine();

        if (double.TryParse(input, out double euros)) // comprovar que sigui un numero per evitar que el codi peti
        {
            int pessetes = (int)Math.Round(euros * 166.386); // utilitzo math round perque les pesetes no tenen decimals
            Console.WriteLine($"{euros}€ equivalen a {pessetes} pessetes");
        }
        else
        {
            Console.WriteLine("Has d'introduir un número vàlid.");
        }

    }
}