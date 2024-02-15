using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class ProductA : IProduct
    {
        public string Operation()
        {
            return "Wow! We just Created ProductA";
        }
    }
}
