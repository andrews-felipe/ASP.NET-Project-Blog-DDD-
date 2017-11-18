

using System;

namespace ProjetoBlogDDD.Dominio.Entidades
{
    public class Usuario
    {

        public int usuarioID { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public DateTime DataCadastro { get; set; }

    }
}
