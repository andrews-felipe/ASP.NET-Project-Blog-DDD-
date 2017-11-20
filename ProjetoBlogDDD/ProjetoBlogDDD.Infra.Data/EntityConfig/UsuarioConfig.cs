
using ProjetoBlogDDD.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoBlogDDD.Infra.Data.EntityConfig
{
    public class UsuarioConfig : EntityTypeConfiguration<Usuario>
    {

        public UsuarioConfig()
        {
            HasKey(u => u.usuarioID);

            Property(u => u.Nome)
                .IsRequired()
                .HasMaxLength(150);

            Property(u => u.Email)
                .IsRequired();
                
                

        }
    }
}
