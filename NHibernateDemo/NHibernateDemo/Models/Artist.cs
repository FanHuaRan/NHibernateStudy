using System;
using System.Collections.Generic;

namespace NHibernateDemo.Models
{
    /// <summary>
    /// Artsit实体：所有映射字段必须为virtual
    /// 2017/05/13 fhr
    /// </summary>
    public  class Artist
    {
        public virtual int ArtistId { get; set; }
        public virtual string Name { get; set; }
    }
}
