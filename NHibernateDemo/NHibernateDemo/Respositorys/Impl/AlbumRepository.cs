using NHibernateDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateDemo.Respositorys.Impl
{
    public class AlbumRepository : BaseRepository<Album>, IAlbumRepository
    {
        public static const String TITLE = "title";
        public static const String PRICE = "price";
        public static const String ALBUM_ART_URL = "albumArtUrl";

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
