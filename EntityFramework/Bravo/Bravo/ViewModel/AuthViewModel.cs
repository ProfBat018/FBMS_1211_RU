using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Bravo.Model;
using Bravo.Services.Interfaces;
using GalaSoft.MvvmLight.Command;

namespace Bravo.ViewModel
{
    internal class AuthViewModel : ViewModelBase
    {
        public List<User> Users { get; set; }
        public User UserEntry { get; set; }

        private readonly INavigationService _navigationService;
        private readonly IAuthService _authService;

        public AuthViewModel(INavigationService navigationService, IAuthService authService)
        {
            _navigationService = navigationService;
            _authService = authService;
            UserEntry = new();
            Users = new();
        }

        private RelayCommand<PasswordBox>? _loginCommand;
        public RelayCommand<PasswordBox>? LoginCommand
        {
            get => _loginCommand = new(param =>
            {
                var users = _authService.GetUsers();

                if (users == null) return;

                foreach (var user in users)
                    if (user.Username == UserEntry.Username && user.Password == param.Password)
                        _navigationService.NavigateTo<HomeViewModel>();
            });
        }
    }
}
