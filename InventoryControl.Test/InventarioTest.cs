using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace InventoryControl.Test
{
    public class InventarioTests
    {
        private readonly Inventario _inventario = new Inventario();

        [Fact]
        public void AdicionarProduto_DeveIncrementarQuantidade_QuandoProdutoJaExiste()
        {
            // Arrange
            var nome = "Arroz";
            var quantidadeInicial = 5;
            var quantidadeAdicional = 3;

            _inventario.AdicionarProduto(nome, quantidadeInicial);

            // Act
            _inventario.AdicionarProduto(nome, quantidadeAdicional);

            // Assert
            var quantidadeTotal = _inventario.ObterQuantidade(nome);
            Assert.Equal(quantidadeInicial + quantidadeAdicional, quantidadeTotal);
        }

        [Fact]
        public void AdicionarProduto_DeveAdicionarNovoProduto_QuandoNaoExisteNoInventario()
        {
            // Arrange
            var nome = "Feijão";
            var quantidade = 10;

            // Act
            _inventario.AdicionarProduto(nome, quantidade);

            // Assert
            var quantidadeTotal = _inventario.ObterQuantidade(nome);
            Assert.Equal(quantidade, quantidadeTotal);
        }

        [Fact]
        public void ObterQuantidade_DeveRetornarZero_QuandoProdutoNaoExiste()
        {
            // Arrange
            var nome = "Macarrão";

            // Act
            var quantidade = _inventario.ObterQuantidade(nome);

            // Assert
            Assert.Equal(0, quantidade);
        }
    }

}
