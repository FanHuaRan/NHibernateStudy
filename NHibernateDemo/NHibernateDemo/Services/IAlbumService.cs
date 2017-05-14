using NHibernateDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateDemo.Services
{
    /// <summary>
    /// Album服务接口
    /// 这儿会调用仓库层 但同时会进行防御型编程、事务处理等
    /// 2017/05/14 fhr
    /// </summary>
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
