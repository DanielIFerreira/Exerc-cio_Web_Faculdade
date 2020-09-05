using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Noticia
    {
        public int Codigo { get; set; }
        public string Titulo { get; set; }
        public DateTime DataPublicacao { get; set; }
        public string Texto { get; set; }
    }
}
