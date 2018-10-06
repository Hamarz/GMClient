using GMHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Client_version2.ViewModel
{
    public class RealmlistViewModel : WindowViewModel
    {
        private Window window;
        private RealmList[] realms;

        public RealmlistViewModel(Window window, RealmList[] realms) : base(window)
        {
            this.window = window;
            this.realms = realms;
        }
    }
}
