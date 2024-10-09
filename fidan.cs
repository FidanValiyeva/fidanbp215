internal class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 4, 8, 97, 46, 67 };
        int a = Min(numbers);
        Console.WriteLine(a);

        static int Min(int[] numbers)
        {

            int minValue = numbers.Min();
            return minValue;