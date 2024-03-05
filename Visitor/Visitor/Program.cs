using Visitor.Graph;
using Visitor.Interfaces;
using Visitor.Nodes;
using Visitor.Visitors;

List<INode> iNodes = new() { new Residential("R"), new Industrial("I") };
ExportVisitor visitor = new();

Graph graph = new(iNodes);

foreach (INode node in graph.Nodes)
{
    node.Accept(visitor);
}