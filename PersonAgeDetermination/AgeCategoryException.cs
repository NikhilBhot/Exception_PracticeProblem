using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonAgeDetermination
{
    public class AgeCategoryException : Exception
    {
        public AgeCategoryException(string message) : base(message)
        {
        }
    }
}
