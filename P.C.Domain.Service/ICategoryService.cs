using P.C.Inftra.Core.Utilities.Results;
using P.C.Inftra.Entities.Concrete;
using System.Collections.Generic;

namespace P.C.Domain.Service
{
    public interface ICategoryService
    {
        IDataResult<List<Category>> GetAll();
        IResult Add();
        IDataResult<Category> Get(int Id);
        IResult Update(Category categories);
        IResult Delete(int id);
        IResult DeleteReal(int id);

    }
}
