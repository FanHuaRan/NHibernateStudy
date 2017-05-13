using System;
using System.Collections.Generic;

namespace NHibernateDemo.Models
{
    /// <summary>
    /// Albumʵ�壺����ӳ���ֶα���Ϊvirtual
    /// 2017/05/13 fhr
    /// </summary>
    public  class Album
    {
        public virtual int AlbumId { get; set; }
        public virtual int GenreId { get; set; }
        public virtual int ArtistId { get; set; }
        public virtual string Title { get; set; }
        public virtual decimal Price { get; set; }
        public virtual string AlbumArtUrl { get; set; }
        public virtual Artist Artist { get; set; }
        public virtual Genre Genre { get; set; }
        
    }
}
