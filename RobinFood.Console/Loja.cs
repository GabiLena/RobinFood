using System.Collections.Generic;

namespace RobinFood.CLI
{
    public class Loja
    {
        public Loja(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; set; }
        public List<Produto> Produtos { get; set; } = new List<Produto>();
    }
}
