namespace LikeA7 {
    public class Mechanism(string name, float weight) : Detail(name, weight)
    {
        private readonly List<Detail> _details = [];

        public void AddDetail(Detail detail)
        {
            _details.Add(detail);
            Weight += detail.Weight;
        }

        public override void DisplayInfo() {
            Console.WriteLine($"Mechanism: {Name}, Total Weight: {Weight}");
            Console.WriteLine("Contains the following details:");

            foreach (var detail in _details)
            {
                Console.WriteLine($" - {detail.Name}, Weight: {detail.Weight}");
            }
        }
    }
}
