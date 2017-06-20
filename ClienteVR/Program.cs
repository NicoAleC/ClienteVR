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
            Console.WriteLine(m.ElementAt(0).ci);
        }
    }
}
