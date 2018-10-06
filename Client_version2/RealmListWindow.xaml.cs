using Client_version2.ViewModel;
using GMHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Client_version2
{
    /// <summary>
    /// Interaction logic for RealmListWindow.xaml
    /// </summary>
    public partial class RealmListWindow : Window
    {
        private RealmlistViewModel model;
        public RealmListWindow(RealmList[] realms)
        {
            InitializeComponent();
            DataContext = new RealmlistViewModel(this, realms);
        }
    }
}
