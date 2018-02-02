using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleMiner.MVP;

namespace SimpleMiner.Claymor
{
    public interface IZClaymorConfigView :IView
    {
        event Action Ok;
        event Action Default;
        event Action GenerateCommand;

        bool buttonOkEnabled { get; set; }

        void PopulateEPools(List<string> lsPools);
        void PopulateDPools(List<string> lsPools);
        void PopulateDCoins(List<string> lsDCoins);

        string epool { get; set; }
        bool solo { get; set; }
        string etht { get; set; }

        //void SetCheckSoloState();
        
        bool allpools { get; set; }
        
        string allcoins { get; set; }
        //void SetCheckAllCoinsState();

        string epsw { get; set; }
        //void SetCheckPswState();

        string eworker { get; set; }
        //void SetCheckEworker();

        string ethi { get; set; }
        //void SetCheckEthi();

        string etha { get; set; }
        //void SetCheckEtha();

        bool estale { get; set; }

        bool erate { get; set; }

        string esm { get; set; }
        void PopulateEsmList(List<KeyValuePair<string, string>> ListEsm);
        //void SetCheckEsm();


        // ------------------

        bool mode { get; set; }
        string dpool { get; set; }
        string dwal { get; set; }
        string dpsw { get; set; }
        string dcri { get; set; }
        string dcrt { get; set; }
        string dcoin { get; set; }

        string textCustomCommand { get; set; }
        //void SetCheckCustomCommandState();

        // ------------------
        bool GPU_FORCE_64BIT_PTR0 { get; set; }
        bool GPU_MAX_HEAP_SIZE100 { get; set; }
        bool GPU_USE_SYNC_OBJECTS { get; set; }
        bool GPU_MAX_ALLOC_PERCENT { get; set; }
        bool GPU_SINGLE_ALLOC_PERCENT { get; set; }

        // ------------------
        bool showwindow { get; set; }
        bool restart { get; set; }

    }
}
