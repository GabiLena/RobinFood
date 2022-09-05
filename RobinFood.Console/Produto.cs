namespace RobinFood.CLI
{
    public class Produto
    {
        public Produto(string nome, decimal valor,string nomeLoja)
        {
            Nome = nome;
            Valor = valor;
            NomeLoja = nomeLoja;
        }
        public decimal Valor { get; set; }
        public string NomeLoja { get; }
        public string Nome { get; set; }
    }
}