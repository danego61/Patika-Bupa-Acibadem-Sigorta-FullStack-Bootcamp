using Northwind.Bll.Base;
using Northwind.Dal.Abstract;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using Northwind.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Bll.Manager
{
    public class SupplierManager : BllBase<Supplier, DtoSupplier>, ISupplierService
    {

        public SupplierManager(IServiceProvider service) : base(service)
        {
            
        }

    }
}
