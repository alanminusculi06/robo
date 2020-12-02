namespace Robo.Models
{
    public class Cotovelo : Membro
    {
        public static int EmRepouso = 1;
        public static int LevementeContraido = 2;
        public static int Contraido = 3;
        public static int FortementeContraido = 4;

        private Cotovelo()
            : base(new[] { EmRepouso, LevementeContraido, Contraido, FortementeContraido })
        {
            Posicao = EmRepouso;
        }

        public static Cotovelo Criar() => new Cotovelo();
    }
}