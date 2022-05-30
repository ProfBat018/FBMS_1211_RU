using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using MVVM_Views.Messages;
using MVVM_Views.Model;
using MVVM_Views.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Views.ViewModel
{
    public class SecondViewModel : ViewModelBase
    {
        private ObservableCollection<Person>? people;
        public ObservableCollection<Person>? People { get => people; set => Set(ref people, value); }

        private Person selected;
        public Person Selected { get => selected; set => Set(ref selected, value); }

        private readonly INavigationService? _navigationService;
        private readonly IMessenger? _messenger;


        public SecondViewModel(INavigationService? navigationService, IMessenger? messenger)
        {
            _messenger = messenger;
            _navigationService = navigationService;

            People = new ObservableCollection<Person>()
            {
                new Person() { Name = "Elvin", Surname = "Azimov", Age = 20},
                new Person() { Name = "Orxan", Surname = "Tukanov", Age = 36},
                new Person() { Name = "Ilkin", Surname = "Mammadli", Age = 17},
                new Person() { Name = "Kerim", Surname = "Kalashov", Age = 16}
            };
        }


        private RelayCommand<Person>? infoCommand;
        public RelayCommand<Person>? InfoCommand
        {
            get => new RelayCommand<Person>(
                param =>
                {
                    if (param != null)
                    {
                        _navigationService?.NavigateTo<ThirdViewModel>();
                        _messenger?.Send(new PersonMessage() { Person = Selected });
                    }
                });
        }


    }
}
