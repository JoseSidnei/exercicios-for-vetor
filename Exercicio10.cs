using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosForVetor
{
    public class Exercicio10
    {
        public Exercicio10()
        {
           // 10.Crie um vetor para guardar 10 nomes, solicite-os e apresente:

             // ➔ Todos os nomes;
             // ➔ Nome com o maior nome;
             // ➔ Nome com o menor nome;
             // ➔ Quantidade de pessoas que contém o nome começando com S;
             // ➔ Quantidade de pessoas que contém o nome começando com A;
             // ➔ Quantidade de pessoas que o último sobrenome é Silva.

            string[] nomes = new string[4];
            string maiorNome = "";
            string menorNome = "ooooooooooooooooooooooooooooooooooooooooooooooooooooooooooo";
            
            int quantidadeLetraS = 0, quantidadeLetraA = 0, quantidadeSilva = 0;
            

            for (int i = 0; i < nomes.Length; i++)
            {
                Console.Write("Nome: ");
                nomes[i] = Console.ReadLine();                
            }

            Console.Clear();
            Console.WriteLine("Todos os Nomes ");
            Console.WriteLine();

            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine("Nome: " + nomes[i]);

                

                if (nomes[i].Length > maiorNome.Length)
                {
                    maiorNome = nomes[i];
                }

                if (nomes[i].Length < menorNome.Length)
                {
                    menorNome = nomes[i];
                } 

                string letra = nomes[i].Substring(0, 1).ToUpper();
                if (letra == "A")
                {
                    quantidadeLetraA = quantidadeLetraA + 1;
                    
                }
                else if (letra == "S")
                {
                    quantidadeLetraS = quantidadeLetraS + 1;
                }
                
                string sobrenome = nomes[i].Substring(10, 15);
                if (sobrenome == "Silva")
                {
                    quantidadeSilva = quantidadeSilva +1;
                }

                
                
                
            }

            Console.WriteLine();
            Console.WriteLine("Maior nome: " + maiorNome);
            Console.WriteLine("Menor nome: " + menorNome);
            Console.WriteLine();
            Console.WriteLine("Quantidade de pessoas que contém o nome começando com S: " + quantidadeLetraS);
            Console.WriteLine("Quantidade de pessoas que contém o nome começando com A: " + quantidadeLetraA);
            Console.WriteLine();
            Console.WriteLine("Quantidade de pessoas que o último sobrenome é Silva: " + quantidadeSilva);

        }
    }
}
