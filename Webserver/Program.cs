using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Webserver
{
    class Program
    {
        static void Main(string[] args)
        {
            WebServer ws = new WebServer(SendResponse, "http://localhost:8080/test/");
            ws.Run();
            Console.WriteLine("Press a key to quit.");
            Console.ReadKey();
            ws.Stop();
        }

        public static string LoadHTML(string path)
        {
            return File.ReadAllText(path);
        }

        public static string SendResponse(HttpListenerRequest request)
        {
            string a = LoadHTML("HTML/Test.html");

            string conv = "";

            if (request.HasParameter("URL"))
            {
                conv = ConvertToBase64(request.GetParameter("URL"));
            }

            a = string.Format(a, conv);

            return a;
        }

        public static string ConvertToBase64(string text)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(text);
            return Convert.ToBase64String(plainTextBytes);
        }
    }
}
