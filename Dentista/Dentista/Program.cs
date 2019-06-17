using System;

namespace Dentista
{
    class Program
    {
        static void Main(string[] args)
        {
            int op = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("1. Ver lista de pacientes.");
                Console.WriteLine("2. Ver lista de dentistas disponíveis.");
                Console.WriteLine("3. Cadastrar paciente.");
                Console.WriteLine("4. Agendar paciente.");
                Console.WriteLine("5. Ver lista de dentistas.");
                Console.WriteLine("6. Sair.");
                op=int.Parse(Console.ReadLine());
            } while (op != 6);
        }
    }
}
