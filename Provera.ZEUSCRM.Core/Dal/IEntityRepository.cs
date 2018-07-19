using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;

namespace Provera.ZEUSCRM.Core.Dal
{
    #region Info
    //T, reference type (genel olarak class) olacak.
    //IEntity'den implemente edilmiş olmalı, yani 
    //buraya sadece veritabanı nesnesi yazılabilir.
    //new=newlenebilir (abstract ve interface) dışındaki
    //classları yazabiliriz. 
    #endregion
    public interface IEntityRepository<T> where T:class,new()
    {
        T Get(Expression<Func<T,bool>> filter=null);
        List<T> GetList(Expression<Func<T, bool>> filter = null);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
