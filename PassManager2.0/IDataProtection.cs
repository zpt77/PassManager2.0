using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassManager2._0
{
    interface IDataProtection
    {
        string Encrypt(string inputString);

        string Decrypt(string inputString);
    }
}
