using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Interfaces
{
    public interface INode
    {
        string Name { get; set; }
        public void Accept(IVisitor visitor);
    }
}
