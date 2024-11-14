using System;
using System.Collections.Generic;

namespace ClassHierarchy {
    public class Node : Detail {
        private readonly List<Mechanism> _mechanisms = [];

        public Node(string name, float weight) : base(name, weight) { }

        public void AddMechanism(Mechanism mechanism)
        {
            _mechanisms.Add(mechanism);
            Weight += mechanism.Weight; // Общий вес увеличивается при добавлении механизма
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Node: {Name}, Total Weight: {Weight}");
            Console.WriteLine("Contains the following mechanisms:");

            foreach (var mechanism in _mechanisms)
            {
                mechanism.DisplayInfo();
            }
        }
    }
}
