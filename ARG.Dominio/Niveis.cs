using System.ComponentModel.DataAnnotations;

namespace ARG.Dominio
{
    public class Niveis
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo {0} Obrigatório!")]
        public string Nivel { get; set; }
    }
}
