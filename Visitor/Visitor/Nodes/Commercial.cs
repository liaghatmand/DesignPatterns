using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Interfaces;

namespace Visitor.Nodes
{
    public class Commercial : INode
    {
        public Commercial(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}
