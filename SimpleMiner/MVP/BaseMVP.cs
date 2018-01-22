using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace SimpleMiner.MVP
{
    public interface IView : INotifyPropertyChanged
    {
        void Show();
        object ShowDialog();
    }

    public interface IPresenter
    {
        void Show();
        object ShowDialog();
    }
}
