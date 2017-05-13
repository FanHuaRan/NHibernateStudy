using NHibernateDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateDemo.Repositorys
{
    public interface IArtistRepository:IRepository<Artist>
    {
        IEnumerable<Artist> FindByName(string name);
    }
}
