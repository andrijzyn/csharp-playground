using System;
using System.Collections.Generic;

namespace ClassHierarchy {
    public class Product : Detail {
        private readonly List<Node> _nodes = [];

        public Product(string name, float weight) : base(name, weight) { }

        public void AddNode(Node node)
        {
            _nodes.Add(node);
            Weight += node.Weight;
        }

        public override void DisplayInfo() {
            Console.WriteLine($"Product: {Name}, Total Weight: {Weight}");
            Console.WriteLine("Contains the following nodes:");

            foreach (var node in _nodes)
            {
                node.DisplayInfo();
            }
        }
    }
}
