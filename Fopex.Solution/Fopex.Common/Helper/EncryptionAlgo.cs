using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Fopex.COMMON.Helper
{
    public class EncryptionAlgo
    {
        #region SHA256 Hashing Algo
        public static string Encrypt(string[] obj, string HassingKey)
        {
            string[] HashArray = obj;
            var str = string.Empty;
            str += HassingKey;
            var result = "";
            for (int i = 0; i < HashArray.Length; i++)
            {
                if (HashArray[i] != "undefined" && HashArray[i] != null && HashArray[i] != "")
                {
                    str += "&" + HashArray[i];
                }
            }
            String data = str;
            String key = HassingKey;
            var secretBytes = Encoding.UTF8.GetBytes(key);
            using (var hmac = new HMACSHA256(secretBytes))
            {
                byte[] iso88591data = Encoding.GetEncoding("ISO-8859-1").GetBytes(data);
                var hash = hmac.ComputeHash(iso88591data);
                StringBuilder hex = new StringBuilder(hash.Length * 2);
                foreach (byte b in hash) hex.AppendFormat("{0:x2}", b);
                result = hex.ToString(); //Your generated hash 
            }
            return result;
        }
        #endregion
    }
}
