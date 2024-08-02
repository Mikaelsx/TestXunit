using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManager
{
    public class GerenciadorDeLivros
    {
        private List<string> _livros;

        public GerenciadorDeLivros()
        {
            _livros = new List<string>();
        }

        public void AdicionarLivro(string titulo)
        {
            _livros.Add(titulo);
        }

        public List<string> ObterLivros()
        {
            return _livros;
        }
    }

}
