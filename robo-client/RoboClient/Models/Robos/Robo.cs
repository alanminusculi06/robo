using System.ComponentModel.DataAnnotations;

namespace RoboClient.Models.Robos
{
    public class Robo
    {
        [Key] public string Id { get; set; }
        public Cabeca Cabeca { get; set; }
        public Braco BracoDireito { get; set; }
        public Braco BracoEsquerdo { get; set; }

        public int CabecaPosicao => Cabeca?.Posicao ?? 0;
        public int CabecaRotacao => Cabeca?.Rotacao ?? 0;
        public int PulsoDireitoPosicao => BracoDireito?.Pulso?.Posicao ?? 0;
        public int CotoveloDireitoPosicao => BracoDireito?.Cotovelo?.Posicao ?? 0;
        public int PulsoEsquerdoPosicao => BracoEsquerdo?.Pulso?.Posicao ?? 0;
        public int CotoveloEsquerdoPosicao => BracoEsquerdo?.Cotovelo?.Posicao ?? 0;
    }
}