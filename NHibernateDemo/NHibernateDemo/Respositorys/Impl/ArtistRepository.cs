using NHibernateDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateDemo.Respositorys.Impl
{
    public class ArtistRepository : BaseRepository<Artist>, IArtistRepository
    {
        	public static const String NAME = "name";


            public IEnumerable<Artist> FindByName(string name)
            {
                throw new NotImplementedException();
            }
    }
}
