using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmailValidation;
using Xunit;

namespace EmailValidantion.Test
{

    public class EmailValidatorTests
    {
        private readonly EmailValidator _validator = new EmailValidator();

        [Fact]
        public void ValidarEmail_DeveRetornarVerdadeiro_QuandoEmailEValido()
        {
            // Arrange
            var email = "exemplo@email.com";

            // Act
            var resultado = _validator.ValidarEmail(email);

            // Assert
            Assert.True(resultado);
        }

        [Fact]
        public void ValidarEmail_DeveRetornarFalso_QuandoEmailNaoContemArroba()
        {
            // Arrange
            var email = "exemploemail.com";

            // Act
            var resultado = _validator.ValidarEmail(email);

            // Assert
            Assert.False(resultado);
        }

        [Fact]
        public void ValidarEmail_DeveRetornarFalso_QuandoEmailNaoContemPonto()
        {
            // Arrange
            var email = "exemplo@email";

            // Act
            var resultado = _validator.ValidarEmail(email);

            // Assert
            Assert.False(resultado);
        }
    }

}
