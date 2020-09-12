using P.C.Inftra.Core.Utilities.Results;
using P.C.Inftra.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace P.C.Domain.Service
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll();
        IDataResult<List<Product>> CategoryId(int CategoryId);
        IResult Add(Product product);
        IDataResult<Product> Get(int Id);
        IResult Update(Product products);
        IResult Delete(int id);
        IResult DeleteReal(int id);
    }
}
