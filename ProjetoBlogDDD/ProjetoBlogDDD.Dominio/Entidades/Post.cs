using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBlogDDD.Dominio.Entidades
{
    public class Post
    {

        public int PostID { get; set; }

        public string Titulo { get; set; }

        public DateTime DataCadastro { get; set; }

        public string Texto { get; set; }

    }
}
