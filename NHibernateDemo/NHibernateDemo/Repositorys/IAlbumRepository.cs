using NHibernateDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateDemo.Repositorys
{
    /// <summary>
    /// Album仓库接口，派生自通用仓库接口和Hibernate仓库接口
    /// 2017/05/14 fhr
    /// </summary>
    public interface IAlbumRepository:IRepository<Album>,IBaseHibernateDAO<Album>
    {
        IEnumerable<Album> FindByTitle(string value);

        IEnumerable<Album> FindByPrice(decimal value);

        IEnumerable<Album> FindByAlbumArtUrl(string value);
    }
}
