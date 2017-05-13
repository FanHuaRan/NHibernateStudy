using NHibernateDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateDemo.Repositorys
{
    public interface IAlbumRepository:IRepository<Album>
    {
        IEnumerable<Album> FindByTitle(string value);

        IEnumerable<Album> FindByPrice(decimal value);

        IEnumerable<Album> FindByAlbumArtUrl(string value);
    }
}
