using System;

namespace md02_CadernoExercicios_01
{
    class Program
    {
        static void Main(string[] args)
        /*
          1. O sistema de avaliação de determinada disciplina, é composto por três
            provas. A primeira prova tem peso 2, a segunda tem peso 3 e a terceira tem
            peso 5. Faça um algoritmo para calcular a média final de um aluno desta
            disciplina.
        */
        {
            double p2=2, p3=3, p5=5, nt1, nt2, nt3, mp;
            

            Console.WriteLine("Digite a Nota da primeira Prova:");
            nt1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nDigite a Nota da segunda Prova:");
            nt2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nDigite a Nota da terceira Prova:");
            nt3 = Convert.ToDouble(Console.ReadLine());

            mp = ((nt1 * p2) + (nt2 * p3) + (nt3 * p5))/(p2 + p3 + p5);
            Console.WriteLine("\nA média final do aluno é: {0}", mp.ToString("0.00"));

        }
    }
}
