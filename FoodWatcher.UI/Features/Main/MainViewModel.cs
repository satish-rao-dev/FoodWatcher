using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodWatcher.UI.Messages;
using FoodWatcher.UI.Services;

namespace FoodWatcher.UI.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private string _sampleMessage;
        public string SampleMessage
        {
            get
            {
                return _sampleMessage;
            }
            set
            {
                Set<string>(ref _sampleMessage, value);
            }
        }

        public RelayCommand CloseCommand { get; set; }


        IConfigurationService _configService = null;
        public MainViewModel(IConfigurationService configService)
        {
            _configService = configService;
            SetMessage();
            SetCommands();
        }

        private void SetMessage()
        {
            string sampleMessage = string.Empty;
            string errorMessage = string.Empty;
            bool IsConfigFound = _configService.TryGetConfigurationFromAppSettins("SampleMessage", out sampleMessage, out errorMessage); ;
            if (IsConfigFound && !string.IsNullOrWhiteSpace(sampleMessage))
            {
                SampleMessage = sampleMessage;
            }
            else
            {
                SampleMessage = $"Sample message not available in configuration. {errorMessage}";
            }
        }

        private void SetCommands()
        {
            CloseCommand = new RelayCommand(CloseExecute, CloseCanExecute);
        }

        private bool CloseCanExecute()
        {
            return true;
        }

        private void CloseExecute()
        {
            MessengerInstance.Send<CloseApplicationMessage>(new CloseApplicationMessage(this));
        }

    }
}
