namespace LikeA7 {
    public class Node(string name, float weight) : Detail(name, weight)
    {
        private readonly List<Mechanism> _mechanisms = [];

        public void AddMechanism(Mechanism mechanism)
        {
            _mechanisms.Add(mechanism);
            Weight += mechanism.Weight;
        }

        public override void DisplayInfo() {
            Console.WriteLine($"Node: {Name}, Total Weight: {Weight}");
            Console.WriteLine("Contains the following mechanisms:");

            foreach (var mechanism in _mechanisms)
            {
                mechanism.DisplayInfo();
            }
        }
    }
}
