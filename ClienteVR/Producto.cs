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
        public EnvironmentVariableTarget imagen { get; set; }
        public string descripcionp { get; set; }
        public string nombreprod { get; set; }
    }
}
