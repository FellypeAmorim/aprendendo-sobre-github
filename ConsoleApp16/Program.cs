using System;
using System.Collections.Generic;

namespace ListadeFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos funcionários serão registrados?: ");
            int numerofuncionario = int.Parse(Console.ReadLine());

            List < Funcionario > dadosfuncionario = new List<Funcionario>() ;

            for (int i = 1; i<= numerofuncionario; i++)
            {
                Console.WriteLine("Empregado #" + i + ":");
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine());
                dadosfuncionario.Add(new Funcionario(id, nome, salario));
                Console.WriteLine();

            }

            Console.WriteLine("Entre com a ID do funcionário que receberá o aumento: ");
            int procurarID = int.Parse(Console.ReadLine());

            Funcionario funcionarioid = dadosfuncionario.Find(x => x.Id == procurarID);
            if (funcionarioid != null)
            {
                Console.WriteLine("Entre com a porcentagem: ");
                double aumento = double.Parse(Console.ReadLine());
                funcionarioid.AumentoSalario(aumento);
            }
            else
            {
                Console.WriteLine("Esta ID não existe. ");
            }
            Console.WriteLine();
            Console.WriteLine("Lista de funcionários atualizada: ");
            foreach(Funcionario funcionariolista in dadosfuncionario)
            {
                Console.WriteLine(funcionariolista);
            }

        }
    }
}
