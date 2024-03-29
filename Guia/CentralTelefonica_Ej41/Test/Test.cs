﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CentralTelefonica;


namespace Test
{
    class Test
    {
        static void Main(string[] args)
        {
            // Mi central
            Centralita c = new Centralita("Fede Center");
            // Mis 4 llamadas
            Local l1 = new Local("Bernal", "Rosario",30, 2.65f);
            Provincial l2 = new Provincial("Morón", "Bernal",21,Provincial.Franja.Franja_1);
            Local l3 = new Local("Lanús", "San Rafael",45,1.99f);
            Provincial l4 = new Provincial(Provincial.Franja.Franja_3, l2);
            // Las llamadas se irán registrando en la Centralita.
            // La centralita mostrará por pantalla todas las llamadas según las vaya registrando.
            try
            {
                c += l1;
                //Console.WriteLine(c.Mostrar());
                c += l2;
                //Console.WriteLine(c.Mostrar());
                c += l3;
                //Console.WriteLine(c.Mostrar());
                c += l4;
                //Console.WriteLine(c.Mostrar());
            }
            catch (CentralitaExeption e)
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Error en la clase: " + e.NombreClase);
                Console.WriteLine("Error en el metodo: " + e.NombreMetodo);
                Console.WriteLine(e.Message);
                Console.WriteLine("------------------------------------");
            }

            c.OrdenarLlamadas();
            Console.WriteLine();
            Console.WriteLine("Llamadas ordenadas por duracion");
            Console.WriteLine();
            Console.WriteLine(c.Mostrar());
            Console.ReadKey();
        }
    }
}
