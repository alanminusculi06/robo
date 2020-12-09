using Robo.Infraestrutura.Enums.Bracos;

namespace Robo.Models
{
    public class Cotovelo : Membro
    {
        private Cotovelo()
            : base(new[] {
                (int)CotoveloPosicao.EmRepouso,
                (int)CotoveloPosicao.LevementeContraido,
                (int)CotoveloPosicao.Contraido,
                (int)CotoveloPosicao.FortementeContraido }
            )
        {
            Posicao = (int)CotoveloPosicao.EmRepouso;
        }

        public static Cotovelo Criar() => new Cotovelo();

        public void SetarPosicao(CotoveloPosicao posicao) => SetarPosicao((int)posicao);
    }
}