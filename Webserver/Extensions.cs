using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Webserver.HTML
{
    static class Extensions
    {
        static string GetURLPart(this HttpListenerRequest req, int index)
        {
            string part = req.RawUrl.Split('/')[index];

            return part;
        }
    }
}
