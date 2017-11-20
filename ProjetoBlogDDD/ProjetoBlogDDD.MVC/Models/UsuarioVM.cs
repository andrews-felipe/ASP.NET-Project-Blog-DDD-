using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoBlogDDD.MVC.Models
{
    public class UsuarioVM
    {   

        [Key]

        public int usuarioID { get; set; }

        [Required(ErrorMessage ="Prencha Campo Nome")]
        [MaxLength(150, ErrorMessage = "Limite Máximo Excedido")]
        [MinLength(2, ErrorMessage ="Digite O Minimo de Caracteres")]

        public string Nome { get; set; }

        [Required(ErrorMessage = "Prencha Campo Nome")]
        [MaxLength(150, ErrorMessage = "Limite Máximo Excedido")]
        [EmailAddress(ErrorMessage = "Preencha um Email Válido")]
        [DisplayName("E-mail")]

        public string Email { get; set; }

        public DateTime DataCadastro { get; set; }

        public virtual IEnumerable<PostVM> Postagens { get; set; }
    }
}