using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Artista
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DtNascimento { get; set; }
        public string Pais { get; set; }
        public byte[] ImgArtista { get; set; }
        public string NomePersonagem { get; set; }

        public ICollection<Filme> ListFilme { get; set; }
    }
}
