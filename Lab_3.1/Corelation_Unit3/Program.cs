class Program {
    static void Main() {
        try {
            Console.Write("Введіть додатне дійсне число: ");
            string input = Console.ReadLine()!;
            
            if (!double.TryParse(input, out double number)) {
                throw new FormatException("Введено не число. Спробуйте ще раз.");
            }
            
            if (number <= 0) {
                throw new ArgumentException("Число має бути додатним.");
            }

            double fractionalPart = number - Math.Floor(number);

            if (fractionalPart == 0) {
                Console.WriteLine("Число є цілим, дробової частини немає.");
            } else {
                string fractionalString = fractionalPart.ToString("F3").Substring(2, 3);

                if (fractionalString.Contains("0")) {
                    Console.WriteLine("Серед перших трьох цифр дробової частини є цифра 0.");
                } else {
                    Console.WriteLine("Серед перших трьох цифр дробової частини немає цифри 0.");
                }
            }
        } catch (FormatException ex) {
            Console.WriteLine("Помилка: " + ex.Message);
        } catch (ArgumentException ex) {
            Console.WriteLine("Помилка: " + ex.Message);
        } catch (Exception ex) {
            Console.WriteLine("Виникла невідома помилка: " + ex.Message);
        }
    }
}
