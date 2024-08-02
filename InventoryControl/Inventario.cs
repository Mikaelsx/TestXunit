using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryControl
{
    public class Inventario
    {
        private Dictionary<string, int> _produtos;

        public Inventario()
        {
            _produtos = new Dictionary<string, int>();
        }

        public void AdicionarProduto(string nome, int quantidade)
        {
            if (_produtos.ContainsKey(nome))
            {
                _produtos[nome] += quantidade;
            }
            else
            {
                _produtos.Add(nome, quantidade);
            }
        }

        public int ObterQuantidade(string nome)
        {
            if (_produtos.TryGetValue(nome, out var quantidade))
            {
                return quantidade;
            }
            return 0; // Retorna 0 se o produto não existir
        }
    }

}
