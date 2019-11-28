using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Mensagem
    {
        public int Id_Mensagem { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Tx_Mensagem { get; set; }
        public DateTime Dt_Mensagem { get; set; }
    }
}
