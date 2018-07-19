using System;
using System.Collections.Generic;
using System.Text;
using Provera.ZEUSCRM.Core.Dal.EFCore;
using Provera.ZEUSCRM.Dal.Abstract;
using Provera.ZEUSCRM.Entity.Concrete;

namespace Provera.ZEUSCRM.Dal.Concrete.EFCore
{
    public class EFCoreContactDal:EFCoreEntityRepositoryBase<Contact>,IContactDal
    {
    }
}
