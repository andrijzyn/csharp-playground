// Zyniuk Andrij, SE 22k/1, 4 variant

namespace Phy_Fall{
    class Program {
        static void Main() {
            double G = 9.80665;

            Console.WriteLine("Enter height falling rock 🪨  in meters : ");    
            string input = Console.ReadLine();

            if (int.TryParse(input, out int HEIGHT)) { Console.WriteLine("Fall time in seconds: " + Math.Sqrt((2 * HEIGHT) / G)); }
            else { Console.WriteLine("❌ Wrong entered data!"); return; }
        }
    }
}