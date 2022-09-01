using System;

public class Class1
{
	public Class1()
	{
        public void MenuDoUsuario()
        {
            MostrarIntroducao("MENU DO USUÁRIO");
            string resposta;
            Console.WriteLine("Olá usuário, tudo bem? O que você quer?");

            Console.WriteLine("1 - Visualizar os restaurantes cadastrados");
            Console.WriteLine("2 - Buscar um item específico");
            Console.WriteLine("3 - Me cadastrar no sistema");

            resposta = Console.ReadLine();

            switch (resposta)
            {
                case "1":
                    VisualizarLojas();
                    break;
                case "2":
                    BuscarItem();
                    break;
                case "3":
                    CadastroDeUsuario();
                    break;
                default;
            }
}
