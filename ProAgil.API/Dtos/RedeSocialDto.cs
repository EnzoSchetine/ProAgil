using System.ComponentModel.DataAnnotations;

namespace ProAgil.API.Dtos
{
    public class RedeSocialDto
    {
        [Required]
        public string Nome { get; set; }
        [Required]
        public string URL { get; set; }
    }
}