using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using MVVM_Views.Messages;
using MVVM_Views.Model;
using MVVM_Views.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Views.ViewModel
{
    public class ThirdViewModel : ViewModelBase
    {
        public Person Person { get; set; } = new Person();
        private readonly IMessenger _messenger;
        private readonly INavigationService _navigationMessage;

        public ThirdViewModel(IMessenger messenger, INavigationService navigationService)
        {
            _messenger = messenger;
            _navigationMessage = navigationService;

            _messenger.Register<PersonMessage>(this, message => Person = message.Person);
        }

        private RelayCommand backCommand;
        public RelayCommand BackCommand
        {
            get => new RelayCommand(
            () =>
            {
                _navigationMessage.NavigateTo<SecondViewModel>();
            });
        }
    }
}
