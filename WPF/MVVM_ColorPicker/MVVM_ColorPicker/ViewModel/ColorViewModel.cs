using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using MVVM_ColorPicker.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MVVM_ColorPicker.ViewModel
{
    public class ColorViewModel : ViewModelBase
    {
        public List<TaskModel> Tasks { get; set; }
        public ColorModel Color { get; set; } = new();

        public ColorViewModel()
        {
            Color.Red = "test";
        }

        private RelayCommand chooseColor;
        public RelayCommand ChooseColor
        {
            get => new RelayCommand(
                () =>
                {
                    Color.Red = "Elvin Azimov";
                });
        }
    }
}
