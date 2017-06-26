using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net;

namespace ClienteVR
{
    class Program
    {
        static void Main(string[] args)
        {
            Control c = new ClienteVR.Control();
            Console.WriteLine("Ingresar el código del producto");
            int cod = Convert.ToInt32(Console.ReadLine());
            c.consultarProductos(cod);

        }

    }
}
