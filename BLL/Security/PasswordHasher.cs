using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Security
{
    public static class PasswordHasher
    {
        public static string HashPassword(string password)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(password);
            MD5CryptoServiceProvider CSP = new MD5CryptoServiceProvider();
            byte[] byteHash = CSP.ComputeHash(bytes);
            return byteHash.Aggregate(string.Empty, (current, b) => current + string.Format("{0:x2}", b));  
        }
    }
}
