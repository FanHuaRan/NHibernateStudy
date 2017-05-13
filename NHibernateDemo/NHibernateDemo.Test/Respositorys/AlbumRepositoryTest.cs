using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NHibernateDemo.Repositorys;
using NHibernateDemo.Repositorys.Impl;
using System.Linq;
namespace NHibernateDemo.Test.Respositorys
{
    [TestClass]
    public class AlbumRepositoryTest
    {
        private static IAlbumRepository _albumRepository = null;
        // 在运行类中的第一个测试之前使用 ClassInitialize 运行代码
        [ClassInitialize()]
        public static void MyClassInitialize(TestContext testContext)
        {
            _albumRepository = new AlbumRepository();
        }
        [TestMethod]
        public void TestFindOne()
        {
           var album=_albumRepository.FindOne(102);
           Assert.IsNotNull(album);
        }
        [TestMethod]
        public void TestFindAll()
        {
            var albums = _albumRepository.FindAll();
            Assert.IsNotNull(albums);
            Assert.IsTrue(albums.Count()>100);
        }
        [TestMethod]
        public void TestSave()
        {

        }
        [TestMethod]
        public void TestUpdate()
        {

        }
        [TestMethod]
        public void TestDeleteObject()
        {

        }
        [TestMethod]

        public void TestDeleteById()
        {

        }
        [TestMethod]

        public void TestFindByProperty()
        {

        }
        [TestMethod]
        public void TestFindByHQL()
        {

        }

        [TestMethod]
        public void TestDeleteByHQL()
        {

        }

        [TestMethod]
        public void TestLoadOne()
        {

        }

        // 在类中的所有测试都已运行之后使用 ClassCleanup 运行代码
        [ClassCleanup()]
        public static void MyClassCleanup() { }
    }
}
