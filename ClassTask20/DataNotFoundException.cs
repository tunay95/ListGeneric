using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask20
{
    internal class DataNotFoundException : Exception
    {
        public DataNotFoundException():base("user not found")
        {

        }


    }
}
