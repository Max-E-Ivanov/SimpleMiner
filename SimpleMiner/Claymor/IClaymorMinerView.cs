using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleMiner.MVP;

namespace SimpleMiner.Claymor
{
    public interface IClaymorMinerView : IView
    {
        ClaymorParams clParams { get; set; }

        void PopulateEthPools(List<string> lsPools);

        string OutputTextBox { get; set; }

        bool buttonStartEnabled { get; set; }
        bool buttonConfigEnabled { get; set; }

        event Action Run;
        event Action Stop;
        event Action Config;

    }
}
