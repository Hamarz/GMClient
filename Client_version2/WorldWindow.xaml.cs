using Client_version2.ViewModel;
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
    /// Interaction logic for WorldWindow.xaml
    /// </summary>
    public partial class WorldWindow : Window
    {
        public WorldWindow()
        {
            InitializeComponent();
            DataContext = new WorldWindowViewModel(this);
        }
    }
}
