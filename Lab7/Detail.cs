namespace ClassHierarchy {
    public class Detail {
        public string Name { get; set; }
        public float Weight { get; set; }

        public Detail(string name, float weight)
        {
            Name = name;
            Weight = weight;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Detail: {Name}, Weight: {Weight}");
        }
    }
}
