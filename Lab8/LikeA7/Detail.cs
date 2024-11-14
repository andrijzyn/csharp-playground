namespace LikeA7 {
    public class Detail(string name, float weight)
    {
        public string Name { get; set; } = name;
        public float Weight { get; protected set; } = weight;

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Detail: {Name}, Weight: {Weight}");
        }
    }
}
