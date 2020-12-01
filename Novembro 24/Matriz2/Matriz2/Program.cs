using System;

namespace Matriz2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a quantidade de linhas: ");
            int linha = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de colunas:");
            int col = int.Parse(Console.ReadLine());

            double[,] mat = new double[linha, col];

            for (int x = 0; x < linha; x++)
            {
                for (int y = 0; y < col; y++)
                {
                    Console.WriteLine("Entre com a posição X:" + x.ToString() + " x  Y: " + y.ToString());
                    mat[x, y] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Matriz: " + linha + " , " + col);

            for (int x = 0; x < linha; x++)
            {
                for (int y = 0; y < col; y++)
                {
                    Console.Write(mat[x, y] + "  ");
                }

            }

            Console.WriteLine("Digite um número que tenha na Matriz: ");
            int valor = int.Parse(Console.ReadLine());

            int count = 0;

            Console.WriteLine("Diagonal Principal: ");

            for (int x = 0; x < linha; x++)
            {
                for (int y = 0; y < col; y++)
                {
                    if (x == y)
                    {
                        Console.Write(mat[x, y] + " ");
                    }
                    if (mat[x, y] < 0)
                    {
                        count++;
                    }

                }
            }

            Console.WriteLine("Números negativos: ");
            Console.WriteLine(count);
        }

    }
}
