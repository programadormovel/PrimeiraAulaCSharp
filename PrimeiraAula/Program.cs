using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiraAula
{
    internal class Program
    {
        // Atributos
        // Métodos
        static void Main(string[] args)
        {
            // algoritmo
            Console.Write("Hello World!");
            Console.WriteLine("Mais uma linha!");

            string nome = "Maria José";

            Console.WriteLine("O nome da pessoa: \n" + nome);

            Console.Write("Entre com um novo nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("O nome da pessoa: " + nome);


            Console.Write("Entre com um número: ");
            int numero = Convert.ToInt16(Console.ReadLine());
            Console.Write("O número digitado foi " + numero);

            Console.ReadKey();


        }
    }
}
