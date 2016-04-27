using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleLibrary;

namespace Console_SimpleInjector
{
    public class SimpleNodeDescriber : INodeDescriber
    {
        public string Describe(Node node)
        {
            return "Simply " + node.Name;
        }

    }

    public class BozoNodeDescriber : INodeDescriber
    {
        public string Describe(Node node)
        {
            return "BozoImpl " + node.Name;
        }

    }

    public class SimpleNodeActivator : INodeActivator
    {
        private INodeDescriber NodeDescriber;
        public SimpleNodeActivator(INodeDescriber nodeDescriber)
        {
            NodeDescriber = nodeDescriber;
        }
        public string Activate(Node node)
        {
            return "Activating " + NodeDescriber.Describe(node);
        }
    }
}
