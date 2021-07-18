using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Aula4.Models {
    public class User {
        [Required(ErrorMessage = "Campo não pode estar vazio")]
        [Range(0, int.MaxValue, ErrorMessage = "Número deve ser positivo.")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo não pode estar vazio")]
        public String Nome { get; set; }

        [Required(ErrorMessage = "Campo não pode estar vazio")]
        public String Email { get; set; }
    }
}
