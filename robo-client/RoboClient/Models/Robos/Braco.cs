using System.ComponentModel.DataAnnotations;

namespace RoboClient.Models.Robos
{
    public class Braco
    {
        [Key] public string Id { get; set; }
        public Pulso Pulso { get; set; }
        public Cotovelo Cotovelo { get; set; }
    }
}