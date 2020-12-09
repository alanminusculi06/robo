using Robo.Infraestrutura.Enums.Cabecas;

namespace Robo.Models
{
    public class Cabeca : MembroRotacao
    {
        public Cabeca()
            : base(
                new[] {
                    (int)CabecaInclinacao.ParaCima,
                    (int)CabecaInclinacao.EmRepouso,
                    (int)CabecaInclinacao.ParaBaixo },
                new[] {
                    (int)CabecaRotacao.NoventaGrausNegativo,
                    (int)CabecaRotacao.QuarentaECincoGrausNegativo,
                    (int)CabecaRotacao.EmRepouso,
                    (int)CabecaRotacao.QuarentaECincoGraus,
                    (int)CabecaRotacao.NoventaGraus }
                )
        {
            Posicao = (int)CabecaInclinacao.EmRepouso;
            Rotacao = (int)CabecaRotacao.EmRepouso;
        }

        public static Cabeca Criar() => new Cabeca();

        public void SetarRotacao(CabecaRotacao rotacao)
        {
            if (Posicao == (int)CabecaInclinacao.ParaBaixo) return;
            SetarRotacao((int)rotacao);
        }

        public void SetarInclinacao(CabecaInclinacao inclinacao) => SetarPosicao((int)inclinacao);
    }
}