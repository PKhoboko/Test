using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public static class HashPassword
    {
        public static string HashTo(string s)
        {
            return SHA256To(s);
        }
        private static string SHA256To(string s)
        {
            using (var alg = SHA256.Create())
                return string.Join(null, alg.ComputeHash(Encoding.UTF8.GetBytes(s)).Select(y => y.ToString("x2")));
        }
    }
}
