using Bravo.Messages;
using Bravo.Services.Interfaces;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bravo.Services.Classes
{
    public class NavigationService : INavigationService
    {
        private readonly IMessenger _messenger;

        public NavigationService(IMessenger messenger)
        {
            _messenger = messenger;
        }


        public void NavigateTo<T>() where T : ViewModelBase
        {
            _messenger.Send(new NavigationMessage() { ViewModelType = typeof(T) });
        }
    }
}
