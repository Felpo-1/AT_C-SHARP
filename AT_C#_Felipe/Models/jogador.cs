using System.ComponentModel.DataAnnotations;

namespace AT_C__Felipe.Models
{
    public class jogador
    {   [Required(ErrorMessage = "Insira o ID")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Insira o nome")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Insira a gamertag")]
        public string gamertag { get; set; }
       
        [Required(ErrorMessage = "Insira o level")]
        public int level { get; set; }

    }
}
