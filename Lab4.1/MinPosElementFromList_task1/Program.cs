// 4 варіант,
// Таска 1. Визначити мінімальний елемент серед додатних елементів.
// Таска 2. Обчислити кількість додатних елементів та їх добуток.

namespace MinPosElementFromList_task1;

public abstract class Program {
    private static void Main() {
        int[] array = [-5, 0, 12, -3, 1, 7, 9, -2]; // Min PosElement = 1

        // Таска 1. Лінька LINQ для пошуку мінімального серед додатних елементів
        int? minPositive = array.Where(x => x > 0).Min();
        
        Console.WriteLine($"Мінімальний додатний елемент: {minPositive}");
        
        // Таска 2. Фільтруємо додатні елементи
        var positiveElements = array.Where(x => x > 0).ToList();
        var count = positiveElements.Count;
        var product = positiveElements.Aggregate(1, (acc, val) => acc * val);
        
        Console.WriteLine($"\nКількість додатних елементів: {count}");
        Console.WriteLine($"Добуток додатних елементів: {product}");
    }
}