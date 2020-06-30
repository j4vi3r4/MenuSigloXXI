using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace MenuSigloXXI.ViewModels
{
    public class NumeroMesaPageViewModel : ViewModelBase
    {

        private string _idMesa;
        private bool _isRunning;
        private bool _isEnabled;
        private DelegateCommand _numeroMesaCommand;


        public NumeroMesaPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Numero de Mesa";
            IsEnabled = true;
        }

        public string Id_Mesa {
            get => _idMesa;
            set => SetProperty(ref _idMesa, value);
        }
        public bool IsRunning
        {
            get => _isRunning;
            set => SetProperty(ref _isRunning, value);
        }
        public bool IsEnabled
        {
            get => _isEnabled;
            set => SetProperty(ref _isEnabled, value);
        }

        public DelegateCommand NumeroMesaCommand => _numeroMesaCommand ?? (_numeroMesaCommand = new DelegateCommand(AsignarMesaAPP));

        private async void AsignarMesaAPP()
        {
            if (string.IsNullOrEmpty(Id_Mesa))
            {
                await App.Current.MainPage.DisplayAlert("Error","Ingresa un IdMesa","Aceptar");
                return;
            }
        }
    }
}
