using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosForVetor
{
    public class Exercicio06
    {
        public Exercicio06()
        {

            /* 6. Crie um vetor que irá armazenar 10 números. Estes números deverão ser número
                  aleatórios.

                  Ao final apresente:
                  ➔ Todos os números armazenados;
                  ➔ A somatória final dos números;
                  ➔ A média dos números;
                  ➔ Quantidade de números pares;
                  ➔ Quantidade de números positivos;
                  ➔ Quantidade de números ímpares;
                  ➔ Quantidade de números negativos;
                  ➔ Quantidade de números neutros.
                  Observação: os números aleatórios devem ser gerados pelo C Sharp. */



            string numero = string.Empty;
            Random rndNumero = new Random();
            numero = rndNumero.Next().ToString();

            int[] numeros = new int[10];

            for (int i = 0; i < numero.Length; i++)
            {
                Console.Write("Numero : " + rndNumero.Next());
                numeros[i] = Convert.ToInt32(Console.ReadLine());


            }

            Console.Clear();
            Console.WriteLine("Todos os números armazenados ");

            for (int i = 0; i < numero.Length; i++)
            {
                Console.WriteLine("Numero: " + numeros[i]);

            }
        }

    }
}
