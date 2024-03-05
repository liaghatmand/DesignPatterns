
# Visitor

"Visitor is a behavioral design pattern that lets you separate algorithms from the objects on which they operate."

# Problem

- You have a graph with a lot of nodes that are complex objects and of different classes.
- You want to export all the nodes to an XML file and every export is different for each class.

# First Solution

- Place an export method in each class and go over each node to export it.
- But this way you will have to change each class and if another method needs to be added you have to do it again.

#Second Solution

- Place the method in a separated class with a method suitable for each class.
- Use conditions to call the right method for each class.
In program.cs

```C#
foreach (INode node in graph.Nodes)`

{
    if (node is Residential) { visitor.ExportForResidential(node); }
    else if (node is Industrial) { visitor.ExportForIndustrial(node); }
    else if (node is Construction) { visitor.ExportForConstruction(node); }
    else if (node is Commercial) { visitor.ExportForCommercial(node); }
}
```
- this will end up being an enormous condition.

#Best Solution

- Place a method in each Node class, accepting the Visitor class.
- "this" will represent the node class, now you passed the right class into the right method.

```C#
public void Accept(IVisitor visitor)
{
    visitor.Visit(this);
}
```

in Program.cs

```c#
foreach (INode node in graph.Nodes)
{
    node.Accept(visitor);
}
```



