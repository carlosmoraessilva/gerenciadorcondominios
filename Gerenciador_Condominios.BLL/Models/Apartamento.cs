using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Gerenciador_Condominios.BLL.Models
{
    public class Apartamento
    {
        public int ApartamentoId { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Range(0, 1000, ErrorMessage = "valor inválido")]
        [Display(Name = "Número")]
        public int Numero { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Range(0, 10, ErrorMessage = "valor inválido")]
        public int Andar { get; set; }
        public string Foto { get; set; }
        public string MoradorId { get; set; }
        public virtual Usuario Morador { get; set; }
        public string ProprietarioId { get; set; }
        public virtual Usuario Proprietario { get; set; }

    }
}
