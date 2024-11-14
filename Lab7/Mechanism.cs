namespace ClassHierarchy {
    public class Mechanism : Detail {
        private readonly List<Detail> _details = [];

        public Mechanism(string name, float weight) : base(name, weight) { }

        public void AddDetail(Detail detail)
        {
            _details.Add(detail);
            Weight += detail.Weight; // Общий вес увеличивается при добавлении детали
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Mechanism: {Name}, Total Weight: {Weight}");
            Console.WriteLine("Contains the following details:");

            foreach (var detail in _details)
            {
                Console.WriteLine($" - {detail.Name}, Weight: {detail.Weight}");
            }
        }
    }
}
