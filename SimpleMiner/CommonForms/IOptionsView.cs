using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleMiner.MVP;

namespace SimpleMiner
{
    public interface IOptionsView :IView
    {
        void PopulateLanguages(List<KeyValuePair<string, string>> list);

        string currentLanguage { get; set; }

        bool writeLog { get; set; }
    }
}
