using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentista
{
    class Funcionario : Pessoa
    {
        private string funcao;

        public string Funcao { get => funcao; set => funcao = value; }
        public Funcionario(string nome, string sexo) : base(nome, sexo) { }

        override public string Mostra()
        {
            string aux= base.Mostra() + ", Função do Funcionario:" + funcao;
            return aux;
        }
    }
}
