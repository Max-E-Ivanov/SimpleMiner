using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleMiner.MVP;

namespace SimpleMiner.Claymor
{
    public interface IClaymorConfigView :IView
    {
        event Action Ok;
        event Action Default;

        string epool { get; set; }
        bool solo { get; set; }
        string etht { get; set; }

        void SetCheckSoloState();
        
        bool allpools { get; set; }
        
        string allcoins { get; set; }
        void SetCheckAllCoinsState();

        string epsw { get; set; }
        void SetCheckPswState();

        string eworker { get; set; }
        void SetCheckEworker();

        string ethi { get; set; }
        void SetCheckEthi();

        string etha { get; set; }
        void SetCheckEtha();

        bool estale { get; set; }

        bool erate { get; set; }

        string esm { get; set; }
        void SetEsmList(List<KeyValuePair<string, string>> ListEsm);
        void SetCheckEsm();

        string textCustomCommand { get; set; }
        void SetCheckCustomCommandState();
    }
}
