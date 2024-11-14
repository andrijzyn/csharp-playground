namespace LikeA7 {
    public class Product(string name, float weight) : Detail(name, weight)
    {
        private readonly List<Node> _nodes = [];

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
