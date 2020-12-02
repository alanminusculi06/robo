using System;
using System.Linq;

namespace Robo.Models
{
    public abstract class MembroRotacao : Membro
    {
        protected readonly int[] OpcoesRotacao;

        protected MembroRotacao(int[] opcoesPosicao, int[] opcoesRotacao)
            : base(opcoesPosicao)
        {
            OpcoesRotacao = opcoesRotacao;
        }

        public int Rotacao { get; protected set; }

        public virtual void SetarRotacao(int rotacao)
        {
            if (!OpcoesRotacao.Contains(rotacao)) return;
            var index = Array.IndexOf(OpcoesRotacao, rotacao);
            var indexAtual = Array.IndexOf(OpcoesRotacao, Rotacao);
            if (index + 1 != indexAtual && index - 1 != indexAtual) return;
            Rotacao = OpcoesRotacao[index];
        }
    }
}