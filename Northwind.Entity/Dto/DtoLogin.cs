using Northwind.Entity.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Entity.Dto
{
    public class DtoLogin : DtoBase
    {
        [Required]
        public string UserCode { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
