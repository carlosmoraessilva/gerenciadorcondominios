using System;
using System.Collections.Generic;
using System.Text;

namespace Gerenciador_Condominios.BLL.Models
{
    public class Servico
    {
        public int ServicoId { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public StatusServico Status { get; set; }
        public string  UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public ICollection<ServicoPredio> ServicosPredios { get; set; }
    }
    
    public enum StatusServico
    {
        Pendente, Recusado, Aceito
    }
}
