﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    public class AESEncryption : IEncryption
    {
        public string Encrypt(string data)
        {
            return "AES encrypted data.";
        }
    }
}
