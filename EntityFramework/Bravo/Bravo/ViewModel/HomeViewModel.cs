using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Bravo.Services.Classes;
using Bravo.Services.Interfaces;
using BravoRepository.EntityContext;
using BravoRepository.EntityModel;
using BravoRepository.Services.Classes;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.IdentityModel.Tokens;

namespace Bravo.ViewModel
{
    internal class HomeViewModel : ViewModelBase
    {
        private INavigationService _navigationService;
        public ObservableCollection<Products>? ProductsList { get; set; } = new();

        private Products selected;
        public Products Selected { get => selected; set => Set(ref selected, value); }


        public HomeViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            using Repository<Products> rep = new();

            rep.BravoDbContext.Stock.Include(x => x.Products);
            
            ProductsList = new(rep.GetAll());
        }


        private RelayCommand? _addCommand;
        public RelayCommand? AddCommand
        {
            get => _addCommand = new(
                () =>
                {
                    MessageBox.Show(Selected.Name);
                });
        }
    }
}
