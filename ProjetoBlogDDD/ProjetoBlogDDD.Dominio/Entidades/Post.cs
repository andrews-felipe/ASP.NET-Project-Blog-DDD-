using System;


namespace ProjetoBlogDDD.Dominio.Entidades
{
    public class Post
    {

        public int PostID { get; set; }

        public string Titulo { get; set; }

        public DateTime DataCadastro { get; set; }

        public string Texto { get; set; }

        public int UsuarioID { get; set; }

        public virtual Usuario Usuario { get; set; }

    }
}
