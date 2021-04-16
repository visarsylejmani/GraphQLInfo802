using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLInfo802.Exceptions
{
    public class ProduitNotFoundException : Exception
    {
        public int ProduitID { get; internal set; }
    }
}
