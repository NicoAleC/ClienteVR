﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteVR
{
    class Cliente
    {
        public int codUsuario {get; set; }
        public string nombre { get; set; }
        public string password { get; set; }
        public int ci { get; set; }
        public string tipo { get; set; }
        public string stuff { get; set; }
        public string admi { get; set; }

        public Cliente()
        {
            this.codUsuario = 0;
            this.nombre = "";
            this.password = "";
            this.ci = 0;
            this.tipo = "";
            this.stuff = "";
            this.admi = "";
        }
    }
}
