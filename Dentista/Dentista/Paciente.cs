using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentista
{
    class Paciente : Pessoa
    {
        private string numerodopaciente;

        public string Numerodopaciente { get => numerodopaciente; set => numerodopaciente = value; }

        public Paciente(string nome, string sexo) : base(nome, sexo) { }

        override public string Mostra()
        {
            string aux = base.Mostra() + ", Numero do Paciente:" + numerodopaciente;
            return aux;
        }
    }
}
