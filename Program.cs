namespace TestProject
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Random dice = new Random();
            int roll1 = dice.Next();
            int roll2 = dice.Next(101);
            int roll3 = dice.Next(50, 101);

            Console.WriteLine($"First roll: {roll1}");
            Console.WriteLine($"Second roll: {roll2}");
            Console.WriteLine($"Third roll: {roll3}");
            dice.Next();

            int firstValue = 500;
            int secondValue = 600;
            int largerValue = Math.Max(firstValue, secondValue);

            Console.WriteLine(largerValue);

            Console.WriteLine("if-else example:");
            Conditional.Run();

            Subscription.Run();
            Console.WriteLine("Array example:");
            ArrayEx.Run();
            Console.WriteLine("For EACH example:");
            ForEachEx.Run();
            ForEachChallenge.Run();
        }
    }
}