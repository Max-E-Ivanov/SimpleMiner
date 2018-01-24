using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleMiner.MVP;

namespace SimpleMiner
{
    public interface IAboutView :IView
    {

        event Action Web;
        event Action Mail;

        void SetVersion(string sVersion);
        void SetWebVisited();
        void SetMailVisited();

    }
}
