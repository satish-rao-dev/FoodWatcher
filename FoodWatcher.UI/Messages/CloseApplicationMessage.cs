using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodWatcher.UI.Messages
{
    public class CloseApplicationMessage
    {
        public ViewModelBase Originator { get; set; }
        public CloseApplicationMessage(ViewModelBase originator)
        {
            Originator = originator;
        }
    }
}
