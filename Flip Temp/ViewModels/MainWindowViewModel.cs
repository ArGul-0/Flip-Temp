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

        private string temperatureInput;

        public string TemperatureInput
        {
            get { return temperatureInput; }
            set 
            {
                temperatureInput = value; 
                OnPropertyChanged();
                ConvertTemperature();
            }
        }

        private string result;

        public string Result
        {
            get { return result; }
            set 
            {
                result = value; 
                OnPropertyChanged();
            }
        }

        private void ConvertTemperature()
        {
            if (float.TryParse(TemperatureInput, out float tempValue))
            {
                if (CurrentTypeIsCelsius)
                {
                    string result = calculateResult.CelsiusToFarenheit(tempValue);
                    result += " °F";
                    Result = result;
                }
                else
                {
                    string result = calculateResult.FarenheitToCelsius(tempValue);
                    result += " °C";
                    Result = result;
                }
            }
            else
            {
                Result = "Invalid input";
            }

            OnPropertyChanged(nameof(Result));
        }
    }
}