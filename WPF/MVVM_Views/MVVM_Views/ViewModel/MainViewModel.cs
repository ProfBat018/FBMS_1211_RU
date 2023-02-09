using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using MVVM_Views.Messages;
using MVVM_Views.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM_Views.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private ViewModelBase currentViewModel;
        private RelayCommand firstCommand;
        private RelayCommand secondCommand;
        private RelayCommand thirdCommand;

        private INavigationService _navigationService;
        public ViewModelBase CurrentViewModel { get => currentViewModel; set => Set(ref currentViewModel, value); }


        public MainViewModel(IMessenger messenger, INavigationService navigationService)
        {
            _navigationService = navigationService;

            messenger.Register<NavigationMessage>(this, message =>
            {
                var viewModel = App.Container.GetInstance(message.ViewModelType) as ViewModelBase;
                CurrentViewModel = viewModel;
            });
        }


        public RelayCommand FirstCommand
        {
            get => new RelayCommand(() =>
            {
                _navigationService.NavigateTo<FirstViewModel>();
            });
        }

        public RelayCommand SecondCommand
        {
            get => new RelayCommand(() =>
            {
                _navigationService.NavigateTo<SecondViewModel>();
            });
        }

        public RelayCommand ThirdCommand
        {
            get => new RelayCommand(() =>
            {
                _navigationService.NavigateTo<ThirdViewModel>();
            });
        }
    }
}
