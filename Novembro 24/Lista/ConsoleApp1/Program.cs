using System;
using System.Collections.Generic;

namespace Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> minhaLista;
            minhaLista = new List<int>(); //Lista Criada
                                          //Adicionar == add
            minhaLista.Add(10);
            minhaLista.Add(20);
            minhaLista.Add(30);
            minhaLista.Insert(2, 22); // Vai inserir o item na posição especifica nesse caso  2 e 22 


            Console.WriteLine("Quantos elementos  a na minha lista: " + minhaLista.Count); // quantos elementos na lista.
            Console.WriteLine("-------------------------");

            minhaLista.RemoveAt(3); //Remove o item especifico
                                    //Sabendo que ainda existe o RemoveAll(Remove determinado elemento da lista), Remove(elementos da lista),e RemoveRange(Remove elementos da lista a partir da posição e quantos elementos)


            //loop
            foreach (int item in minhaLista)
            {
                Console.WriteLine(item);

            }



            Console.ReadKey();       }
    }
}


