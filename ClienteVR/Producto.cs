using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteVR
{
    class Producto
    {
        public int codproducto { get; set; }
        public int codc { get; set; }
        public double precioc { get; set; }
        public double preciov { get; set; }
        public int cantidad { get; set; }
        public string imagen { get; set; }
        public string descripcionp { get; set; }
        public string nombreprod { get; set; }

        public Producto()
        {
            this.codproducto = 0;
            this.codc = 0;
            this.precioc = 0.0;
            this.preciov = 0.0;
            this.cantidad = 0;
            this.imagen = null;
            this.descripcionp = "";
            this.nombreprod = "";
        }
    }
}
