using Client_version2.Pages;
using Essentials;
using FontAwesome.WPF;
using GMHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Client_version2.ViewModel
{
    public class LoginViewModel : WindowViewModel
    {
        private LoginPage loginPage;
        private RealmlistPage realmListPage;
        private LoadingPage loadingPage;
        private Logon mLogon;

        public ICommand ConnectCommand { get; set; }
        public ICommand SelectRealmCommand { get; set; }

        public Page CurrentPage { get; set; }

        public string Username { get; set; } = "test";
        public string Password { get; set; } = "test";

        public RealmList[] Realms { get; set; }

        public RealmList SelectedRealm { get; set; }


        public LoginViewModel(Window window, Logon logon) : base(window)
        {
            loginPage = new LoginPage(this);
            realmListPage = new RealmlistPage(this);
            loadingPage = new LoadingPage();
            mLogon = logon;


            CurrentPage = loginPage;
            ConnectCommand = new RelayCommand(connectToServer);
            SelectRealmCommand = new RelayCommand(connectToRealm);

            mLogon.OnLogonError += MLogon_OnLogonError;
            mLogon.OnLogonComplete += MLogon_OnLogonComplete;
            mLogon.OnRealmlistsReceived += MLogon_OnRealmlistsReceived;
        }

        private void M_WorldServer_OnCharacterSelected(object sender, EventArgs e)
        {
            // We can move to a new window
            CurrentPage = realmListPage;
        }

        private void MLogon_OnRealmlistsReceived(object sender, LogonArgs e)
        {
            //Realms = e.Realms;
            // We can now initialize a new window to handle the realmlist connection.
            /* Application.Current.Dispatcher.Invoke(delegate
             {
                 var window = new RealmListWindow(e.Realms);
                 window.ShowDialog();
             });*/

            Realms = e.Realms;
            CurrentPage = realmListPage;

        }

        private void MLogon_OnLogonComplete(object sender, EventArgs e)
        {

        }

        private void MLogon_OnLogonError(object sender, EventArgs e)
        {

        }

        private void connectToRealm()
        {
            if (SelectedRealm == null)
                return;

            CurrentPage = loadingPage;
            Manager.m_WorldServer.ConnectToRealm(SelectedRealm);
        }

        private void connectToServer()
        {
            CurrentPage = loadingPage;
            mLogon.Start("localhost", ConfigOptions.LogonPort, Username, Password);
            Manager.m_WorldServer.OnCharacterSelected += (sender, e) => {
                // Move to new window
                CurrentPage = realmListPage;
            };
        }


    }
}
