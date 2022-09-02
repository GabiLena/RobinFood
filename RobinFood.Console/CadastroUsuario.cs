using System;
using System.Collections.Generic;
using System.Text;

namespace RobinFood.CLI
{
    internal class CadastroUsuario
    {
        public CadastroUsuario(string nome, int cpf, string email)
        {
            nome = nome;
            cpf = cpf;
            email = email;  
        }
        public string nome { get; set; }    
        public int cpf { get; set; }    
        public string email { get; set; }
    }
}
