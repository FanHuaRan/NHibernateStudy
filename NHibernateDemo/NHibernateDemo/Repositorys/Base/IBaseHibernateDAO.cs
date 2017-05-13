using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateDemo.Repositorys
{
    /// <summary>
    /// HibernateDAO接口
    /// 2017/05/13 fhr
    /// </summary>
    public interface IBaseHibernateDAO<T> where T:class
    {
        ISession GetSession();

        IEnumerable<T> FindByHQL(string hql, params object[] paramArry);

        int DeleteByHQL(string hql);

        T LoadOne(object id);
    }
}
