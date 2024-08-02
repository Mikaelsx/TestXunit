using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ConvertCelsiusToFahrenheit.Test
{

    public class TemperatureConverterTests
    {
        private readonly TemperatureConverter _converter = new TemperatureConverter();

        [Fact]
        public void ConverterCelsiusParaFahrenheit_DeveRetornarCorretamente_QuandoValorEZero()
        {
            // Arrange
            var celsius = 0.0;
            var esperado = 32.0;

            // Act
            var resultado = _converter.ConverterCelsiusParaFahrenheit(celsius);

            // Assert
            Assert.Equal(esperado, resultado);
        }

        [Fact]
        public void ConverterCelsiusParaFahrenheit_DeveRetornarCorretamente_QuandoValorEPositivo()
        {
            // Arrange
            var celsius = 100.0;
            var esperado = 212.0;

            // Act
            var resultado = _converter.ConverterCelsiusParaFahrenheit(celsius);

            // Assert
            Assert.Equal(esperado, resultado);
        }

        [Fact]
        public void ConverterCelsiusParaFahrenheit_DeveRetornarCorretamente_QuandoValorENegativo()
        {
            // Arrange
            var celsius = -40.0;
            var esperado = -40.0;

            // Act
            var resultado = _converter.ConverterCelsiusParaFahrenheit(celsius);

            // Assert
            Assert.Equal(esperado, resultado);
        }
    }

}
