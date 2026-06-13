using System.Collections;

namespace Practice9._2 {
    public sealed class Person(string name, int age, int zarplata, string role)
        : IComparable<Person>
    {
        private string Name { get; } = name;
        public int Age { get; } = age;
        public string Role { get; } = role;
        public int Zarplata { get; } = zarplata;

        public int CompareTo(Person? other)
        {
            return other == null ? 1 : Age.CompareTo(other.Age);
        }

        public static bool operator <(Person p1, Person p2) => p1.CompareTo(p2) < 0;
        public static bool operator >(Person p1, Person p2) => p1.CompareTo(p2) > 0;
        public static bool operator <=(Person p1, Person p2) => p1.CompareTo(p2) <= 0;
        public static bool operator >=(Person p1, Person p2) => p1.CompareTo(p2) >= 0;

        public void Passport()
        {
            Console.WriteLine("Name = {0} Age = {1} Zarplata = {2}", Name, Age, Zarplata);
        }
    }

    public class SortByAge : IComparer<Person>
    {
        public int Compare(Person? x, Person? y)
        {
            if (x == null || y == null) return 0;
            return x.Age.CompareTo(y.Age);
        }
    }

    public class SortByZarplata : IComparer
    {
        public int Compare(object? ob1, object? ob2)
        {
            if (ob1 is Person p1 && ob2 is Person p2)
            {
                return p1.Zarplata.CompareTo(p2.Zarplata);
            }
            return 0;
        }
    }

    internal abstract class Program
    {
        private static void Main()
        {
            Person prep1 = new Person("Іванов", 48, 1500, "role1");
            Person prep2 = new Person("Петров", 36, 3500, "role2");
            Person prep3 = new Person("Соколов", 30, 1000, "role3");
            Person prep4 = new Person("Сидоров", 50, 4500, "role4");
            Person prep5 = new Person("Орлов", 50, 6000, "role5");
            Person prep6 = new Person("Федоров", 60, 1300, "role6");

            Person[] group = new Person[6];
            group[0] = prep1;
            group[1] = prep2;
            group[2] = prep3;
            group[3] = prep4;
            group[4] = prep5;
            group[5] = prep6;

            Person[] sortedByAge = (Person[])group.Clone();
            Person[] sortedByZarplata = (Person[])group.Clone();

            Console.WriteLine("Сортування за віком (по спаданню):");
            foreach (Person elem in sortedByAge.Reverse()) elem.Passport();

            Console.WriteLine("Сортування за зарплатою (по спаданню):");
            foreach (Person elem in sortedByZarplata.Reverse()) elem.Passport();

            Console.ReadLine();
        }
    }
}