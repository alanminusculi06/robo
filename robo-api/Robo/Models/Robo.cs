using System;

namespace Robo.Models
{
    public class Robo
    {
        private Robo()
        {
            Id = Guid.NewGuid().ToString();
            Cabeca = new Cabeca();
            BracoEsquerdo = Braco.Criar();
            BracoDireito = Braco.Criar();
        }

        public string Id { get; set; }
        public Cabeca Cabeca { get; set; }
        public Braco BracoEsquerdo { get; set; }
        public Braco BracoDireito { get; set; }

        public static Robo Criar() => new Robo();
    }
}
