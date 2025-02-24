using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AESEncryption aesEncryption = new AESEncryption();
            Encryption encryption = new Encryption(aesEncryption);

            string unencryptedString = encryption.EncryptData("This is an example of unencrypted data for AES."); 
            Console.WriteLine(unencryptedString);

            RSAEncryption rsaEncryption = new RSAEncryption();
            encryption = new Encryption(rsaEncryption);
            unencryptedString = encryption.EncryptData("This is an example of unencrypted data for RSA.");
            Console.WriteLine(unencryptedString);


            //aesEncryption

        }
    }
}
