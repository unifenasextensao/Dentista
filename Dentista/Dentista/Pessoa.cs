using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentista
{
    class Pessoa
    {
        public Data datadenascimento;
        protected string nome;
        protected string sexo;

        public Pessoa(string nome, string sexo)
        {
            this.nome = nome;
            this.sexo = sexo;
            datadenascimento = new Data();
        }



        virtual public string Mostra()
        {
            string aux = "Nome: " + nome + ", Sexo:" + sexo + ", Data de Nascimento:" + datadenascimento.MostraData();
            return aux;
        }


    }


}
