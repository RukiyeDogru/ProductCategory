
using P.C.Inftra.Core.DataAccess.EntityFramework;
using P.C.Inftra.DataAccess.Concrete.EntityFramework.Context;
using P.C.Inftra.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace P.C.Inftra.Core.Concrete
{
    public class EfUserDal : EfEntityRepositoryBase<User, ModelContext>, IUserDal
    {
    }
}
