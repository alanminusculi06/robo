using Robo.Infraestrutura.Enums.Bracos;

namespace Robo.Models
{
    public class Braco
    {
        private Braco()
        {
            Cotovelo = Cotovelo.Criar();
            Pulso = Pulso.Criar();
        }

        public Cotovelo Cotovelo { get; set; }
        public Pulso Pulso { get; set; }

        public static Braco Criar() => new Braco();

        public void MovimentarPulso(PulsoRotacao rotacao)
        {
            if (Cotovelo.Posicao != (int)CotoveloPosicao.FortementeContraido) return;
            Pulso.SetarPosicao(rotacao);
        }

        public void MovimentarCotovelo(CotoveloPosicao posicao) => Cotovelo.SetarPosicao(posicao);
    }
}