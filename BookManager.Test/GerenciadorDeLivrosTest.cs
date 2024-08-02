using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BookManager.Test
{
    public class GerenciadorDeLivrosTest
    {
        private readonly GerenciadorDeLivros _gerenciador = new GerenciadorDeLivros();

        [Fact]
        public void AdicionarLivro_DeveAdicionarUmNovoLivro_AListaDeLivros()
        {
            // Arrange
            var titulo = "O Senhor dos Anéis";

            // Act
            _gerenciador.AdicionarLivro(titulo);

            // Assert
            var livros = _gerenciador.ObterLivros();
            Assert.Contains(titulo, livros);
            Assert.Equal(1, livros.Count);
        }

        [Fact]
        public void AdicionarLivro_DeveAdicionarMultiplosLivros_AListaDeLivros()
        {
            // Arrange
            var titulos = new List<string> { "Harry Potter", "Diario de um Banana", "1984" };

            // Act
            foreach (var titulo in titulos)
            {
                _gerenciador.AdicionarLivro(titulo);
            }

            // Assert
            var livros = _gerenciador.ObterLivros();
            Assert.Equal(titulos.Count, livros.Count);
            foreach (var titulo in titulos)
            {
                Assert.Contains(titulo, livros);
            }
        }
    }

}
