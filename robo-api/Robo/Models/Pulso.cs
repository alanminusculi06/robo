namespace Robo.Models
{
    public class Pulso : Membro
    {
        public static int NoventaGrausNegativo = 1;
        public static int QuarentaECincoGrausNegativo = 2;
        public static int EmRepouso = 3;
        public static int QuarentaECincoGraus = 4;
        public static int NoventaGraus = 5;
        public static int CentoETrintaECincoGraus = 6;
        public static int CentoEOitentaGraus = 7;

        private Pulso()
            : base(new[] { NoventaGrausNegativo, QuarentaECincoGrausNegativo, EmRepouso, QuarentaECincoGraus, NoventaGraus, CentoETrintaECincoGraus, CentoEOitentaGraus })
        {
            Posicao = EmRepouso;
        }

        public static Pulso Criar() => new Pulso();

    }
}