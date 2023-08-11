using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula08ListasRepeticao
{
    class Program
    {

        //static List<string> nomes = new List<string>();
        static void Main(string[] args)
        {
            //Repetições (loop)
            while (1>0)
            {
                Console.WriteLine("ola");
            }




            



            Console.ReadKey();

            
        }






        void arrays()
        {
            String[] nomes = new string[3];
            int[] idades = { 19, 20, 18, 19, 31, 25 };
            nomes[0] = "Conrado";
            nomes[2] = "Camila";
            nomes[1] = "Stella";



            Console.WriteLine("O nome da primeira posição é:" + nomes[0]);
            Console.WriteLine("O nome da segunda posição é:" + nomes[1]);
            Console.WriteLine("O nome da terceira posição é:" + nomes[2]);


            Console.ReadKey();
        }

        void list()
        {
            List<string> nomes = new List<string>();

            nomes.Add("Conrado");
            nomes.Add("Camila");
            nomes.Add("Stella");

            Console.WriteLine("A primeira posição é " + nomes[0]);
            Console.WriteLine("A primeira posição é " + nomes[1]);
            Console.WriteLine("A primeira posição é " + nomes[2]);

            nomes.RemoveAt(2);

            int quantidade = nomes.Count;
            Console.WriteLine($"Existem {quantidade} itens dentro da lista");





            Console.ReadKey();
        }

        void atividade()
        {
            //static List<string> nomes = new List<string>();
            static void Main(string[] args)
            {
                List<string> nomes = new List<string>();
                int posicao;

                Console.WriteLine("Cadastro de usuários");
                Console.WriteLine("1-Cadastrar");
                Console.WriteLine("2-Buscar");
                Console.WriteLine("Digite uma opção:");
                posicao = int.Parse(Console.ReadLine());

                if (posicao == 1)
                {
                    Console.WriteLine("Digite o nome que deseja cadastrar:");

                    nomes.Add(Console.ReadLine());
                }
                Console.WriteLine("Nome cadastrado com sucesso");

                if (posicao == 2)
                {
                    Console.WriteLine("Digite a posição que quer buscar:");
                    Console.ReadLine();

                    //int quantidade = nomes.Count;
                    //Console.WriteLine(quantidade);

                }


                Console.ReadKey();
            }
    }
}
