using System;

namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta acc = new Conta(1001, "Evelynn", 0.0);
            Juridica bacc = new Juridica(1002, "Ahri", 0.0, 500.0);

            

            Conta acc1 = bacc;
            Conta acc2 = new Juridica(1003, "Kaisa", 0.0, 500.0);
            Conta acc3 = new Poupanca(1004, "Akali", 0.0, 0.01);

            

            Juridica acc4 = (Juridica)acc2;
            acc4.Emprestimo(100);

            if (acc3 is Juridica)
            {
                Juridica acc5 = (Juridica)acc3;
                acc5.Emprestimo(200);
                Console.WriteLine("Emprestimo!");
            }

            if (acc3 is Poupanca)
            {
                Poupanca acc5 = acc3 as Poupanca;
                acc5.atualizacaoSaldo();
                Console.WriteLine("Atualizado!");
            }
        }
    }
}

