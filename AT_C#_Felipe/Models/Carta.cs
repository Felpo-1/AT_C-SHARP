using System.ComponentModel.DataAnnotations;

namespace AT_C__Felipe.Models
{
    public class Carta
    {
        [Required(ErrorMessage = "Insira o ID")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Insira o nome")]
        public string nome { get; set; }
        [Required(ErrorMessage = "Insira a descrição")]
        public string descricao { get; set; }
        [Required(ErrorMessage = "Insira o tipo")]
        public string tipo { get; set; }
        [Required(ErrorMessage = "Insira o quantidade")]
        public int quantidade { get; set; }
        [Required(ErrorMessage = "Insira o artista")]
        public string artista { get; set; }
    }
}
