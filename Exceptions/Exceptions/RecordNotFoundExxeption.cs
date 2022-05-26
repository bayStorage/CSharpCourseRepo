using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class RecordNotFoundExxeption : Exception
    {
        public RecordNotFoundExxeption(string message) : base(message)
        {

        }

    }
}
