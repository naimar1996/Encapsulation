namespace ConsoleApp62
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Invoice seafood = new Invoice(123456, "Person", "Bazaa Store");
            seafood.Article = "Salmon";
            seafood.Quantity = 2;
            seafood.Price = 25;
            Console.WriteLine(seafood.CostCalculation(true));
        }
    }
}