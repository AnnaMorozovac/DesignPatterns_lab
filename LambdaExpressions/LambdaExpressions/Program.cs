using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

public class Program
{
    public static void Main()
    {
        Random rnd = new Random();
        var numders = Enumerable.Range(0, 10).Select(_ =>  rnd.Next(1, 101)).ToList();
        var doubles = Enumerable.Range(0, 5).Select(_ => rnd.NextDouble() * 10).ToList();
        var strings = new List<string> { "Apple", "cherry", "banana", "", "Dog", "tomorrow" };

        Console.WriteLine("Generated numbers: " + string.Join(", ", numders));
        Console.WriteLine("Generated double: " + string.Join(", ", doubles.Select(d => d.ToString("F2"))));
        Console.WriteLine("All words: " + string.Join(", ", strings));
        Console.WriteLine("---------------------------------------------------");

        Console.WriteLine("1. Filtred odd numbers: " + string.Join(", ", FilterOdd(numders)));
        Console.WriteLine("2. Average from the list: " + GetAverage(doubles));
        Console.WriteLine("3. Sorting the list: " + string.Join(", ", SortAlphabetically(strings)));
        Console.WriteLine("4. Sum of even: " + SumOfEvens(numders));
        Console.WriteLine("5. Fuctorail: " + CalculateFactorial(3));
        Console.WriteLine("6. Nultiplication and Addition of elements: " + MultiplyAndSum(numders));
        Console.WriteLine("7. Square of each number: " + string.Join(", ", GetSquares(numders)));
        Console.WriteLine("8. Sort by length: " + string.Join(", ", SortByLength(strings)));
        Console.WriteLine("9. Number of words: " + CountWords("I like to play basketball"));
        Console.WriteLine("10. The first non-empty line: " + GetFirstNonEmpty(strings));
        Console.WriteLine("11. All in capital letters: " + AreAllStartedWithUpper(strings));
        Console.WriteLine("12. The second largest number: " + GetSecondLargest(numders));
        Console.WriteLine("13. The largest even number: " + GetMaxEven(numders));
    }

    public static List<int> FilterOdd(List<int> list) => 
        list.Where(n => n % 2 != 0).ToList();

    public static double GetAverage(List<double> list) =>
        list.Any() ? list.Average() : 0;

    public static List<string> SortAlphabetically(List<string> list) =>
        list.OrderBy(b => b).ToList();

    public static int SumOfEvens(List<int> list) =>
        list.Where(n => n % 2 == 0).Sum();

    public static long CalculateFactorial(int n) =>
        n == 0 ? 0 : Enumerable.Range(1, n).Select(i => (long)i).Aggregate((a, b) => a * b);

    public static int MultiplyAndSum(List<int> list) =>
        list.Select(n => n * 2).Sum();

    public static List<int> GetSquares(List<int> list) =>
        list.Select(n => n * n).ToList();

    public static List<string> SortByLength(List<string> list) =>
        list.OrderBy(s => s.Length).ToList();

    public static int CountWords(string sentence) =>
        sentence.Split(' ').Count(w => !string.IsNullOrWhiteSpace(w));

    public static string GetFirstNonEmpty(List<string> list) =>
        list.FirstOrDefault(s => !string.IsNullOrWhiteSpace(s)) ?? "Not found";

    public static bool AreAllStartedWithUpper(List<string> list) =>
        list.All(w => !string.IsNullOrEmpty(w) && char.IsUpper(w[0]));

    public static int GetSecondLargest(List<int> list) =>
        list.OrderByDescending(n => n).Distinct().Skip(1).FirstOrDefault();

    public static int? GetMaxEven(List<int> list) =>
        list.Where(n => n % 2 == 0).Select(n => (int?)n).Max();
}