using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bravo.Services.Classes;
using Bravo.Services.Interfaces;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Bravo.ViewModel
{
    internal class HomeViewModel : ViewModelBase
    {

        private INavigationService _navigationService;

        public HomeViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        private RelayCommand? testCommand;
        public RelayCommand TestCommand
        {
            get => new(() =>
            {
                _navigationService.NavigateTo<AuthViewModel>();
            });
        }

    }
}
