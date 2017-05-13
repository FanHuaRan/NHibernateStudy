using NHibernateDemo.Hibernate;
using NHibernateDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var session=HibernateSessionFactory.GetSession();
            var albums=session.Load<Album>(121);  
        }
    }
}
