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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Client_version2.Pages
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage(LoginViewModel login)
        {
            InitializeComponent();
            DataContext = login;
        }

        private void pwdTextbox_KeyUp(object sender, KeyEventArgs e)
        {
            a0543.Text = pwdTextbox.Password;
        }
    }
}
