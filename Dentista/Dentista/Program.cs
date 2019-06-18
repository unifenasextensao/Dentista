using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> LP = new List<Pessoa>();
            List<Pessoa> LF = new List<Pessoa>();
            int op=0;
            string n, s, np;
            bool x = false, y = false;
            int d, m, a;
            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("----------Centro odontologico----------");
                    Console.WriteLine("1-Cadastrar Paciente.");
                    Console.WriteLine("2-Cadastrar Funcionario.");
                    Console.WriteLine("3-Mostrar Pacientes Cadastrados.");
                    Console.WriteLine("4-Mostrar Funcionarios Cadastrados.");
                    Console.WriteLine("5-Sair");
                    Console.WriteLine("---------------------------------------");
                    Console.Write("Digite o número da sua opção:");
                    op = int.Parse(Console.ReadLine());
                    switch (op)
                    {
                        case 1:
                            Console.Write("Nome:");
                            n = Console.ReadLine();
                            Console.Write("Sexo:");
                            s = Console.ReadLine();
                            Paciente P = new Paciente(n, s);
                            do
                            {
                                Console.WriteLine("Digite a data de nascimento.");
                                Console.Write("Dia:");
                                d = int.Parse(Console.ReadLine());
                                Console.Write("Mes:");
                                m = int.Parse(Console.ReadLine());
                                Console.Write("Ano:");
                                a = int.Parse(Console.ReadLine());

                                if (P.datadenascimento.GravarData(d, m, a))
                                    x = true;
                                else
                                {
                                    Console.WriteLine("Data de Nascimento Invalida!");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                            } while (x != true);
                            x = false;
                            do
                            {
                                y = false;
                                Console.Write("Digite o numero do paciente:");
                                np = Console.ReadLine();
                                foreach (Paciente i in LP)
                                {
                                    if (i.Numerodopaciente == np)
                                    {
                                        y = true;
                                    }
                                }
                                if (y)
                                {
                                    Console.WriteLine("ja existe um paciente com esse cadastro, tente novamente outro número!");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                                else
                                {
                                    P.Numerodopaciente = np;
                                    x = true;
                                }
                            } while (x != true);
                            x = false;
                            y = false;
                            LP.Add(P);
                            Console.WriteLine("Paciente Cadastrado com sucesso!");
                            Console.ReadKey();
                            break;
                        case 2:
                            Console.Write("Nome:");
                            n = Console.ReadLine();
                            Console.Write("Sexo:");
                            s = Console.ReadLine();
                            Funcionario F = new Funcionario(n, s);
                            do
                            {
                                Console.WriteLine("Digite a data de nascimento.");
                                Console.Write("Dia:");
                                d = int.Parse(Console.ReadLine());
                                Console.Write("Mes:");
                                m = int.Parse(Console.ReadLine());
                                Console.Write("Ano:");
                                a = int.Parse(Console.ReadLine());
                                if (F.datadenascimento.GravarData(d, m, a))
                                    x = true;
                                else
                                {
                                    Console.WriteLine("Data de Nascimento Invalida!");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                            } while (x != true);
                            x = false;
                            Console.Write("Digite a função do funcionario:");
                            F.Funcao = Console.ReadLine();
                            LF.Add(F);
                            Console.WriteLine("Funcionario Cadastrado com sucesso!");
                            Console.ReadKey();
                            break;
                        case 3:
                            foreach (Pessoa item in LP)
                            {
                                Console.Write(item.Mostra());
                                Console.WriteLine();
                            }
                            Console.ReadKey();
                            break;
                        case 4:
                            foreach (Pessoa item in LF)
                            {
                                Console.Write(item.Mostra());
                                Console.WriteLine();
                            }
                            Console.ReadKey();
                            break;
                        case 5:
                            break;
                        default:
                            Console.WriteLine("Opção Invalida!");
                            Console.ReadKey();
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Formato incorreto!");
                    Console.ReadKey();
                }
                catch
                {
                    Console.WriteLine("Erro! Entrar em contato com os desenvolvedores.");
                    Console.ReadKey();
                }
            } while (op != 5);
        }
    }
}
