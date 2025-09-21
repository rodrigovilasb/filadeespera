using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace filadeespera
{
    internal class Program
    {
        static paciente[] fila = new paciente[15];
        static int total = 0;

        static void Main(string[] args)
        {
            bool sair = false;

            while (!sair)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1 - Adicionar paciente");
                Console.WriteLine("2 - Listar pacientes");
                Console.WriteLine("3 - Alterar paciente");
                Console.WriteLine("q - Sair");
                Console.Write("Escolha: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        if (total < fila.Length)
                        {
                            fila[total] = new paciente();
                            fila[total].AdicionarDados();
                            total++;
                            Console.WriteLine("Paciente adicionado!");
                        }
                        else
                        {
                            Console.WriteLine("Fila cheia!");
                        }
                        break;

                    case "2":
                        for (int i = 0; i < total; i++)
                        {
                            Console.Write($"{i + 1} - ");
                            fila[i].MostrarDados();
                        }
                        break;

                    case "3":
                        Console.Write("Digite o número do paciente para alterar: ");
                        int indice = int.Parse(Console.ReadLine()) - 1;
                        if (indice >= 0 && indice < total)
                        {
                            fila[indice].AlterarDados();
                        }
                        else
                        {
                            Console.WriteLine("Número inválido!");
                        }
                        break;

                    case "q":
                        sair = true;
                        Console.WriteLine("Saindo...");
                        break;

                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
        }
    }
}
