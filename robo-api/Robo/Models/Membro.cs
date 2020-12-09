using System;
using System.Linq;

namespace Robo.Models
{
    public abstract class Membro
    {
        protected readonly int[] OpcoesPosicao;

        protected Membro(int[] opcoesPosicao)
        {
            OpcoesPosicao = opcoesPosicao;
        }

        public int Posicao { get; set; }

        protected void SetarPosicao(int posicao)
        {
            if (!OpcoesPosicao.Contains(posicao)) return;
            var index = Array.IndexOf(OpcoesPosicao, posicao);
            var indexAtual = Array.IndexOf(OpcoesPosicao, Posicao);
            if (index + 1 != indexAtual && index - 1 != indexAtual) return;
            Posicao = OpcoesPosicao[index];
        }
    }
}