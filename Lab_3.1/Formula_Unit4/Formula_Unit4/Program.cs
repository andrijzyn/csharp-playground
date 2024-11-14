namespace FormulaCalculator {
	class Program {
		static void Main(string[] args) {
			while (true) {
				Console.Write("Введіть значення x (0 для виходу): ");
				double x = Convert.ToDouble(Console.ReadLine());
				
				if (x == 0)
					break;
			
				Console.Write("Введіть значення y: ");
				double y = Convert.ToDouble(Console.ReadLine());
				
				Console.Write("Введіть значення z: ");
				double z = Convert.ToDouble(Console.ReadLine());
				
				// Обчислення a
				double a = x * (Math.Atan(z) + Math.Pow(y, 3));
			
				// Визначення діапазонів для x та a
				string GetRange(double value){
					if (value < -10) return "менше за -10";
					else if (value < -1) return "менше за -1";
					else if (value < 1) return "більше за -1 і менше за 1";
					else if (value < 10) return "більше за 1 і менше за 10";
					else return "більше за 10";
				}
			
				// Виведення результату
				Console.WriteLine($"Результат: a = {a}");
				Console.WriteLine($"x належить до діапазону: {GetRange(x)}");
				Console.WriteLine($"a належить до діапазону: {GetRange(a)}");
			
				return;
			}
		}
	}
}