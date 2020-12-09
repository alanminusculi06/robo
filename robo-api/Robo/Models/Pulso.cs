using Robo.Infraestrutura.Enums.Bracos;

namespace Robo.Models
{
    public class Pulso : Membro
    {
        private Pulso()
            : base(new[] {
                (int)PulsoRotacao.NoventaGrausNegativo,
                (int)PulsoRotacao.QuarentaECincoGrausNegativo,
                (int)PulsoRotacao.EmRepouso,
                (int)PulsoRotacao.QuarentaECincoGraus,
                (int)PulsoRotacao.NoventaGraus,
                (int)PulsoRotacao.CentoETrintaECincoGraus,
                (int)PulsoRotacao.CentoEOitentaGraus }
            )
        {
            Posicao = (int)PulsoRotacao.EmRepouso;
        }

        public static Pulso Criar() => new Pulso();

        public void SetarPosicao(PulsoRotacao rotacao) => SetarPosicao((int)rotacao);
    }
}