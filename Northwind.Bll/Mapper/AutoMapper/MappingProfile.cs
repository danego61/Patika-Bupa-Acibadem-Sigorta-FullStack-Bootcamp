using AutoMapper;
using Northwind.Bll.Helper;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Bll.Mapper.AutoMapper
{
    public class MappingProfile : Profile
    {

        public MappingProfile()
        {
            CreateMap<Customer, DtoCustomer>()
                .ReverseMap();
            CreateMap<Order, DtoOrder>()
                .ReverseMap();
            CreateMap<User, DtoUser>()
                .ReverseMap();
            CreateMap<User, DtoUserDetails>()
                .ReverseMap();
            CreateMap<DtoLogin, User>()
                .ForMember(x => x.Password, opt => opt.MapFrom(x => PasswordHelper.GetPasswordHashValue(x.Password)));
            CreateMap<DtoSignUpUser, User>()
                .BeforeMap((x,y) =>
                {
                    if (x.Password != x.RePassword)
                        throw new Exception("Passwords do not much!");
                })
                .ForMember(x => x.Password, opt => opt.MapFrom(x => PasswordHelper.GetPasswordHashValue(x.Password)));
            CreateMap<OrderDetail, DtoOrderDetail>()
                .ReverseMap();
            CreateMap<Employee, DtoEmployee>()
                .ReverseMap();
            CreateMap<Shipper, DtoShipper>()
                .ReverseMap();
            CreateMap<Product, DtoProduct>()
                .ReverseMap();
            CreateMap<Category, DtoCategory>()
                .ReverseMap();
            CreateMap<Supplier, DtoSupplier>()
                .ReverseMap();
            CreateMap<Region, DtoRegion>()
                .ReverseMap();
        }

    }
}
