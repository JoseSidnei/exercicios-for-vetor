using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosForVetor
{
    public class Exercicio08
    {
        public Exercicio08()
        {
            /* 8. Solicite ao usuário quantos números ele deseja cadastrar, crie um vetor com este
                  tamanho, solicite os números ao usuário e armazene no vetor.
                  Após isto criar um vetor de ímpares e outro de pares com o tamanho do vetor original.
                  Armazenar os números pares do vetor original no vetor par.
                  Armazenar os números ímpares do vetor original no vetor ímpar.

                  Vetor original:
                  39 52 70 11 54
                  Vetor par:
                  52 70 54 0 0
                  Vetor ímpar:
                  39 11 0 0 0
                  Deve-se apresentar os números do vetor original, do vetor par e do vetor ímpar.

                  Exemplo:
                  Vetor original: 39, 52, 70, 11, 54
                  Vetor par: 52, 70, 54
                  Vetor ímpar: 39, 11                  */

            Console.Write("Quantidade de Números que deseja cadastrar: ");
            int quantidadeNumeros = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            int[] numeros = new int[quantidadeNumeros];

            for (int i = 0; i < quantidadeNumeros; i++)
            {
                Console.Write("Número: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Clear();
            Console.Write("Vetor Original: ");

            for (int i = 0; i < quantidadeNumeros; i++)
            {
                Console.Write(numeros[i] + ", ");
                
                
            }

            Console.WriteLine();
            Console.Write("Neutro: ");

            for (int i = 0; i <quantidadeNumeros; i++)
            {
                if (numeros[i] == 0)
                {
                    Console.WriteLine(numeros[i]);
                }
                else if (numeros[i] % 2 == 0)
                {
                    Console.Write("Vetor Par ");
                    Console.Write(numeros[i] + ", ");
                }
                else if (numeros[i] % 2 != 0)
                {
                    Console.WriteLine();
                    Console.Write("Vetor ìmpar ");
                    Console.Write(numeros[i] + ", ");
                }
            }
            Console.WriteLine();
           
        }
    }
}
