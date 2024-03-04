using Visitor.Graph;
using Visitor.Interfaces;
using Visitor.Nodes;

List<INode> iNodes = new() { new Residential("R"), new Industrial("I") };

Graph graph = new(iNodes);

foreach (INode node in graph.Nodes)
{
    node.ExportToXML();
}