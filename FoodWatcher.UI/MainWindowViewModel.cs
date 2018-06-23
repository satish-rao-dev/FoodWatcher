using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodWatcher.UI.Messages;

namespace FoodWatcher.UI.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {

        private ViewModelBase _currentViewModel;
        public ViewModelBase CurrentViewModel
        {
            get
            {
                return _currentViewModel;
            }
            set
            {
                Set<ViewModelBase>(ref _currentViewModel, value);
            }
        }


        public MainWindowViewModel()
        {
            Setup();
            SetMessageListeners();
        }

        private void Setup()
        {
            ShowMain();
        }

        private void ShowMain()
        {
            CurrentViewModel = ViewModelLocator.Instance.Main;
        }

        private void SetMessageListeners()
        {
            MessengerInstance.Register<CloseApplicationMessage>(this, closeApp);
        }

        private void closeApp(CloseApplicationMessage message)
        {
            //setup mechanism through behavior or other mvvm mech to close application window
        }
    }
}
