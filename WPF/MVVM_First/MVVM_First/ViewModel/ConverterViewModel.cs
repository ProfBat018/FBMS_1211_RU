using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MVVM_First.Model;
using System.Reflection;
using MVVM_First.Services.Classes;
using MVVM_First.Services.Interfaces;
using System.ComponentModel;
using System.Windows.Controls;
using System.Windows.Media;

namespace MVVM_First.ViewModel
{
    public class ConverterViewModel : ViewModelBase
    {
        #region VariantEmilyaKotoriyPloxoy
        //public Dictionary<string, float> AllCurrency { get; set; } = new();

        //private void FillCurrency()
        //{
        //    Data data = new Data();

        //    PropertyInfo[] props = data.GetType().GetProperties();

        //    foreach (PropertyInfo prop in props)
        //    {
        //        AllCurrency.Add(prop.Name, (float)prop.GetValue(data));
        //    }
        //}


        //public ConverterViewModel()
        //{
        //    FillCurrency();
        //}

        #endregion

        public string Color { get; set; } = "Red";


        private IFillCurrencyService _fillCurrencyService;
        private ICurrencyClient _currencyClient;

        public List<string> AllCurrency { get; set; }

        public List<PersonModel> TestCollection { get; set; } = new() { new() { Id = 1, Name = "Elvin", IsMarried = false } };

        public int SelectedItemFrom { get; set; }
        public int SelectedItemTo { get; set; }
        public string? Amount { get; set; } = "0";

        private string? result = "0";
        public string? Result 
        {
            get => result; 
            set => Set(ref result, value);
        }


        public ConverterViewModel(IFillCurrencyService fillCurrencyService, ICurrencyClient currencyClient)
        {
            _fillCurrencyService = fillCurrencyService;
            _currencyClient = currencyClient;

            AllCurrency = fillCurrencyService.FillCurrency();
        }


        private RelayCommand? convertCommand;

        public RelayCommand? ConvertCommand
        {
            get => convertCommand ??= new RelayCommand(
                () =>
                {
                    try
                    {
                        CurrencyModel result = _currencyClient.GetCurrencyData(AllCurrency[SelectedItemFrom]);

                        Data a = result.data;

                        foreach (var item in result.data.GetType().GetProperties())
                        {
                            if (item.Name == AllCurrency[SelectedItemTo])
                            {
                                var res = float.Parse(Amount) * (float)item.GetValue(a);
                                Result = res.ToString();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                });
        }
    }
}
