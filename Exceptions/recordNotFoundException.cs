using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class recordNotFoundException:Exception
    {
        public recordNotFoundException(string message):base(message)
        {

        }
    }
}
