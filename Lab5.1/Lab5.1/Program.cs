using System.Text;

namespace Lab5._1;

static class Program  {
    private static void Main()
    {
        // Завдання 1: Введення тексту з трьома числами та обчислення їх суми
        Console.WriteLine("Введіть текст з трьома числами, розділеними пробілами (наприклад, 20 40 10):");
        var input = Console.ReadLine();
        if (input != null)
        {
            var sum = CalculateSum(input);
            Console.WriteLine($"Сума чисел: {sum}");
        }

        // Завдання 2: Розділення тексту на слова
        Console.WriteLine("Введіть текст для розділення на слова:");
        var text = Console.ReadLine();
        if (text != null) SplitTextIntoWords(text);

        // Завдання 3: Консольний арифметичний калькулятор
        do
        {
            Console.WriteLine("Введіть арифметичний вираз (наприклад, 23+5) або 'exit' для виходу:");
            var expression = Console.ReadLine();
            if (expression?.ToLower() == "exit")
                break;

            try
            {
                if (expression != null)
                {
                    var result = EvaluateExpression(expression);
                    Console.WriteLine($"Результат: {result}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }

        } while (true);
    }

    // Завдання 1: Метод для обчислення суми
    static int CalculateSum(string input)
    {
        var numbers = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        var sum = 0;

        foreach (var number in numbers)
        {
            if (int.TryParse(number, out var num))
            {
                sum += num;
            }
            else
            {
                Console.WriteLine($"'{number}' не є числом.");
            }
        }

        return sum;
    }

    // Завдання 2: Метод для розділення тексту на слова
    static void SplitTextIntoWords(string text)
    {
        var sb = new StringBuilder();
        var words = text.Split([' ', ',',