using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentista
{
    class Data
    {
        private int dia;
        private int mes;
        private int ano;

        public Data()
        {
        }

        public bool GravarData(int dia, int mes, int ano)
        {
            if (((dia >= 0) && (dia <= 31)) && ((mes > 0) && (mes < 13)) && (ano > 0))
            {
                this.dia = dia;
                this.mes = mes;
                this.ano = ano;
                return true;
            }
            return false;
        }

        public string MostraData()
        {
            return dia + "/" + mes + "/" + ano;
        }
    }
}
