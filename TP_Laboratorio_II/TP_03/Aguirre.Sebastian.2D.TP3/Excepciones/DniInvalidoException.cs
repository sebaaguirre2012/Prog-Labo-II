﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class DniInvalidoException : Exception
    {
        #region Campos

        private static string mensajeBase = "Dni invalido.";

        #endregion

        #region Metodos

        public DniInvalidoException()
            : this(mensajeBase)
        {
            
        }

        public DniInvalidoException(Exception e)
            : this(mensajeBase, e)
        {

        }


        public DniInvalidoException(string mensaje)
            : base(mensaje)
        {

        }


        public DniInvalidoException(string mensaje, Exception e)
            : base(mensaje, e)
        {

        }

        #endregion
    }
}
