using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula08Listaserepeticao
{
    class Program
    {

        
        static void Main(string[] args)
        {
            List<string> nomes =new  List<string>();

            nomes.Add("Stella");
            nomes.Add("William");
            nomes.Add("Luis");

            int contador = 0;
            while ( contador < nomes.Count )
            {
                Console.WriteLine("O nome é"+nomes[contador]);
                contador++;
            }





            Console.ReadKey();
        }


    }

    void Arrays ()
        {

            string[] nomes = new string[3];
            int[] idades = { 19, 20, 35, 31, 18 };

          
            nomes[0] = "Conrado";
            nomes[2] = "William";
            nomes[1] = "Victor";



            Console.WriteLine("o nome da primeira posição é: " + nomes[0]);
            Console.WriteLine("o nome da segunda posição é: " + nomes[2]);
            Console.WriteLine("o nome da terceira posição é: " + nomes[1]);




        }

        void Listas ()
        {
            List<string> nomes = new List<string>();

            nomes.Add("Conrado");
            nomes.Add("William");
            nomes.Add("Dresch");


            Console.WriteLine("A primeira posição é " + nomes[0]);
            Console.WriteLine("A primeira posição é " + nomes[1]);
            Console.WriteLine("A primeira posição é " + nomes[2]);

            nomes.Remove("William");
            nomes.Remove("Dresch");


            int quantidade = nomes.Count;
            Console.WriteLine($"Existem {quantidade} itens dentro da lista");

            Console.ReadKey();

        }

        void atividade ()
        {
            List<string> nome = new List<string>();
            int buscar = 2;



            Console.WriteLine("Cadastro de usúarios\n");
            Console.WriteLine("1 - Cadastrar");
            Console.WriteLine("2 - Buscar");

            Console.WriteLine("Digite uma Opção:");
            Console.ReadLine();

            if (buscar == 2) ;
            {
                Console.WriteLine("Digite a Posição que quer buscar: ");


            }



        }

        void loop ()
        {
            // Repetições (loop)

            int contador = 0;

            while (contador < 5)
            {
                Console.WriteLine("Olá");
                contador = contador + 1;

            }

            // 

            Console.ReadKey();
        }
    }
}
