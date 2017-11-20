using ProjetoBlogDDD.Dominio.Entidades;
using ProjetoBlogDDD.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoBlogDDD.Infra.Data.Repositories
{
    public class PostRepository : RepositoryBase<Post>, IPostRepository
    {
        public IEnumerable<Post> BuscarPorID(int ID)
        {
            return Db.Postagens.Where(p => p.PostID == ID);
        }
    }
}
