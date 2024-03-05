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
        void ExportForCommercial(INode commercial);
        void ExportForConstruction(INode construction);
        void ExportForIndustrial(INode industrial);
        void ExportForResidential(INode residential);
    }
}
