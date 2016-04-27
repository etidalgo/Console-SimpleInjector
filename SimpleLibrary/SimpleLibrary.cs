using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLibrary
{
    public abstract class Node
    {
        public string Name { get; private set; }
        protected Node(string name)
        {
            Name = name;
        }
        public abstract IEnumerable<Node> SubNodes { get; }

    }
    public class NoChildrenNode : Node
    {
        public NoChildrenNode(string name)
            : base(name)
        { }

        public override IEnumerable<Node> SubNodes
        {
            get
            {
                yield break;
            }
        }
    }
    public class SingleChildNode : Node
    {
        public Node Child { get; private set; }
        public SingleChildNode(string name, Node child)
            : base(name)
        {
            Child = child;
        }

        public override IEnumerable<Node> SubNodes
        {
            get
            {
                yield return Child;
                yield break;
            }
        }

    }

    public class TwoChildrenNode : Node
    {
        public Node FirstChild { get; private set; }
        public Node SecondChild { get; private set; }
        public TwoChildrenNode(string name, Node first, Node second)
            : base(name)
        {
            FirstChild = first;
            SecondChild = second;
        }

        public override IEnumerable<Node> SubNodes
        {
            get
            {
                yield return FirstChild;
                yield return SecondChild;
                yield break;
            }
        }
    }

    public class ManyChildrenNode : Node
    {
        public IEnumerable<Node> Children { get; private set; }
        public ManyChildrenNode(string name, params Node[] children)
            : base(name)
        {
            Children = children;
        }

        public override IEnumerable<Node> SubNodes { get { return Children; } }
    }

    public interface INodeDescriber
    {
        string Describe(Node node);
    }

    public interface INodeActivator
    {
        string Activate(Node node);
    }
}
