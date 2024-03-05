using Visitor.Graph;
using Visitor.Interfaces;
using Visitor.Nodes;
using Visitor.Visitors;

List<INode> iNodes = new() { new Residential("R"), new Industrial("I") };
ExportVisitor visitor = new();

Graph graph = new(iNodes);

foreach (INode node in graph.Nodes)
{
    if (node is Residential) { visitor.ExportForResidential(node); }
    else if (node is Industrial) { visitor.ExportForIndustrial(node); }
    else if (node is Construction) { visitor.ExportForConstruction(node); }
    else if (node is Commercial) { visitor.ExportForCommercial(node); }
}