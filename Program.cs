using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleLibrary;
using SimpleInjector;

namespace Console_SimpleInjector
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new SimpleInjector.Container();
            // container.Register<INodeDescriber, BozoNodeDescriber>();
            container.Register<INodeDescriber, SimpleNodeDescriber>();
            container.Register<INodeActivator, SimpleNodeActivator>();

            INodeDescriber nodeDescriber = container.GetInstance<INodeDescriber>();
            Console.WriteLine( nodeDescriber.Describe(new SingleChildNode("Bob", new NoChildrenNode("Ralph"))) );
            Console.ReadLine();

            INodeActivator nodeActivator = container.GetInstance<INodeActivator>(); // SimpleInjector supplies INodeDescriber to SimpleNodeActivator
            Console.WriteLine(nodeActivator.Activate(new SingleChildNode("Genghis", new NoChildrenNode("Kubla"))));
            Console.ReadLine();

        }
    }
}
