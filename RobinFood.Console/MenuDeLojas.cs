using System;
using System.Collections.Generic;
namespace RobinFood.CLI
{
    public class MenuDeLojas
    {
        public List<Loja> ListaDeLojas { get; set; } = new List<Loja>();

        public void VisualizarLojas()
        {
            foreach (var loja in ListaDeLojas)
            {
                Console.WriteLine(loja.Nome);
            }

            Console.WriteLine("Número total de lojas: " + ListaDeLojas.Count);
        }


    }


}
