using NHibernate;
using NHibernate.Linq;
using NHibernateDemo.Hibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateDemo.Respositorys
{
    public class BaseRepository<T>:IBaseHibernateDAO<T>,IRepository<T> where T:class
    {
        private static  string entityName=null;
        public BaseRepository()
        {
            var type = typeof(T);
            entityName=type.Name;
        }
        public T FindOne(object id)
        {
            using (var session = GetSession())
            {
                return session.Load<T>(id);
            }
        }
        public T LoadOne(object id)
        {
            using (var session = GetSession())
            {
                try
                {
                    return session.Load<T>(id);
                }
                catch (Exception e)
                {
                    return null;
                }
            }
        }

        public IEnumerable<T> FindAll()
        {
            using (var session = GetSession())
            {
                return session.Query<T>().AsEnumerable<T>();
            }
        }

        public object Save(T obj)
        {
            using (var session = GetSession())
            {
                var transaction=session.BeginTransaction();
                var id=session.Save(obj);
                transaction.Commit();
                return id;
            }
        }

        public void Update(T obj)
        {
            using (var session = GetSession())
            {
                var transaction = session.BeginTransaction();
                session.Update(obj);
                transaction.Commit();
            }
        }

        public void Delete(T obj)
        {
            using (var session = GetSession())
            {
                var transaction = session.BeginTransaction();
                session.Delete(obj);
                transaction.Commit();
            }
        }

        public void Delete(object id)
        {
            using (var session = GetSession())
            {
                var obj = FindOne(id);
                if (obj != null)
                {
                    var transaction = session.BeginTransaction();
                    session.Delete(obj);
                    transaction.Commit();
                }
            }
        }

        public IEnumerable<T> FindByHQL(string hql, params object[] paramArry)
        {
            using (var session = GetSession())
            {
              var query= session.CreateQuery(hql);
              for (int i = 0; i < paramArry.Length; i++)
              {
                  query.SetParameter(i, paramArry[i]);
              }
              return query.Enumerable<T>();
            }
        }

        public IEnumerable<T> FindByProperty(string propertyName, object value)
        {
            using (var session = GetSession())
            {
                var query = session.CreateQuery(string.Format("from {0} as model where model.{1} =?", entityName, propertyName));
                query.SetParameter(0, value);
                return query.Enumerable<T>();
            }
        }
        public int DeleteByHQL(string hql)
        {
            using (var session = GetSession())
            {
                var transaction = session.BeginTransaction();
                var count=session.Delete(hql);
                transaction.Commit();
                return count;
            }
        }

        public ISession GetSession()
        {
             return HibernateSessionFactory.GetSession(); 
        }

    }
}
