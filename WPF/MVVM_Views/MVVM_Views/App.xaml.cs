using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using MVVM_Views.Model;
using MVVM_Views.Services.Classes;
using MVVM_Views.Services.Interfaces;
using MVVM_Views.View;
using MVVM_Views.ViewModel;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;


namespace MVVM_Views
{
    public partial class App : Application
    {
        public static Container Container { get; set; }
        
        protected override void OnStartup(StartupEventArgs e)
        {
            Register();

            StartMain<MainViewModel>();

            base.OnStartup(e);
        }

        public void Register()
        {
            Container = new Container();

            Container.RegisterSingleton<INavigationService, NavigationService>();
            Container.RegisterSingleton<IMessenger, Messenger>();
            Container.RegisterSingleton<ICurrencyClient, CurrencyClient>();
            Container.RegisterSingleton<IFillCurrencyService, FillCurrencyService>();


            Container.RegisterSingleton<MainViewModel>(); // var a = new MainViewModel();
            Container.RegisterSingleton<FirstViewModel>();
            Container.RegisterSingleton<SecondViewModel>();
            Container.RegisterSingleton<ThirdViewModel>();

            Container.Verify();
        }


        public void StartMain<T>() where T: ViewModelBase
        {
            Window window = new MainView();
            var viewModel = Container.GetInstance<T>();

            window.DataContext = viewModel;

            window.ShowDialog();
        }
    }
}
