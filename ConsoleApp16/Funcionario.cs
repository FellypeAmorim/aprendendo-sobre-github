using System;
using System.Collections.Generic;
using System.Text;

namespace ListadeFuncionario
{
    class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; private set; }

        public Funcionario(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        

        public void AumentoSalario (double aumento)
        {
            Salario += Salario * aumento / 100;
        }

        public override string ToString()
        {
            return Id + ", " + Nome + ", R$" + Salario.ToString("F2");
        }


    }
}
