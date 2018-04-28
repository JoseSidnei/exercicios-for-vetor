using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosForVetor
{
    public class Exercicio02
    {
        public Exercicio02()
        {
            // 2. Desenvolver um programa que armazene 7 idades, armazenar em um vetor,
            // solicitando ao usuário e ao final apresentar as idades ao usuário.

            int[] idades = new int[7];

            for (int i = 0; i < idades.Length; i++)
            {
                Console.Write("Idade: ");
                idades[i] = Convert.ToInt32(Console.ReadLine());

            }

            Console.Clear();
            Console.WriteLine("Quantidade de  idades: ");
            for (int i = 0; i < idades.Length; i++)
            {
                Console.WriteLine("Idade: " + idades[i]);
            }



        }
    }
}
