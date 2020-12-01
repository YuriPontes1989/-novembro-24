using System;
using System.Collections.Generic;
using System.Text;

namespace Salario
{
    class Funcionario
    {
        int id;
        string nome;
        double salario = 0;


        public int Id { get => id; set => id = value; }

        public string Nome { get => nome; set => nome = value; }

        public double Salario { get => salario; set => salario = value; }

        // aumento do salário
        public void aumentaSalario(double porcent)
        {
            salario += salario * (porcent / 100);
        }


        // informações dos funcionários
        public override string ToString()
        {
            return "ID: " + Id + "   Nome: " + Nome + "  Salário: " + Salario;
        }
    }
}
