using NHibernateDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateDemo.Repositorys.Impl
{
    public class ArtistRepository : BaseRepository<Artist>, IArtistRepository
    {
        public static readonly String NAME = "name";


            public IEnumerable<Artist> FindByName(string name)
            {
                throw new NotImplementedException();
            }
    }
}
