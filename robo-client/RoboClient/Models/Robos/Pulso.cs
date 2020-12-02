using System.ComponentModel.DataAnnotations;

namespace RoboClient.Models.Robos
{
    public class Pulso
    {
        [Key] public string Id { get; set; }
        public int Posicao { get; set; }
    }
}