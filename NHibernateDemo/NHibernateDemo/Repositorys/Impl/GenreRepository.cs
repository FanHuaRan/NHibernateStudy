using NHibernateDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateDemo.Repositorys.Impl
{
   public class GenreRepository : BaseRepository<Genre>, IGenreRepository
    {
       public static readonly String NAME = "name";
        public static readonly String DESCRIPTION = "description";

        public IEnumerable<Genre> FindByName(string name)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Genre> FindByDescription(string description)
        {
            throw new NotImplementedException();
        }
    }
}
