using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulateWhatChanges
{
    public class EncryptUtility
    {
        private  readonly IEncryptionKeyReader encryptionKeyReader;
        public EncryptUtility(IEncryptionKeyReader _encryptionKeyReader)
        {
            encryptionKeyReader = _encryptionKeyReader; 
        }
       
        public string Encrypt(string original)
        {
            Key key = encryptionKeyReader.GetKey();

            return "";
        }
    }
}
