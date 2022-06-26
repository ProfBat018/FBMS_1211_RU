using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Bravo.Services.Classes;
using Bravo.Services.Interfaces;
using BravoRepository.EntityContext;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Bravo.ViewModel
{
    internal class HomeViewModel : ViewModelBase
    {

        private INavigationService _navigationService;
        private IRepositoryData _repositoryData;
        public BravoDbContext BravoDb { get; set; }

        public HomeViewModel(INavigationService navigationService, IRepositoryData repositoryData)
        {
            _navigationService = navigationService;
            _repositoryData = repositoryData;
            BravoDb = _repositoryData.GetContext();
            MessageBox.Show(BravoDb.Products.ToList()[0].Name);
        }
    }
}
