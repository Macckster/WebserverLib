using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Webserver
{
    static class Extensions
    {
        public static string GetURLPart(this HttpListenerRequest req, int index)
        {
            string part = req.RawUrl.Split('/')[index+1];

            return part;
        }

        public static string GetParameter(this HttpListenerRequest req, string name)
        {
            string value = req.QueryString.Get(name);
            return value;
        }

        public static bool HasParameter(this HttpListenerRequest req, string param)
        {
            return req.QueryString.Keys.ToString().Contains(param);
        }
    }
}
