namespace RobinFood.CLI
{
    public class Produto
    {
        public Produto(string nome, decimal valor)
        {
            Nome = nome;
            Valor = valor;
        }
        public decimal Valor { get; set; }
        public string Nome { get; set; }
    }
}