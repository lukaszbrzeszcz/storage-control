using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SterowanieMagazynowaniem
{
    public class ItemLimitExceeded : Exception
    {
        public ItemLimitExceeded()
        {
        }

        public ItemLimitExceeded(string message) : base(message)
        {

        }

        public ItemLimitExceeded(string message, Exception inner) : base(message, inner)
        {

        }
    }
}
