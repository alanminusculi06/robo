using System.ComponentModel.DataAnnotations;

namespace RoboClient.Models.Robos
{
    public class Cabeca
    {
        [Key] public string Id { get; set; }
        public int Posicao { get; set; }
        public int Rotacao { get; set; }
    }
}