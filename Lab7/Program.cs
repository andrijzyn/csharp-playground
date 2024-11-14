namespace ClassHierarchy {
    internal class Program {
        static void Main(string[] args) {
            Detail bolt = new("Bolt", 0.5f);
            Detail nut = new("Nut", 0.2f);
            Detail gear = new("Gear", 1.5f);

            Mechanism gearbox = new("Gearbox", 2.0f);
            gearbox.AddDetail(bolt);
            gearbox.AddDetail(nut);
            gearbox.AddDetail(gear);

            Node engineNode = new("Engine Node", 10.0f);
            engineNode.AddMechanism(gearbox);

            Product car = new("Car", 50.0f);
            car.AddNode(engineNode);

            car.DisplayInfo();

            Console.ReadKey();
        }
    }
}