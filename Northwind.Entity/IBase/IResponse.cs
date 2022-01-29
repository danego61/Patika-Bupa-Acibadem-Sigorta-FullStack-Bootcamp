using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Entity.IBase
{
    public interface IResponse : IResponse<object>
    {
    }

    public interface IResponse<T>
    {
    }
}
