using System;
using tabuleiro;
using xadrez;

namespace Xadrez
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Posicao P;

            //P = new Posicao(3, 4);

            //Console.WriteLine("Posição: " + P);

            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 9));
                tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 2));

                Tela.imprimirTabuleiro(tab);
            }
            catch(TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}