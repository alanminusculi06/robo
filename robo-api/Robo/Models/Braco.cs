namespace Robo.Models
{
    public class Braco
    {
        private Braco()
        {
            Cotovelo = Cotovelo.Criar();
            Pulso = Pulso.Criar();
        }

        public Cotovelo Cotovelo { get; }
        public Pulso Pulso { get; }

        public static Braco Criar() => new Braco();

        public Pulso GetPulso() => Pulso;
        public Cotovelo GetCotovelo() => Cotovelo;

        public void MovimentarPulso(int posicao)
        {
            if (Cotovelo.Posicao != Cotovelo.FortementeContraido) return;
            Pulso.SetarPosicao(posicao);
        }

        public void MovimentarCotovelo(int posicao)
        {
            Cotovelo.SetarPosicao(posicao);
        }
    }
}