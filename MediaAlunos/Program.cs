using System;

namespace MediaAlunos
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor01, valor02, valor03, valor04, valor05;
            double eficiencia;
  

            Console.WriteLine("Digite cada valor da amostra e aperte enter.");

            Console.WriteLine("Entre com a media 01: ");
            valor01 = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com a media 02: ");
            valor02 = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com a media 03: ");
            valor03 = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com a media 04: ");
            valor04 = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com a media 05: ");
            valor05 = int.Parse(Console.ReadLine());

            eficiencia = (valor01+valor02+valor03+valor04+valor05) / 5;

            Console.WriteLine("A eficiencia dos alunos sao: {0:N} ", eficiencia);


           
        }
    }
}
