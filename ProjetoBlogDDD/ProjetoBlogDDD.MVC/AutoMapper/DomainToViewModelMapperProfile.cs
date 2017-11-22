using AutoMapper;
using ProjetoBlogDDD.Dominio.Entidades;
using ProjetoBlogDDD.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoBlogDDD.MVC.AutoMapper
{
    public class DomainToViewModelMapperProfile : Profile
    {

        public override string ProfileName
        {
            get { return "ViewModelToDomaininMappings";  }
        }

        /*protected override string Configure()
        {
            Mapper.Map<UsuarioVM, Usuario>();
            Mapper.Map<PostVM, Post>();
        }
        */


    }
}