using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.terminada)
                {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);

                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();




                }

                Tela.imprimirTabuleiro(partida.tab);
            }
                     
            catch (TabuleiroException e)
            
            {
                Console.WriteLine(e.Message);
            }

    Console.ReadLine();
                        
        }
    }
}
