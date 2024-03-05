using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Nodes;

namespace Visitor.Interfaces
{
    public interface IVisitor
    {
        void Visit(Commercial commercial);
        void Visit(Construction construction);
        void Visit(Industrial industrial);
        void Visit(Residential residential);
    }
}
