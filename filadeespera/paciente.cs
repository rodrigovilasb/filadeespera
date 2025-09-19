using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace filadeespera
{
    internal class paciente
    {
        public string nome;
        public string cpf;
        public int idade;
        public bool preferencial;

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
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
        public void AlterarDados()
        {
            Console.Write("Digite o novo nome do paciente: ");
            nome = Console.ReadLine();
            Console.Write("Digite o novo CPF do paciente: ");
            cpf = Console.ReadLine();
            Console.Write("Digite a nova idade do paciente: ");
            idade = int.Parse(Console.ReadLine());
            preferencial = idade >= 60;
            Console.WriteLine("Dados alterados com sucesso!");
        }
        
        public void ListarPaciente()
        {
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("CPF: " + cpf);
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("Preferencial: " + (preferencial ? "Sim" : "Não"));
            Console.WriteLine();
        }

        public void AdicionarPaciente()
        {
            Console.Write("Digite o nome do paciente: ");
            nome = Console.ReadLine();
            Console.Write("Digite o CPF do paciente: ");
            cpf = Console.ReadLine();
            Console.Write("Digite a idade do paciente: ");
            idade = int.Parse(Console.ReadLine());
            preferencial = idade >= 60;
            Console.WriteLine("Paciente adicionado com sucesso!");
        }

        public void AtenderPaciente()
        {
            Console.WriteLine("Atendendo paciente: " + nome);
            nome = null;
            cpf = null;
            idade = 0;
            preferencial = false;
            Console.WriteLine("Paciente atendido com sucesso!");
        }
    }
}
