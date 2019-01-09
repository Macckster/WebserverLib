using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Webserver.HTML
{
    public static class HTMLManager
    {
        /// <summary>
        /// Load a html file and format it.
        /// </summary>
        /// <param name="path">Path to the file</param>
        /// <param name="obj">parameters used to format the contents</param>
        /// <returns></returns>
        public static string LoadHTML(string path, params object[] obj)
        {
            return string.Format(File.ReadAllText(path), obj);
        }
    }
}
