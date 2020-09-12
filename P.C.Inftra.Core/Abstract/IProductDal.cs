using P.C.Inftra.Core.DataAccess;
using P.C.Inftra.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace P.C.Inftra.Core.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
    }
}
