using Flip_Temp.MVVM;

namespace Flip_Temp.ViewModels
{
    class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            
        }


        // Add properties and commands for data binding here
        private bool currentTypeIsCelsius = true;
        public bool CurrentTypeIsCelsius
        {
            get => currentTypeIsCelsius;
            set
            {
                currentTypeIsCelsius = value;
                OnPropertyChanged();
            }
        }

        private string temperature;
        public string Temperature
        {
            get => temperature;
            set
            {
                temperature = value;
                OnPropertyChanged();
            }
        }
    }
}