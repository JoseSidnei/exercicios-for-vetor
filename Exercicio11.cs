using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosForVetor
{
    public class Exercicio11
    {
        public Exercicio11()
        {
            /* 11.Solicitar 5 nomes para o usuário armazenando ao vetor.
                  Exemplo do vetor de nomes
                  __________________________________________
                  |Lucas | Paulo | Lúcia | Pedro | Jennifer|
                 
                  Apresentar da seguinte forma os nomes 
                  Lucas, Paulo, Lúcia, Pedro e Jennifer. */

            string[] nomes = new string[5];
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.Write("Nome: ");
                nomes[i] = Console.ReadLine().ToLower();
            }

            Console.WriteLine();
            Console.Write(nomes[0] + ", "  + nomes[1] + ", " + nomes[2] + ", " + nomes[3] + " e " + nomes[4]);
            Console.WriteLine();
            

        }
    }
}
