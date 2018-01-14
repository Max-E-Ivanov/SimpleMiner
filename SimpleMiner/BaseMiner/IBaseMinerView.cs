using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleMiner.MVP;

namespace SimpleMiner
{
    public interface IBaseMinerView :IView
    {
        string OutputTextBox { get; set; }

        string RestartLabel { get; set; }
        string StatusLabel { get; set; }

        string ClentTimeLabel { get; set; }
        string AuthorTimeLabel { get; set; }

        bool AutoRestart { get; set; }

        string Program { get; set; }
        string Params { get; set; }

        event Action Run;
        event Action Stop;
    }



}
