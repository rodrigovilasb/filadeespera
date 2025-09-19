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
        static void Main(string[] args)
        {
            paciente[] fila = new paciente[15];
            int qtd = 0;

           public void Menu()
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1 - Adicionar paciente");
            Console.WriteLine("2 - Listar pacientes");
            Console.WriteLine("3 - Atender pacientes");
            Console.WriteLine("4 - Alterar dados do paciente");
            Console.WriteLine("q - Sair");
            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine();
            switch (opcao)
            {
                case "1":
                    AdicionarPaciente();
                    break;
                case "2":
                    ListarPaciente();
                    break;
                case "3":
                    AtenderPaciente();
                    break;
                case "4":
                    AlterarDados();
                    break;
                case "q":
                    Console.WriteLine("Saindo...");
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
        }
    }
}
