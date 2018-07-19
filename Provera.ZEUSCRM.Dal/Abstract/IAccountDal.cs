using Provera.ZEUSCRM.Core.Dal;
using Provera.ZEUSCRM.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Provera.ZEUSCRM.Dal.Concrete.EFCore;

namespace Provera.ZEUSCRM.Dal.Abstract
{
    public interface IAccountDal:IEntityRepository<Account>
    {
        //custom operations about product, not everywhere
    }
}
