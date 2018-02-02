using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleMiner.MVP;

namespace SimpleMiner.Claymor
{
    public interface IClaymorZMinerView : IView
    {
        ClaymorParams clParams { get; set; }

        void PopulateEthPools(List<string> lsPools);

        string OutputTextBox { get; set; }

        bool buttonStartEnabled { get; set; }
        bool buttonConfigEnabled { get; set; }

        void SetStartStopState(bool bStart);

        void SetCreateWalletVisited();

        event Action Run;
        event Action Stop;
        event Action Config;
        event Action CreateWallet;

    }
}
