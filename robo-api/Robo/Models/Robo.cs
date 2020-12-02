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

        public string Id { get; }
        public Cabeca Cabeca { get; }
        public Braco BracoEsquerdo { get; }
        public Braco BracoDireito { get; }

        public static Robo Criar() => new Robo();
    }
}
