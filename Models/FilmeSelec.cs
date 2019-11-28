using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class FilmeSelec
    {
        public int IdFilme { get; set; }
        public string Titulo { get; set; }
        public int Ano { get; set; }
        public string Diretor { get; set; }
        public string Descricao { get; set; }
        public byte[] ImgFilme { get; set; }
        public string Genero { get; set; }
        public string Ator { get; set; }
        public string Personagem { get; set; }
    }
}
