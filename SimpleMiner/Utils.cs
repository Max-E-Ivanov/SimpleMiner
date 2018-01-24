using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace SimpleMiner
{
    public static class Utils
    {
        public static string GetMD5()
        {
            return string.Empty;
        }

        public static string GetAppPath()
        {
           string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
           return path;
        }

        public static string GetAppVersion()
        {            
            return Application.ProductVersion;
        }

        public static string BuildSeq(List<string> _list, string sDelim)
        {
            string sResult = "";

            foreach (string s in _list)
                if (!string.IsNullOrEmpty(s))
                    sResult = sResult + s + sDelim;

            if (sResult != "")
                sResult = sResult.Substring(0, sResult.Length - sDelim.Length);

            return sResult;
        }
    }
}
