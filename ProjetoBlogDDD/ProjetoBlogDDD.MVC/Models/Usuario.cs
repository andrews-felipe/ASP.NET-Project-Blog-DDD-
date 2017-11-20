using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoBlogDDD.MVC.Models
{
    public class Usuario
    {   

        [Key]

        public int usuarioID { get; set; }

        [Required(ErrorMessage ="Prencha Campo Nome")]
        [MaxLength(150, ErrorMessage = "Limite Máximo Excedido")]
        [MinLength(2, ErrorMessage ="Digite O Minimo de Caracteres")]

        public string Nome { get; set; }

        [Required(ErrorMessage = "Prencha Campo Nome")]
        [MaxLength(150, ErrorMessage = "Limite Máximo Excedido")]
        [MinLength(2, ErrorMessage = "Digite O Minimo de Caracteres")]

        public string Email { get; set; }

        public DateTime DataCadastro { get; set; }

        //public virtual IEnumerable<Post> Postagens { get; set; }//
    }
}