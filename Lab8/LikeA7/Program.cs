namespace LikeA7 {
    internal abstract class Program {
        private static void Main() {
            Detail bolt = new("Bolt", 0.5f);
            Detail nut = new("Nut", 0.2f);
            Detail gear = new("Gear", 1.5f);
            Mechanism gearbox = new("Gearbox", 2.0f);
            Node engineNode = new("Engine Node", 10.0f);
            Product car = new("Car", 50.0f);
            
            gearbox.AddDetail(bolt);
            gearbox.AddDetail(nut);
            gearbox.AddDetail(gear);
            engineNode.AddMechanism(gearbox);
            
            car.AddNode(engineNode);
            car.DisplayInfo();
        }
    }
}