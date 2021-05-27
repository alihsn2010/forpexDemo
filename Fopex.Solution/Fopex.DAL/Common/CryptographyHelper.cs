using System.Security.Cryptography;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cryptography;

namespace Fopex.DAL.Common
{
    public class CryptographyHelper
    {
        string m_Key, m_Iv;

        public CryptographyHelper()
        {
            m_Key = Constants.AES.AES_KEY;
            m_Iv = Constants.AES.AES_IV;
        }

        public string Encrypt(string r_PlainText)
        {
            return new AESCipher().Encrypt(r_PlainText, m_Key, m_Iv);
        }

        public string Decrypt(string r_EncryptedText)
        {
            return new AESCipher().Decrypt(r_EncryptedText, m_Key, m_Iv);
        }
    }
}
