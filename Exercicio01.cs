using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosForVetor
{
    public class Exercicio01
    {
        public Exercicio01() 
        {
            // 1. Desenvolver um programa que armazene 25 nomes, para tal utilize um vetor com 25
            // posições e o comando for​ para armazenar os valores.

            // Observação: para armazenar os valores deve-se solicitar os nomes ao usuário.

            string[] nomes = new string[5];

            for (int i = 0; i < nomes.Length; i++)
            {
                Console.Write("Nome: ");
                nomes[i] = Console.ReadLine();

            }

            Console.Clear();
            Console.WriteLine("Quatidade de Nomes: ");
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine("Nome: " + nomes[i]);
            }



        }
    }
}
