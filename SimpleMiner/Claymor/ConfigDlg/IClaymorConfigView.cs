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

        string textCustomCommand { get; set; }
        void SetCheckCustomCommandState();
    }
}
