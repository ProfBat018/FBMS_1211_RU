using Bravo.Services.Classes;
using Bravo.Services.Interfaces;
using Bravo.View;
using Bravo.ViewModel;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Bravo
{
    public partial class App : Application
    {
        public static Container? Container { get; set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            Register();

            StartMain<MainViewModel>();

            base.OnStartup(e);
        }

        public void Register()
        {
            Container = new Container();
            Container.RegisterSingleton<IMessenger, Messenger>();
            Container.RegisterSingleton<INavigationService, NavigationService>();
            Container.RegisterSingleton<IAuthService, AuthService>();

            Container.RegisterSingleton<MainViewModel>();
            Container.RegisterSingleton<HomeViewModel>();
            Container.RegisterSingleton<AuthViewModel>();

            Container.Verify();
        }


        public void StartMain<T>() where T : ViewModelBase
        {
            Window window = new MainWindow();
            var viewModel = Container?.GetInstance<T>();

            window.DataContext = viewModel;

            window.ShowDialog();
        }
    }
}
