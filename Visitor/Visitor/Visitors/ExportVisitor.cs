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
        public void ExportForCommercial(INode commercial) 
            => Console.WriteLine("Commercial");

        public void ExportForConstruction(INode construction) 
            => Console.WriteLine("Construction");

        public void ExportForIndustrial(INode industrial) 
            => Console.WriteLine("Industrial");

        public void ExportForResidential(INode residential) 
            => Console.WriteLine("Residential");
    }
}
