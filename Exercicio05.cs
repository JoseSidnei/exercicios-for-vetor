using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosForVetor
{
    public class Exercicio05
    {
        public Exercicio05()
        {
            /* 5. A empresa GameVicio precisa armazenar os jogos que tem em estoque, para tal
              deve-se armazenar o nome e a quantidade de jogos. Para tal utilize um vetor para o
              nome dos jogos e outro vetor para a quantidade de jogos.
              Ao final apresente o nome concatenado com a quantidade.

              Exemplo:
              Nome Unidades
              Horizon Zero Dawn 190
              God Of War 350
              Spider-Man 59
              Injustice 2 27
              Crash Bandicoot 41
              Grand Theft Auto V 12
              Observação: A quantidade de jogos que serão cadastrados é o usuário que irá definir;*/

            

            Console.Write("Quantidade de jogos para casdatrar: ");
            int quantidadeJogosCadastro = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();


            string[] nomes = new string[quantidadeJogosCadastro];
            int[] quantidadeJogos = new int[quantidadeJogosCadastro];

            for (int i = 0; i < quantidadeJogosCadastro; i++)
            {
                Console.Write("Nome: ");
                nomes[i] = Console.ReadLine();
                Console.Write("Quantidade: ");
                quantidadeJogos[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }

            Console.Clear();
            Console.WriteLine("Nome Unidade ");
            Console.WriteLine();

            for(int i = 0; i < quantidadeJogosCadastro; i++)
            {
                Console.WriteLine("Nome: " + nomes[i] + " Unidades: " + quantidadeJogos[i]);
                
            }
        }
    }
}
