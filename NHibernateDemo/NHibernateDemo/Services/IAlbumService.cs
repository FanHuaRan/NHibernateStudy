using NHibernateDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateDemo.Services
{
    public interface IAlbumService
    {
        Album FindOne(object id);

        IEnumerable<Album> FindAll();

        object Save(Album obj);

        void Update(Album obj);

        void Delete(Album obj);

        void Delete(object id);
        IEnumerable<Album> FindByHQL(string hql, params object[] paramArry);

        int DeleteByHQL(string hql);

        Album LoadOne(object id);
        IEnumerable<Album> FindByTitle(string value);

        IEnumerable<Album> FindByPrice(decimal value);

        IEnumerable<Album> FindByAlbumArtUrl(string value);
    }
}
