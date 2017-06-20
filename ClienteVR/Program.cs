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
            var json = new WebClient().DownloadString("http://192.168.47.0/slimapp/public/api/coustmr/1");
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


            var productos = new WebClient().DownloadString("http://192.168.47.0/slimapp/public/api/producto/1");
            List<Producto> p = JsonConvert.DeserializeObject<List<Producto>>(json);
            Console.WriteLine(p.ElementAt(0).codproducto);


        }

    }
}
