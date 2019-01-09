using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webserver;
using static Webserver.HTML.HTMLManager;
using System.Net;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            WebServer ws = new WebServer(Recieve, WebServer.StandardURL);
            ws.Run();
            Console.WriteLine("Press any key to stop");
            Console.ReadLine();
            ws.Stop();
        }

        static string Recieve(HttpListenerRequest req)
        {
            return LoadHTML("HTML/Test.html", 10);
        }
    }
}
