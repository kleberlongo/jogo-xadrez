using System;
using tabuleiro;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
           // Posicao P;
           // P = new Posicao(8, 8);
            //Console.WriteLine(" POsição " + P);

           Tabuleiro tab = new Tabuleiro(8, 8);

           Tela.imprimirTabuleiro(tab);
                        
            Console.ReadLine();


        }
    }
}
