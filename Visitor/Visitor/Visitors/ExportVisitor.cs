using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Interfaces;
using Visitor.Nodes;

namespace Visitor.Visitors
{
    public class ExportVisitor : IVisitor
    {
        public void Visit(Commercial commercial) 
            => Console.WriteLine("Commercial");

        public void Visit(Construction construction) 
            => Console.WriteLine("Construction");

        public void Visit(Industrial industrial) 
            => Console.WriteLine("Industrial");

        public void Visit(Residential residential) 
            => Console.WriteLine("Residential");
    }
}
