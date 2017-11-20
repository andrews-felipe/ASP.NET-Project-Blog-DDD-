using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoBlogDDD.MVC.Models
{
    public class PostVM
    {
        [Key]
        public int PostID { get; set; }

        [Required(ErrorMessage = "Prencha Campo Titulo")]
        [MaxLength(150, ErrorMessage = "Limite Máximo [150 Caracteres]")]
        [MinLength(2, ErrorMessage = "Digite O Minimo  [ 2 Caracteres]")]

        public string Titulo { get; set; }

        public DateTime DataCadastro { get; set; }

        [Required(ErrorMessage = "Prencha Campo Titulo")]
        [MaxLength(1200, ErrorMessage = "Limite Máximo [1200 Caracteres]")]
        [MinLength(2, ErrorMessage = "Digite O Minimo  [2 Caracteres]")]

        public string Texto { get; set; }

        public int UsuarioID { get; set; }

        public virtual UsuarioVM Usuario { get; set; }    ///

    }
}