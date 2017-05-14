using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateDemo.Services.Impl
{
    /// <summary>
    /// Album服务实现
    /// 2017/05/14 fhr 暂时不写
    /// </summary>
    public class AlbumService:IAlbumService
    {
        public Models.Album FindOne(object id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Models.Album> FindAll()
        {
            throw new NotImplementedException();
        }

        public object Save(Models.Album obj)
        {
            throw new NotImplementedException();
        }

        public void Update(Models.Album obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(Models.Album obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(object id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Models.Album> FindByHQL(string hql, params object[] paramArry)
        {
            throw new NotImplementedException();
        }

        public int DeleteByHQL(string hql)
        {
            throw new NotImplementedException();
        }

        public Models.Album LoadOne(object id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Models.Album> FindByTitle(string value)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Models.Album> FindByPrice(decimal value)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Models.Album> FindByAlbumArtUrl(string value)
        {
            throw new NotImplementedException();
        }
    }
}
