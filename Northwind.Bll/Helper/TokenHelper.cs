using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Northwind.Entity.Dto;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Bll.Helper
{
    public class TokenHelper
    {

        private readonly IConfiguration configuration;

        public TokenHelper(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public string CreateAccessToken(DtoUserDetails user)
        {
            var claims = new[]
            {
                 new Claim(JwtRegisteredClaimNames.Sub, user.UserCode),
                 new Claim(JwtRegisteredClaimNames.Jti, user.UserID.ToString()),
                 new Claim(ClaimTypes.Role, "Admin")
            };

            var claimsIdentity = new ClaimsIdentity(claims, "Token");

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Tokens:Key"]));

            var cred = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken
                (
                 issuer: configuration["Tokens:Issuer"],
                 audience: configuration["Tokens:Issuer"],
                 expires: DateTime.Now.AddMinutes(60),
                 notBefore: DateTime.Now,
                 signingCredentials: cred,
                 claims: claimsIdentity.Claims
                );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
