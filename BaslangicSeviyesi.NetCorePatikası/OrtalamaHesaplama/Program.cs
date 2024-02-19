using OrtalamaHesaplama;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Fibonacci serisinin derinliğini giriniz:");
        int depth = Convert.ToInt32(Console.ReadLine());

        FibonacciCalculator calculator = new FibonacciCalculator();
        double average = calculator.GetFibonacciAverage(depth);

        Console.WriteLine("Ortalama: " + average);
    }
}
