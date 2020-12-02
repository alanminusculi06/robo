using System.ComponentModel.DataAnnotations;

namespace RoboClient.Models.Robos
{
    public class Cotovelo
    {
        [Key] public string Id { get; set; }
        public int Posicao { get; set; }
    }
}