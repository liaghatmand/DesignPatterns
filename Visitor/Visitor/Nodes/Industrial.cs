using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using Visitor.Interfaces;

namespace Visitor.Nodes
{
    public class Industrial : INode
    {
        public string Name { get; set; }
        public Industrial(string name)
        {
            Name = name;
        }
    }
}
