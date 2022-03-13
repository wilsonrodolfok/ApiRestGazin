using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
