﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
    /*14. Realizar una clase llamada CalculoDeArea que posea 3 métodos de clase (estáticos) que realicen el
    cálculo del área que corresponda:
    a. double CalcularCuadrado(double)
    b. double CalcularTriangulo(double, double)
    c. double CalcularCirculo(double)
    El ingreso de los datos como la visualización se deberán realizar desde el método Main().*/
    public class CalculoDeArea
    {
        public static double CalcularCuadrado(double lado)
        {
            return Math.Pow(lado, 2);
        }

        public static double CalcularCirculo(double radio)
        {
            return (Math.PI * Math.Pow(radio, 2));
        }

        public static double CalcularTriangulo(double lado1, double lado2)
        {
            return ((lado1 * lado2) / 2);
        }
    }
}
