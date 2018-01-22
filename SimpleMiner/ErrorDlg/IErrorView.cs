using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleMiner.MVP;

namespace SimpleMiner
{
    public interface IErrorView : IView
    {
        void SetErrorMessage(string sMsg);
        void SetErrorDetails(string sMsg);
    }
}
