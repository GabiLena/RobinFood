using System;
using System.Collections.Generic;

namespace RobinFood.CLI
{
    internal class Program
    {
        static List<Produto> produtosCadastradas = new List<Produto>();
        static MenuDeLojas menu = new MenuDeLojas();

        static void Main(string[] args)
        {
            bool pediuPraSair = false;

            do
            {
                MostrarIntroducao("BEM VINDO AO ROBIN FOOD");

                Console.WriteLine("Você é um usuário ou uma loja no nosso serviço?");
                Console.WriteLine("Digite A para usuário");
                Console.WriteLine("Digite B para loja");
                Console.WriteLine("Digite X para sair");

                string resposta = Console.ReadLine();
                switch (resposta)
                {
                    case "A":
                    case "a":
                        MenuDoUsuario();
                        break;
                    case "B":
                    case "b":
                        MenuDaLoja();
                        break;
                    default:
                        pediuPraSair = true;
                        break;
                }
            } while (!pediuPraSair);
        }

        static void MostrarIntroducao(string mensagem)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("=====================");
            Console.WriteLine($"===== {mensagem} =====");
            Console.WriteLine("=====================");

            Console.ResetColor();
        }

        static void MenuDaLoja()
        {
            Console.Clear();
            string resposta;
            bool pediuPraVoltarOMenu = false;

            MostrarIntroducao("BEM VINDO A VISUALIZAÇÃO DE LOJA");
            do
            {
                Console.WriteLine("Olá loja, tudo bem? O que você quer?");

                Console.WriteLine("A - Cadastrar minha loja");
                Console.WriteLine("B - Visualizar lojas");
                Console.WriteLine("C - Adicionar Produto");
                Console.WriteLine("D - Visualizar meus produtos");
                Console.WriteLine("X - Para voltar ao menu anterior");

                resposta = Console.ReadLine();

                switch (resposta)
                {
                    case "A":
                    case "a":
                        CadastrarLoja(menu);
                        break;
                    case "B":
                    case "b":
                        VisualizarLojas(menu);
                        break;
                    case "C":
                    case "c":
                        AdicionarProdutoSelecionandoLoja(menu);
                        break;
                    case "D":
                    case "d":
                        VisualizarProdutos();
                        break;
                    default:
                        pediuPraVoltarOMenu = true;
                        break;
                }
            } while (!pediuPraVoltarOMenu);
        }

        static void MenuDoUsuario()
        {
            //Console.Clear();
            //MostrarIntroducao("MENU DO USUÁRIO");

            //Console.WriteLine("Olá usuário, tudo bem? O que você quer?");

            //Console.WriteLine("1 - Visualizar os restaurantes cadastrados");
            //Console.WriteLine("2 - Buscar um item específico");
            //Console.WriteLine("3 - Me cadastrar no sistema");

            //string resposta = Console.ReadLine();

            //switch (resposta)
            //{
            //    case "1":
            //        VisualizarLojas();
            //        break;
            //    // case "2":
            //    //   BuscarItem();
            //    // break;
            //    case "3":
            //        CadastroDeUsuario cadastro = new CadastroDeUsuario();
            //        Console.WriteLine("Escreva seu nome: ");
            //        break;
            //}
        }

        static void AdicionarProdutoSelecionandoLoja(MenuDeLojas menu)
        {
            Console.Clear();

            Console.WriteLine("Qual é a sua loja?: ");

            foreach (var loja in menu.ListaDeLojas)
            {
                Console.WriteLine(loja.Nome);
            }

            var listaDeLojas = menu.ListaDeLojas;

            var nomedaloja = Console.ReadLine();

            Console.WriteLine("adicione o valor:");
            var valor = Console.ReadLine();
            var valordecimal = decimal.Parse(valor);

            Console.WriteLine("adicione o produto:");
            string nomeproduto = Console.ReadLine();

            Produto produto = new Produto(nomeproduto, valordecimal, nomedaloja);
            produtosCadastradas.Add(produto);
        }

        //static void AdicionarProdutoFeitoPeloNorton()
        //{
        //  Console.WriteLine("adicione o valor:");
        //decimal valor = decimal.Parse(Console.ReadLine());

        //Console.WriteLine("adicione o produto:");
        //string nome = Console.ReadLine();

        //  produtosCadastradas.Add(new Produto(nome,valor));
        //}

        static void CadastrarLoja(MenuDeLojas menu)
        {
            Console.Clear();
            Console.WriteLine("Digite o nome da loja:");
            string nomeDaLoja = Console.ReadLine();

            var loja = new Loja(nomeDaLoja);
            menu.ListaDeLojas.Add(loja);
        }

        static void VisualizarLojas(MenuDeLojas menu)
        {
            Console.Clear();
            foreach (var loja in menu.ListaDeLojas)
            {
                Console.WriteLine(loja.Nome);
            }

            Console.WriteLine("Número total de lojas: " + menu.ListaDeLojas.Count);
        }

        static void VisualizarProdutos()
        {
            Console.Clear();

            Console.WriteLine("De qual loja deseja ver os produtos?");

            foreach (var loja in menu.ListaDeLojas)
            {
                Console.WriteLine(loja.Nome);
            }

            Console.WriteLine (menu.ListaDeLojas.Count);

            foreach (var produto in produtosCadastradas)
            {
                Console.WriteLine("Nome da loja: " + produto.NomeLoja);
                Console.WriteLine("Nome do produto: " + produto.Nome);
                Console.WriteLine("Valor do produto: R$" + produto.Valor);
            }

            Console.WriteLine("Produtos Cadastrados: " + produtosCadastradas.Count);
        }
    }
}
