﻿using System;
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
            int quantidadePar = 0, quantidadeImpar = 0, quantidadeNeutro = 0, quantidadeNegativo = 0, quantidadepositivo = 0;

            int[] numeros = new int[10];
            double somaFinal = 0, mediaDosNumeros = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = rndNumero.Next(0, 100) ;
                Console.WriteLine("Numero : " + numeros[i]);


            }

            Console.Clear();
            Console.WriteLine("Todos os números armazenados ");

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Numero: " + numeros[i]);

                 somaFinal = numeros[i] + somaFinal;
                 mediaDosNumeros = somaFinal / 10;

                
            }

            Console.WriteLine();
            Console.WriteLine("Soma final dos números: " + somaFinal);
            Console.WriteLine("Média dos numeros: " + mediaDosNumeros);
            Console.WriteLine();

            for (int i = 0; i < numeros.Length; i++)
            {
                
                if (numeros[i] % 2 == 0)
                {
                    quantidadePar = quantidadePar + 1;                   
                }
                else if (numeros[i] < 0)
                {
                    quantidadepositivo = quantidadepositivo + 1;
                }
                else if (numeros[i] % 2 != 0)
                {
                    quantidadeImpar = quantidadeImpar + 1;                    
                }
                else if (numeros[i] < 0)
                {
                    quantidadeNegativo = quantidadeNegativo + 1;
                }
                else if (numeros[i] == 0)
                {
                    quantidadeNeutro = quantidadeNeutro + 1;
                }


            }

            Console.WriteLine("Quantidade de nuemros Par: " + quantidadePar);
            Console.WriteLine("Quantidade de números positivos: " + quantidadepositivo);
            Console.WriteLine("Quantidade d números ìmpar " + quantidadeImpar);
            Console.WriteLine("Quantidade de números negativos: " + quantidadeNegativo);
            Console.WriteLine("Número Neutro: " + quantidadeNeutro);

        }

    }
}
