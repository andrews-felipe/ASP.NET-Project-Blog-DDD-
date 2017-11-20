using ProjetoBlogDDD.Dominio.Entidades;
using ProjetoBlogDDD.Infra.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBlogDDD.Dominio.Interfaces
{
    public interface IPostRepository : IRepositoryBase<Post>
    {
        IEnumerable<Post> BuscarPorID(int ID);
    }
}
