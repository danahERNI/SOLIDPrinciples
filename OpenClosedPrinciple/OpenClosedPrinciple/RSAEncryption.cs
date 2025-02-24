using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    public class RSAEncryption : IEncryption
    {
        public string Encrypt(string data)
        {
            return "RSA encrypted data.";
        }
    }
}
