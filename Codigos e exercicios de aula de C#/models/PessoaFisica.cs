using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//caminho para junção de pastas
namespace Codigos_e_exercicios_de_aula_de_C_.models
{
    public class PessoaFisica
    {
        public string? Nome { get; set; }
        public int idade { get; set; }

        public void apresentar(){
            System.Console.WriteLine($"ola, meu nome e {Nome}, e tenho {idade} anos");
        }
    }
}