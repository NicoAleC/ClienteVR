using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net;

namespace ClienteVR
{
    class Control
    {
        public void consultarUsuarios()
        {
            var json = new WebClient().DownloadString("http://192.168.43.115/slimapp/public/api/coustmr/1");
            List<Cliente> m = JsonConvert.DeserializeObject<List<Cliente>>(json);
            for (int i = 0; i < m.Capacity; i++)
            {
                Console.WriteLine(m[i].codUsuario);
                Console.WriteLine(m[i].nombre);
                Console.WriteLine(m[i].password);
                Console.WriteLine(m[i].ci);
                Console.WriteLine(m[i].tipo);
                Console.WriteLine(m[i].stuff);
                Console.WriteLine(m[i].admi);

            }
        }

        public void consultarProductos(int cod)
        {
            var productos = new WebClient().DownloadString("http://192.168.43.115/slimapp/public/api/productos/total");
            List<Producto> p = JsonConvert.DeserializeObject<List<Producto>>(productos);
            /*
            for (int i = 0; i < p.Count; i++)
            {
                Console.WriteLine("codigo producto: " + p[i].codproducto);
                Console.WriteLine("codigo c: " + p[i].codc);
                Console.WriteLine("precio c: " + p[i].precioc);
                Console.WriteLine("cantidad: " + p[i].cantidad);
                Console.WriteLine("descripcion: " + p[i].descripcionp);
                Console.WriteLine("nombre: " + p[i].nombreprod);
            }*/
            for (int i = 0; i < p.Count; i++)
            {
                if (p[i].codproducto == cod)
                {
                    Console.WriteLine("nombre: " + p[i].nombreprod);
                    Console.WriteLine("precio: " + p[i].preciov);
                    Console.WriteLine("cantidad: " + p[i].cantidad);
                }
            }
            Console.ReadKey();
        }

    }
}
