using NHibernateDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateDemo.Respositorys
{
    public interface IGenreRepository : IRepository<Genre>
    {
        IEnumerable<Genre> FindByName(string name);

        IEnumerable<Genre> FindByDescription(string description);
    }
}
