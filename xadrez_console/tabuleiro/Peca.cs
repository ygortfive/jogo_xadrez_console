namespace tabuleiro
{
    abstract class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int qteMovimentos { get; protected set; }
        public Tabuleiro Tab { get; protected set; }

        public Peca(Tabuleiro Tab, Cor cor)
        {
            this.Posicao = null;
            this.Cor = cor;            
            this.Tab = Tab;
            this.qteMovimentos = 0;
        }

        public void incrementarQteMovimentos()
        {
            qteMovimentos++;
        }

        public void decrementarQteMovimentos()
        {
            qteMovimentos--;
        }

        public bool existeMovimentosPossiveis()
        {
            bool[,] mat = movimentosPossiveis();
            for(int i=0; i<Tab.Linhas; i++)
            {
                for(int j=0; j<Tab.Linhas; j++)
                {
                    if (mat[i, j])
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public bool podeMoverPara(Posicao pos)
        {
            return movimentosPossiveis()[pos.Linha, pos.Coluna];
        }

        public abstract bool[,] movimentosPossiveis();
    }
}
