using System;
using System.Collections.Generic;

namespace NHibernateDemo.Models
{
    /// <summary>
    /// Artsitʵ�壺����ӳ���ֶα���Ϊvirtual
    /// 2017/05/13 fhr
    /// </summary>
    public  class Artist
    {
        public virtual int ArtistId { get; set; }
        public virtual string Name { get; set; }
    }
}
