using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosForVetor
{
    public class Exercicio09
    {
        public Exercicio09()
        {
            /* 9. Crie um vetor para armazenar as notas de uma disciplina. A disciplina deve
                  conter 4 notas.
                  Solicite para o usuário o nome e as quatro notas, armazenando as notas em um
                  vetor.
                  Após armazenar as notas faça o cálculo da média.
                  Apresentar as 4 notas e a média.*/

            
            double[] notas = new double[4];
            

            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine();

            double media = 0;

            for (int i = 0; i < 4; i++)
            {
                Console.Write("Nota: ");
                notas[i] = Convert.ToDouble(Console.ReadLine());

                media = (notas[0] + notas[1] + notas[2] + notas [3]) /4;
                


            }

            Console.Clear();
            Console.Write("Notas: ");
                       
            for (int i = 0; i < 4; i++)
            {
                Console.Write(notas[i] + ", ");
            }

            Console.WriteLine();
            Console.WriteLine("Media: " + media);
            

        }
    }
}
