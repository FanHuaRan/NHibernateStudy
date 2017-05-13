using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NHibernateDemo.Hibernate;
using NHibernate;

namespace NHibernateDemo.Test.Hibernate
{
    [TestClass]
    public class HibernateSessionFactoryTest
    {
        [TestMethod]
        public void TestGetSession()
        {
           ISession session=HibernateSessionFactory.GetSession();
           HibernateSessionFactory.CloseSession();
           Assert.IsNotNull(session);
        }
       [TestMethod]
        public void TestCloseSession()
        {
            ISession session = HibernateSessionFactory.GetSession();
            Assert.IsNotNull(session);
            HibernateSessionFactory.CloseSession();
            Assert.IsFalse(session.IsOpen);
        }
    }
}
