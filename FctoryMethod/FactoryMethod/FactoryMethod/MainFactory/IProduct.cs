using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.MainFactory
{
    //Has some methods that concrete products implement.
    public interface IProduct
    {
        public string Operation();
    }
}
