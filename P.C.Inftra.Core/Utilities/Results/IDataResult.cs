using System;
using System.Collections.Generic;
using System.Text;

namespace P.C.Inftra.Core.Utilities.Results
{
    public interface IDataResult<out T> : IResult
    {
        T Data { get; }
    }
}
