﻿namespace tabuleiro
{
    abstract class Peca
    {
        public Posicao posicao { get; set; }   
        public Cor cor { get; protected set; }
        public int qtdMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca(Tabuleiro tab, Cor cor)
        {
            this.posicao = null;
            this.cor = cor;
            this.qtdMovimentos = 0;
            this.tab = tab;
        }
        public void incrementarQtdMovimentos()
        {
            qtdMovimentos++;
        }
        public bool existeMovimentosPossiveis()
        {
            bool[,] mat = movimentoPossiveis();
            for (int i = 0; i < tab.linhas; i++)
            {
                for (int j = 0; j < tab.colunas; j++)
                {
                    if (mat[i, j] == true)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool podeMoverPara(Posicao pos)
        {
            return movimentoPossiveis()[pos.linha, pos.coluna];
        }
        public abstract bool[,] movimentoPossiveis();

    }
}
