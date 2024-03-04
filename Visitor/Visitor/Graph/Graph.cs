using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Interfaces;

namespace Visitor.Graph
{
    internal class Graph
    {
        public Graph(List<INode> nodes) => Nodes = nodes;
        public List<INode> Nodes { get; init; }
    }
}
