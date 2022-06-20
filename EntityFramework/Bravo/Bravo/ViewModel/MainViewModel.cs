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

namespace Bravo.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private ViewModelBase? currentViewModel;
        public ViewModelBase? CurrentViewModel { get => currentViewModel; set => Set(ref currentViewModel, value); }

        private INavigationService _navigationService;

        public MainViewModel(IMessenger messenger, INavigationService navigationService)
        {
            _navigationService = navigationService;

            messenger.Register<NavigationMessage>(this, message =>
            {
                var viewModel = App.Container?.GetInstance(message?.ViewModelType) as ViewModelBase;
                CurrentViewModel = viewModel;
            });

            _navigationService.NavigateTo<HomeViewModel>();
        }
    }
}
