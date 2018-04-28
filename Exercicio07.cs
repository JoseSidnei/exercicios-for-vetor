using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosForVetor
{
    public class Exercicio07
    {
        public Exercicio07()
        {
            /* 7. Solicite ao usuário 20 caracteres armazenando em um vetor. Após isto verifique e
                  apresente os itens abaixo:

                  ➔ Quantas são as consoantes
                  ➔ Quantas são as vogais;
                  ➔ Quantos são caracteres especiais.
                  ➔ Quais são as consoantes;
                  ➔ Quais são as vogais;
                  ➔ Quais são os caracteres especiais. */


            Console.WriteLine("Digite 20 caracteres ");
            Console.WriteLine();

            double somaVogalA = 0, somaVogalE = 0, somaVogalI = 0, somaVogalO = 0, somaVogalU = 0, somaVogais = 0,
                   somaConsoanteB = 0, somaConsoanteC = 0, somaConsoanteD = 0, somaConsoanteF = 0, somaConsoanteG = 0, somaConsoanteH = 0,
                   somaConsoanteJ = 0, somaConsoanteK = 0, somaConsoanteL = 0, somaConsoanteM = 0, somaConsoanteN = 0,somaConsoanteP = 0, 
                   somaConsoanteQ = 0, somaConsoanteR = 0, somaConsoanteS = 0, somaConsoanteT = 0, somaConsoanteV = 0, somaConsoanteW = 0, 
                   somaConsoanteX = 0, somaConsoanteY = 0, somaConsoanteZ = 0, somaConsoante = 0;

            string[] caracter = new string[20];

            for (int i = 0; i < 20; i++)
            {
                Console.Write("Caracter: ");
                caracter[i] = Console.ReadLine().ToUpper();

                

                if (caracter[i] == "A")
                {
                    somaVogalA = somaVogalA + 1;
                }
                else if (caracter[i] == "E")
                {
                    somaVogalE = somaVogalE + 1;
                }
                else if (caracter[i] == "I")
                {
                    somaVogalI = somaVogalI + 1;
                }
                else if (caracter[i] == "O")
                {
                    somaVogalO = somaVogalO + 1;
                }
                else if (caracter[i] == "U")
                {
                    somaVogalU = somaVogalU + 1;
                }

                somaVogais = somaVogalA + somaVogalE + somaVogalI + somaVogalO + somaVogalU;

                if (caracter[i] == "B")
                {
                    somaConsoanteB = somaConsoanteB + 1;
                }
                else if (caracter[i] == "C")
                {
                    somaConsoanteC = somaConsoanteC + 1;
                }
                else if (caracter[i] == "D")
                {
                    somaConsoanteD = somaConsoanteD + 1;
                }
                else if (caracter[i] == "F")
                {
                    somaConsoanteF = somaConsoanteF + 1;
                }
                else if (caracter[i] == "G")
                {
                    somaConsoanteG = somaConsoanteG + 1;
                }
                else if (caracter[i] == "H")
                {
                    somaConsoanteH = somaConsoanteH + 1;
                }
                else if (caracter[i] == "J")
                {
                    somaConsoanteJ = somaConsoanteJ + 1;
                }
                else if (caracter[i] == "K")
                {
                    somaConsoanteK = somaConsoanteK + 1;
                }
                else if (caracter[i] == "L")
                {
                    somaConsoanteL = somaConsoanteL + 1;
                }
                else if (caracter[i] == "M")
                {
                    somaConsoanteM = somaConsoanteM + 1;
                }
                else if (caracter[i] == "N")
                {
                    somaConsoanteN = somaConsoanteN + 1;
                }
                else if (caracter[i] == "P")
                {
                    somaConsoanteP = somaConsoanteP + 1;
                }
                else if (caracter[i] == "Q")
                {
                    somaConsoanteQ = somaConsoanteQ + 1;
                }
                else if (caracter[i] == "R")
                {
                    somaConsoanteR = somaConsoanteR + 1;
                }
                else if (caracter[i] == "S")
                {
                    somaConsoanteS = somaConsoanteS + 1;
                }
                else if (caracter[i] == "T")
                {
                    somaConsoanteT = somaConsoanteT + 1;
                }
                else if (caracter[i] == "V")
                {
                    somaConsoanteV = somaConsoanteV + 1;
                }
                else if (caracter[i] == "W")
                {
                    somaConsoanteW = somaConsoanteW + 1;
                }
                else if (caracter[i] == "Y")
                {
                    somaConsoanteY = somaConsoanteY + 1;
                }
                else if (caracter[i] == "Z")
                {
                    somaConsoanteZ = somaConsoanteZ + 1;
                }

                somaConsoante = somaConsoanteB + somaConsoanteC + somaConsoanteD + somaConsoanteF + somaConsoanteG + somaConsoanteH +
                somaConsoanteJ + somaConsoanteK + somaConsoanteL + somaConsoanteM + somaConsoanteN + somaConsoanteP + somaConsoanteQ +
                somaConsoanteR + somaConsoanteS + somaConsoanteT + somaConsoanteV + somaConsoanteW + somaConsoanteX + somaConsoanteY +
                somaConsoanteZ;

            }

            Console.WriteLine("Quantidade Consoantes: " + somaConsoante);
            Console.WriteLine("Quantidade de Vogais: " + somaVogais);
                       


        }
    }
}
