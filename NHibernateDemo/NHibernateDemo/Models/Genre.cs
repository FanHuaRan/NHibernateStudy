using System;
using System.Collections.Generic;

namespace NHibernateDemo.Models
{
    /// <summary>
    /// Genreʵ�壺����ӳ���ֶα���Ϊvirtual
    /// 2017/05/13 fhr
    /// </summary>
    public  class Genre
    {
        public virtual int GenreId { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
    }
}
