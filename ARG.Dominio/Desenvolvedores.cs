using System;
using System.ComponentModel.DataAnnotations;

namespace ARG.Dominio
{
    public class Desenvolvedores
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Necessário preenchimento do campo {0} !")]
        public int Nivel { get; set; }

        [Required(ErrorMessage = "Campo {0} de preenchimento obrigatório!")]
        public string Nome { get; set; }
        
        public string Sexo { get; set; }
        public DateTime DataNascimento { get; set; }
        public int Idade { get; set; }
        public string Hobby { get; set; }




    }
}
