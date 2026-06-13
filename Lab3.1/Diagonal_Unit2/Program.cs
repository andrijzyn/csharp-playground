using System;
using System.Collections.Generic;

namespace Diagonals {
    class Program {
        static List<int[]> SplitStringIntoPairs(string input) {
            List<int[]> pairs = new List<int[]>();

            try {
                string[] numbers = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                Console.WriteLine("DEBUG: Length of inputs List:" + numbers.Length);
                
                if (numbers.Length != 6) { throw new FormatException("Wronk inserted data"); }

                for (int i = 0; i < numbers.Length; i += 2) {
                    int firstNumber = int.Parse(numbers[i]);
                    int secondNumber = int.Parse(numbers[i + 1]);
                    pairs.Add(new int[] { firstNumber, secondNumber });
                }
                return pairs;

            } catch (FormatException ex) {
                Console.WriteLine("Error: " + ex.Message);
                return new List<int[]>();
            } catch (Exception ex) {
                Console.WriteLine("Error: " + ex.Message);
                return new List<int[]>(); 
            }
        }

        static int[] FindFourthVertex(List<int[]> vertices) {
            if (vertices == null || vertices.Count != 3)
                throw new ArgumentException("Need 3 vertices");

            int[] A = vertices[0]; // (x1, y1)
            int[] B = vertices[1]; // (x2, y2)
            int[] C = vertices[2]; // (x3, y3)

            if (IsSamePoint(A, B) || IsSamePoint(A, C) || IsSamePoint(B, C))
                throw new ArgumentException("Is the same ccordinate of vertices");

            if (AreCollinear(A, B, C))
                throw new ArgumentException("That's a Line, not a Paralelogram");

            int[] D = new int[] { A[0] + C[0] - B[0], A[1] + C[1] - B[1] };

            if (IsSamePoint(D, A) || IsSamePoint(D, B) || IsSamePoint(D, C))
                throw new ArgumentException("Result is not Paralelogram");

            return D;
        }

        // Перевіряє, чи дві точки є однаковими
        static bool IsSamePoint(int[] point1, int[] point2) { return point1[0] == point2[0] && point1[1] == point2[1]; }
    
        // Перевіряє, чи три точки лежать на одній прямій
        static bool AreCollinear(int[] A, int[] B, int[] C) { return (A[0] * (B[1] - C[1]) + B[0] * (C[1] - A[1]) + C[0] * (A[1] - B[1])) == 0; }
    
        // Функція для обчислення довжини відрізка між двома точками
        static double Distance(int[] point1, int[] point2) { return Math.Sqrt(Math.Pow(point2[0] - point1[0], 2) + Math.Pow(point2[1] - point1[1], 2)); }

        static void Main() {
            Console.WriteLine("Enter coordinates of 3 vertices in the two-dimensional plane, like(x1 y1 x2 y2 x3 y3): ");
            List<int[]> vertices = SplitStringIntoPairs(Console.ReadLine()!); // "2 2 6 3 6 8"

            Console.WriteLine("\nDEBUG: This is a Main inputed data");
            vertices.ForEach(array => Console.WriteLine(string.Join(", ", array)));

            int[] D = FindFourthVertex(vertices);
            Console.WriteLine($"\nDEBUG: Coordinates of verticle D: ({D[0]}, {D[1]})");

            Console.WriteLine($"Diagonal (A -> C): {Distance(vertices[0], vertices[2]):F2}");
            Console.WriteLine($"Diagonal (B -> D): {Distance(vertices[1], D):F2}");
        }
    }
}