using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertCelsiusToFahrenheit
{
    public class TemperatureConverter
    {
        public double ConverterCelsiusParaFahrenheit(double celsius)
        {
            return (celsius * 9.0 / 5.0) + 32;
        }
    }

}
