using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HelpSMA.Models
{
    [Table("Help")]
    public class Reserva
    {
        [Key]
        public int ReservaId { get; set; }
        public string Item { get; set; }
        public string Data { get; set; }
        public string Horário { get; set; }
        public string Prioridade { get; set; }
        public string Responsável { get; set; }
        public int Ramal { get; set; }
        public string Mensagem { get; set; }
        public string Situação { get; set; }
        public string Seção { get; set; }
        public string Solicitante { get; set; }
        public string Status { get; set; }
    }
}
