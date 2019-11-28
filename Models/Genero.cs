using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Genero
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int IdFilme { get; set; }
        public int AnoFilme { get; set; }
        public string TituloFilme { get; set; }
        public byte[] ImgFilme { get; set; }
    }
}
