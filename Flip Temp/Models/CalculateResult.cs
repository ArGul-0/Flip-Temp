namespace Flip_Temp.Models
{
    class CalculateResult
    {
        public string CelsiusToFarenheit(float celsius)
        {
            float result = (celsius * 1.8f) + 32;
            return result.ToString();
        }
        public string FarenheitToCelsius(float farenheit)
        {
            float result = (farenheit - 32) / 1.8f;
            return result.ToString();
        }
    }
}
