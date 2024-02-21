class Program
{
    static void Main()
    {
        Console.Write("Lütfen dairenin yarıçapını girin: ");
        double yaricap;

        while (!double.TryParse(Console.ReadLine(), out yaricap) || yaricap <= 0)
        {
            Console.WriteLine("Geçersiz giriş. Lütfen pozitif bir sayı girin.");
            Console.Write("Lütfen dairenin yarıçapını girin: ");
        }

        DrawCircle(yaricap);
    }

    static void DrawCircle(double radius)
    {
        for (int i = 0; i <= 2 * radius; i++)
        {
            for (int j = 0; j <= 2 * radius; j++)
            {
                double distance = Math.Sqrt(Math.Pow(i - radius, 2) + Math.Pow(j - radius, 2));

                if (Math.Abs(distance - radius) < 0.5)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}
