﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahorcado
{
    public class BaseAhorcado
    {
        public string Nombre { get; set; }
        public string Palabra { get; set; }
        public string LetrasIncorrectas { get; set; }
        public string LetrasCorrectas { get; set; }
        public int Vidas { get; set; }
        public string PalabraIngresada { get; set; }
    }
}