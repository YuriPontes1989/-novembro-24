using System;

namespace Matriz1
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
                Console.WriteLine("");
            }

            Console.WriteLine("informe um numéro que tenha na Matriz: ");
            int valor = int.Parse(Console.ReadLine());

            int posX = -1;
            int posY = -1;

            for (int x = 0; x < linha; x++)
            {
                for (int y = 0; y < col; y++)
                {
                    if (valor == mat[x, y])
                    {
                        posX = x;
                        posY = y;

                        Console.WriteLine("Posição: " + posX.ToString() + " , " + posY.ToString());
                        if (((posY - 1) >= 0) && ((posY - 1) <= (col - 1)))
                        {
                            Console.WriteLine("Esquerda: " + mat[posX, posY - 1].ToString());
                        }
                        if (((posY + 1) >= 0) && ((posY + 1) <= (col - 1)))
                        {
                            Console.WriteLine("Direita: " + mat[posX, posY + 1].ToString());
                        }
                        if (((posX - 1) >= 0) && ((posX - 1) <= (linha - 1)))
                        {
                            Console.WriteLine("Cima: " + mat[posX - 1, posY].ToString());
                        }
                        if (((posX + 1) >= 0) && ((posX + 1) <= (linha - 1)))
                        {
                            Console.WriteLine("Baixo: " + mat[posX + 1, posY].ToString());
                        }
                    }
                }
            }
        }
    }
}
