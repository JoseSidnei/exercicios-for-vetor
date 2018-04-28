using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosForVetor
{
    public class Exercicio03
    {
        public Exercicio03()
        {
            /* 3. Desenvolver um programa que armazene preços, deve-se solicitar ao usuário a
            // quantidade de registros que o mesmo deseja armazenar. Após isto, solicitar os
            // preços de acordo com a quantidade de registros.
            // Ao final apresentar todos os preços e o total dos preços.

             Observação: não deve ser solicitado o preço total e sim utilizar o vetor.*/


            Console.Write("Quantidade de resgistros: ");
            int quantidadeRegistros = Convert.ToInt32(Console.ReadLine());

            double[] precos = new double[quantidadeRegistros];
            for (int i = 0; i < precos.Length; i++)
            {
                Console.Write("Preço: ");
                precos[i] = Convert.ToDouble(Console.ReadLine());
               
            }

                 double somaPreco = 0;
            for (int i = 0; i < precos.Length; i++)
            {
                somaPreco = precos[i] + somaPreco;
            }

            Console.WriteLine("Soma  dos preços: R$ " + somaPreco);

        }
    }
}
