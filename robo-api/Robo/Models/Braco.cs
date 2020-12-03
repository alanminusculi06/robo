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