using ProjetoBlogDDD.Dominio.Entidades;
using System.Data.Entity;

namespace ProjetoBlogDDD.Infra.Data.Contexto
{
    public class ProjetoModeloContexto : DbContext
    {
        public ProjetoModeloContexto()
            :base("ProjetoModeloDDD")
        {
           
        }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
