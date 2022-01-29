using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Bll.Helper
{
    public static class PasswordHelper
    {

        public static string GetPasswordHashValue(string password)
        {
            return
                string.Concat(MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(password)).Select(x => x.ToString("x2")));
        }

    }
}
