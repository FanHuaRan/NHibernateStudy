using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateDemo.Respositorys
{
    /// <summary>
    /// 仓库泛型接口
    /// 2017/05/13 fhr
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepository<T> where T:class
    {
        T FindOne(object id);

        IEnumerable<T> FindAll();

        object Save(T obj);

        void Update(T obj);

        void Delete(T obj);

        void Delete(object id);

        IEnumerable<T> FindByProperty(string propertyName, object value);
    }
}
