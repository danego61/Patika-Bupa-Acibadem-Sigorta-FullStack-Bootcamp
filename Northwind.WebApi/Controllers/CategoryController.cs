using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Northwind.Entity.Models;
using Northwind.Entity.Dto;
using Northwind.Interface;
using Northwind.WebApi.Base;

namespace Northwind.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ApiBaseController<ICategoryService, Category, DtoCategory, int>
    {

        public CategoryController(ICategoryService service) : base(service)
        {
        }

    }
}
