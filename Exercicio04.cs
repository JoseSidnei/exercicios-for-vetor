using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosForVetor
{
    public class Exercicio04
    {
        public Exercicio04()
        {
            /* 4. Desenvolver um programa que armazene o tamanho de 40 camisas, após isto

               apresentar:
               ➔ Tamanho de todas as camisas armazenadas
               ➔ Quantidade de camisas PP
               ➔ Quantidade de camisas P
               ➔ Quantidade de camisas M
               ➔ Quantidade de camisas G
               ➔ Quantidade de camisas GG
               ➔ Quantidade de camisas XG
               ➔ Quantidade de camisas XGG
              
               Lembrando que os tamanhos possíveis para camisas são:
               ➔ PP
               ➔ P
               ➔ M
               ➔ G
               ➔ GG
               ➔ XG
               ➔ XGG */



            string[] tamanhos = new string[8];
            for (int i = 0; i < tamanhos.Length; i++)
            {
                Console.Write("Tamanho da camisa: ");
                tamanhos[i] = Console.ReadLine();
            }

            Console.Clear();
            Console.WriteLine("Tamanho de todas as camisas ");
            Console.WriteLine();
            
            int quantidadeAtual = 0;
            double somaTamanhosPP = 0, somaTamanhosP = 0, somaTamanhosM = 0, somaTamanhosG = 0,
                    somaTamanhosGG = 0, somaTamanhosXG = 0, somaTamanhosXGG = 0;
            for (int i = 0; i < tamanhos.Length; i++)
            {
                Console.WriteLine("Tamanho da camisa: " + tamanhos[i]);



                if (tamanhos[i] == "PP" || tamanhos[i] == "pp")
                {
                    somaTamanhosPP = somaTamanhosPP + 1;
                }
                else if (tamanhos[i] == "P" || tamanhos[i] == "p")
                {
                    somaTamanhosP = somaTamanhosP + 1;
                }
                else if (tamanhos[i] == "M" || tamanhos[i] == "m")
                {
                    somaTamanhosM = somaTamanhosM + 1;
                }
                else if (tamanhos[i] == "G" || tamanhos[i] == "g")
                {
                    somaTamanhosG = somaTamanhosG + 1;
                }
                else if (tamanhos[i] == "GG" || tamanhos[i] == "gg")
                {
                    somaTamanhosGG = somaTamanhosGG + 1;
                }
                else if (tamanhos[i] == "XG" || tamanhos[i] == "xg")
                {
                    somaTamanhosXG = somaTamanhosXG + 1;
                }
                else if (tamanhos[i] == "XGG" || tamanhos[i] == "xgg")
                {
                    somaTamanhosXGG = somaTamanhosXGG + 1;

                }
            }

            Console.WriteLine();
            Console.WriteLine("Quantidade de camisas PP: " + somaTamanhosPP);
            Console.WriteLine("Quantidade de camisas P: " + somaTamanhosP);
            Console.WriteLine("Quantidade de camisas M: " + somaTamanhosM);
            Console.WriteLine("Quantidade de camisas G: " + somaTamanhosG);
            Console.WriteLine("Quantidade de camisas GG: " + somaTamanhosGG);
            Console.WriteLine("Qunatidade de camisas XG: " + somaTamanhosXG);
            Console.WriteLine("Qunatidade de camisas XGG: " + somaTamanhosXGG);







        }
    }
}
