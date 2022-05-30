using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using MVVM_Views.Model;
using MVVM_Views.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MVVM_Views.ViewModel
{
    public class FirstViewModel : ViewModelBase
    {
        private IFillCurrencyService _fillCurrencyService;
        private ICurrencyClient _currencyClient;

        public List<string> AllCurrency { get; set; }
        public int SelectedItemFrom { get; set; }
        public int SelectedItemTo { get; set; }
        
        private string? amount;
        public string? Amount { get => amount; set { Set(ref amount, value); ConvertCommand.RaiseCanExecuteChanged(); } }

        private string? result;
        public string? Result { get => result; set => Set(ref result, value); }

        public FirstViewModel(IFillCurrencyService fillCurrencyService, ICurrencyClient currencyClient)
        {
            _fillCurrencyService = fillCurrencyService;
            _currencyClient = currencyClient;

            AllCurrency = fillCurrencyService.FillCurrency();
        }

        private void Convert()
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


        private bool CheckAmount()
        {
            float tmp;
            return !String.IsNullOrEmpty(Amount) && float.TryParse(Amount, out tmp);
        }

        private Func<bool> Check => CheckAmount;


        private RelayCommand? convertCommand;

        public RelayCommand? ConvertCommand
        {
            get => convertCommand ??= new RelayCommand(
                () =>
                {
                    try
                    {
                        MessageBox.Show("test");
                        //Convert();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }, Check);
        }
    }
}
