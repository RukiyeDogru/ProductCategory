using P.C.Inftra.Core.Abstract;
using P.C.Inftra.Core.DataAccess.EntityFramework;
using P.C.Inftra.DataAccess.Concrete.EntityFramework.Context;
using P.C.Inftra.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace P.C.Inftra.Core.Concrete
{
    public class EfProductDal : EfEntityRepositoryBase<Product, ModelContext>, IProductDal
    {
    }
}
