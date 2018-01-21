using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleMiner.MVP;

namespace SimpleMiner
{
    public interface IClaymorMinerView : IView
    {
        ClaymorParams clParams { get; set; }

        string OutputTextBox { get; set; }

        bool buttonStartEnabled { get; set; }
        bool buttonConfigEnabled { get; set; }

        event Action Run;
        event Action Stop;

    }
}
