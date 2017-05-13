using System;
using System.Collections.Generic;

namespace NHibernateDemo.Models
{
    /// <summary>
    /// Genre实体：所有映射字段必须为virtual
    /// 2017/05/13 fhr
    /// </summary>
    public  class Genre
    {
        public virtual int GenreId { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
    }
}
