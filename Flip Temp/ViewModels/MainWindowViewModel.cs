using Flip_Temp.Models;
using Flip_Temp.MVVM;

namespace Flip_Temp.ViewModels
{
    class MainWindowViewModel : ViewModelBase
    {
        private CalculateResult calculateResult = new CalculateResult();

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

        private string temperatureInput;

        public string TemperatureInput
        {
            get { return temperatureInput; }
            set { temperatureInput = TemperatureInput; }
        }

        private string result;

        public string Result
        {
            get { return result; }
            set { result = value; }
        }

        private void ConvertTemperature(object? parameter)
        {
            if (float.TryParse(TemperatureInput, out float tempValue))
            {
                if (CurrentTypeIsCelsius)
                {
                    Result = calculateResult.CelsiusToFarenheit(tempValue);
                }
                else
                {
                    Result = calculateResult.FarenheitToCelsius(tempValue);
                }
            }
            else
            {
                Result = "Invalid input";
            }
        }
    }
}