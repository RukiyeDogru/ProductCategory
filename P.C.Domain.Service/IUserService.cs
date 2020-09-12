using P.C.Inftra.Core.Utilities.Results;
using P.C.Inftra.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace P.C.Domain.Service
{
    public interface IUserService
    {

        IDataResult<List<User>> GetAll();
        IDataResult<User> Add(User user);
        IDataResult<User> Get(int Id);
        IDataResult<User> GetByMail(string mail);
        IResult Update(User users);
        IResult Delete(int id);
        IResult DeleteReal(int id);


    }

}
