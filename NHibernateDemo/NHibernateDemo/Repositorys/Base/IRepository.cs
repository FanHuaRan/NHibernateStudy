using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateDemo.Repositorys
{
    /// <summary>
    /// 仓库泛型接口 这儿的接口最好屏蔽数据访问框架 
    /// 写通用接口方法
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
