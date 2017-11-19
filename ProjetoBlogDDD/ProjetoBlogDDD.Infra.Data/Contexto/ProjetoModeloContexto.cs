using ProjetoBlogDDD.Dominio.Entidades;
using System.Data.Entity;

namespace ProjetoBlogDDD.Infra.Data.Contexto
{
    public class ProjetoModeloContexto : DbContext
    {
        public ProjetoModeloContexto()
            :base("ProjetoBlogDDD")
        {
           
        }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
