using System;
using System.Collections.Generic;

namespace RobinFood.CLI
{
    internal class Program
    {
        static List<string> lojasCadastradas = new List<string>();

        string MenuDoUsuario = new MenuDoUsuario();
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
            MostrarIntroducao("BEM VINDO A VISUALIZAÇÃO DE LOJA");
            
            string resposta;
            bool pediuPraVoltarOMenu = false;
            do
            {
                Console.WriteLine("Olá loja, tudo bem? O que você quer?");

                Console.WriteLine("A - Cadastrar minha loja");
                Console.WriteLine("B - Visualizar lojas");
                Console.WriteLine("X - Para voltar ao menu anterior");

                resposta = Console.ReadLine();

                switch (resposta)
                {
                    case "A":
                    case "a":
                        CadastrarLoja();
                        break;
                    case "B":
                    case "b":
                        VisualizarLojas();
                        break;
                    default:
                        pediuPraVoltarOMenu = true;
                        break;
                }
            } while (!pediuPraVoltarOMenu);
        }
      // static void MenuDoUsuario()
        //{
          //  MostrarIntroducao("MENU DO USUÁRIO");
            //string resposta;
            //Console.WriteLine("Olá usuário, tudo bem? O que você quer?");

            //Console.WriteLine("1 - Visualizar os restaurantes cadastrados");
            //Console.WriteLine("2 - Buscar um item específico");
            //Console.WriteLine("3 - Me cadastrar no sistema");

            //resposta = Console.ReadLine();

            //switch (resposta)
               // {
              //  case "1":
                //    VisualizarLojas();
                  //  break;
                //*case "2":
                    //BuscarItem();
                  //  break;
                //case "3":
                    //CadastroDeUsuario();
                    //default;

          //  }
        //}
        static void CadastrarLoja()
        {
            Console.WriteLine("Digite o nome da loja:");
            string nomeDaLoja = Console.ReadLine();
            lojasCadastradas.Add(nomeDaLoja);
        }
        static void VisualizarLojas()
        {
            foreach (var item in lojasCadastradas)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Número total de lojas: " + lojasCadastradas.Count);
            //testando git
        }
    }
}
