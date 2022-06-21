using Bravo.Messages;
using Bravo.Services.Interfaces;
using BravoRepository.EntityModel;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Bravo.View;
using GalaSoft.MvvmLight.Command;

namespace Bravo.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private ViewModelBase? _currentViewModel;
        public ViewModelBase? CurrentViewModel { get => _currentViewModel; set => Set(ref _currentViewModel, value); }

        public MainViewModel(IMessenger messenger, INavigationService navigationService)
        {
            messenger.Register<NavigationMessage>(this, message =>
            {
                if (message.ViewModelType != null)
                {
                    var viewModel = App.Container?.GetInstance(message.ViewModelType) as ViewModelBase;
                    CurrentViewModel = viewModel;
                }
            });
            navigationService.NavigateTo<AuthViewModel>();
        }
    }
}
