using NHibernateDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateDemo.Respositorys.Impl
{
   public class GenreRepository : BaseRepository<Genre>, IGenreRepository
    {
        public static const String NAME = "name";
        public static const String DESCRIPTION = "description";

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
