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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;
using Client_version2.ViewModel;

namespace Client_version2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new LoginViewModel(this, new GMHelper.Logon());
        }

        private void pwdTextbox_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void Page_Presenter_ContentRendered(object sender, EventArgs e)
        {
            Debug.WriteLine("How is this triggered?");
        }

        private void Page_Presenter_ManipulationStarting(object sender, ManipulationStartingEventArgs e)
        {
            Debug.WriteLine("WOOOAH, SOMEONE IS MESSING WITH ME!");
        }

        private void Page_Presenter_Navigating(object sender, NavigatingCancelEventArgs e)
        {
            Debug.WriteLine("WOOOAH, SOMEONE IS NAVIGATING WITH ME!");
        }
    }
}
