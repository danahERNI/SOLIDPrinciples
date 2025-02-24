using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    public class Encryption 
    {
        private readonly IEncryption _encryption;

        public Encryption(IEncryption encryption) 
        {
            _encryption = encryption;
        }
        public string EncryptData(string data)
        {
            return _encryption.Encrypt(data);
        }
    }
}
