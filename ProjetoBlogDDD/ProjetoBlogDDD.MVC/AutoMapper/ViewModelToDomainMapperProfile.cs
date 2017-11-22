using AutoMapper;
using ProjetoBlogDDD.Dominio.Entidades;
using ProjetoBlogDDD.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoBlogDDD.MVC.AutoMapper
{
    public class ViewModelToDomainMapperProfile : Profile
    {

        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }


        /*protected override string Configure()
        {
            Mapper.Map<Usuario, UsuarioVM>();
            Mapper.Map<Post, PostVM>();
        }
        */
    }
}