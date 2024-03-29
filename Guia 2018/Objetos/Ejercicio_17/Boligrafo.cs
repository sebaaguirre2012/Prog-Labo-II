﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_17
{
    /*a. La cantidad máxima de tinta para todos los bolígrafos será de 100. Generar una constante
    en el Boligrafo llamada cantidadTintaMaxima donde se guardará dicho valor.
    b. Generar los métodos GetColor y GetTinta para los correspondientes atributos (sólo
    retornarán el valor del mismo).
    
    d. Recargar() colocará a tinta en su nivel máximo de tinta. Reutilizar código.
    e. En el Main, crear un bolígrafo de tinta azul (ConsoleColor.Blue) y una cantidad inicial de tinta
    de 100 y otro de tinta roja (ConsoleColor.Red) y 50 de tinta.
    f. El método Pintar(int, out string) restará la tinta gastada (reutilizar código SetTinta), sin
    poder quedar el nivel en negativo, avisando si pudo pintar (nivel de tinta mayor a 0).
    También informará mediante el out string tantos "*" como haya podido "gastar" del nivel de
    tinta. O sea, si nivel de tinta es 10 y gasto es 2 valdrá "**" y si nivel de tinta es 3 y gasto es
    10 "***".
    g. Utilizar todos los métodos en el Main.
    h. Al utilizar Pintar, si corresponde, se deberá dibujar por pantalla con el color de dicho
    bolígrafo.
    Nota: Crear el constructor que crea conveniente. La clase Boligrafo y el Program deben estar en
    namespaces distintos*/
    class Boligrafo
    {
        #region Fields

        private const short cantidadTintaMaxima = 100;
        private short tinta;
        private ConsoleColor color;

        #endregion

        #region Methods

        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color;
        }

        public short GetTinta()
        {
            return this.tinta;
        }

        public ConsoleColor GetColor()
        {
            return this.color;
        }

        /// <summary>
        /// c. Generar el método privado SetTinta que valide el nivel de tinta y asigne en el atributo.
        /// i.tinta será el valor a agregar de tinta, pudiendo ser positivo(cargar tinta) o negativo
        /// (gastar tinta)
        /// ii.Se deberá validar que el nivel de tinta quede entre los valores válidos mayor o igual a
        /// 0 y menor o igual a cantidadTintaMaxima.
        /// </summary>
        private void SetTinta(short tinta)
        {
            int aux = this.GetTinta() + tinta;
            if (aux < 0)
                this.tinta = 0;
            else if (aux > 100)
                this.tinta = cantidadTintaMaxima;
            else
                this.tinta = (short)aux;
        }

        public void Recargar()
        {
            this.SetTinta(cantidadTintaMaxima);
        }

        public bool Pintar(int gasto, out string dibujo)
        {
            dibujo = "";
            return true;
        }

        #endregion
    }
}
