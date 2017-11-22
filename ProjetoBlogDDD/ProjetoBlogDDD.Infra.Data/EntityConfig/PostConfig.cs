using ProjetoBlogDDD.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;


namespace ProjetoBlogDDD.Infra.Data.EntityConfig
{
    public class PostConfig : EntityTypeConfiguration<Post>
    {

        public PostConfig()
        {
            HasKey(p => p.PostID);

            Property(p => p.Titulo)
                .IsRequired()
                .HasMaxLength(250);

            Property(p => p.Texto)
                .IsRequired()
                .HasMaxLength(1200);

            HasRequired(p => p.Usuario)
                .WithMany()
                .HasForeignKey(p => p.UsuarioID);

        }
    }
}
