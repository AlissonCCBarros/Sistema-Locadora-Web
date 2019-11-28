using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Filme
    {
        public int Id { get; set; }
        public string Cod_Barras { get; set; }
        public string Titulo { get; set; }
        public int Ano { get; set; }
        public string Tipo { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataAquisicao { get; set; }
        public decimal ValorCusto { get; set; }
        public bool Locado { get; set; }
        public string Diretor { get; set; }
        public string Descricao { get; set; }
        public byte[] ImgCapa { get; set; }

        public string NmPersonagem { get; set; }
        public ICollection<Genero> ListGenero { get; set; }
        public ICollection<Artista> ListArtista { get; set; }
    
    }
}
