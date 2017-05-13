using NHibernateDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateDemo.Repositorys.Impl
{
    public class AlbumRepository : BaseRepository<Album>, IAlbumRepository
    {
        public static readonly String TITLE = "title";
        public static readonly String PRICE = "price";
        public static readonly String ALBUM_ART_URL = "albumArtUrl";

        public IEnumerable<Album> FindByTitle(string value)
        {
            return FindByProperty(TITLE, value);
        }

        public IEnumerable<Album> FindByPrice(decimal value)
        {
            return FindByProperty(PRICE, value);
        }

        public IEnumerable<Album> FindByAlbumArtUrl(string value)
        {
            return FindByProperty(ALBUM_ART_URL, value);
        }
    }
}
