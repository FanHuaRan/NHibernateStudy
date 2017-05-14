using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NHibernateDemo.Repositorys;
using NHibernateDemo.Repositorys.Impl;
using System.Linq;
using NHibernateDemo.Models;
namespace NHibernateDemo.Test.Respositorys
{
    /// <summary>
    /// AlbumRepository单元测试
    /// 2017/05/14 
    /// </summary>
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
            var album = _albumRepository.FindOne(102);
            Assert.IsNotNull(album);
        }
        [TestMethod]
        public void TestFindAll()
        {
            var albums = _albumRepository.FindAll();
            Assert.IsNotNull(albums);
            Assert.IsTrue(albums.Count() > 100);
        }
        [TestMethod]
        public void TestSave()
        {
            var album = new Album()
            {
                ArtistId = 1,
                GenreId = 1,
                Title = "My Song",
                Price = 6m,
                AlbumArtUrl = null
            };
            var id = _albumRepository.Save(album);
            Assert.IsNotNull(_albumRepository.FindOne(id));
        }
        [TestMethod]
        public void TestUpdate()
        {
            var album = _albumRepository.FindOne(158);
            album.Title = "justme";
            _albumRepository.Update(album);
            Assert.AreEqual("justme", _albumRepository.FindOne(album.AlbumId).Title);
        }
        [TestMethod]
        public void TestDeleteObject()
        {
            var album = _albumRepository.FindOne(165);
            _albumRepository.Delete(album);
            Assert.IsNull(_albumRepository.FindOne(album.AlbumId));
        }
        [TestMethod]

        public void TestDeleteById()
        {
            _albumRepository.Delete(161);
            Assert.IsNull(_albumRepository.FindOne(161));
        }
        [TestMethod]

        public void TestFindByProperty()
        {
            var albums = _albumRepository.FindByProperty("Price", 8.99m);
            Assert.IsNotNull(albums);
            Assert.IsTrue(albums.Count() > 10);
        }
        [TestMethod]
        public void TestFindByHQL()
        {
            var hql = "from Album album where album.AlbumId=?";
            var albums = _albumRepository.FindByHQL(hql, 121);
            Assert.IsNotNull(albums);
            Assert.IsTrue(albums.Count() == 1);
        }

        [TestMethod]
        public void TestDeleteByHQL()
        {
            var hql = "from Album album where album.AlbumId=131";
            Assert.AreEqual(1, _albumRepository.DeleteByHQL(hql));
        }

        [TestMethod]
        public void TestLoadOne()
        {
            var album = _albumRepository.LoadOne(102);
            Assert.IsNotNull(album);
        }
        [TestMethod]
        public void FindByTitle()
        {
            var albums = _albumRepository.FindByProperty("Title", "the Best Of Men At Work");
            Assert.IsNotNull(albums);
            Assert.IsTrue(albums.Count() == 1);
        }
        [TestMethod]
        public void FindByPrice(decimal value)
        {
            var albums = _albumRepository.FindByProperty("Price", 8.99m);
            Assert.IsNotNull(albums);
            Assert.IsTrue(albums.Count() > 10);
        }
        [TestMethod]
        public void FindByAlbumArtUrl()
        {
            var albums = _albumRepository.FindByProperty("AlbumArtUrl", "/Content/Images/placeholder.gif");
            Assert.IsNotNull(albums);
            Assert.IsTrue(albums.Count() > 10);
        }

        // 在类中的所有测试都已运行之后使用 ClassCleanup 运行代码
        [ClassCleanup()]
        public static void MyClassCleanup() { }
    }
}
