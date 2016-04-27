using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleLibrary;

namespace Console_SimpleInjector
{
    public class SimpleImpl : INodeDescriber
    {
        public string Describe(Node node)
        {
            return "SimpleImpl";
        }

    }

    public class BozoImpl : INodeDescriber
    {
        public string Describe(Node node)
        {
            return "BozoImpl";
        }

    }

}
