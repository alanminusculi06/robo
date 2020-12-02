namespace Robo.Models
{
    public class Cabeca : MembroRotacao
    {
        public static int ParaCima = 1;
        public static int EmRepouco = 2;
        public static int ParaBaixo = 3;

        public static int RotacaoNoventaGrausNegativo = 1;
        public static int RotacaoQuarentaECincoGrausNegativo = 2;
        public static int RotacaoEmRepouso = 3;
        public static int RotacaoQuarentaECincoGraus = 4;
        public static int RotacaoNoventaGraus = 5;

        public Cabeca()
            : base(new[] { ParaCima, EmRepouco, ParaBaixo },
                new[]
                {
                    RotacaoNoventaGrausNegativo, RotacaoQuarentaECincoGrausNegativo, RotacaoEmRepouso,
                    RotacaoQuarentaECincoGraus, RotacaoNoventaGraus
                })
        {
            Posicao = EmRepouco;
            Rotacao = RotacaoEmRepouso;
        }

        public static Cabeca Criar() => new Cabeca();        

        public override void SetarRotacao(int rotacao)
        {
            if (Posicao == ParaBaixo) return;
            base.SetarRotacao(rotacao);
        }
    }
}