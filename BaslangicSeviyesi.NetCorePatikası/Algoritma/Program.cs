class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Lütfen bir string ifade ve bir index değeri girin (aralarında virgül ile): ");
        string input = Console.ReadLine();

        // Girişin virgülle ayrılan iki parçaya ayrılması
        string[] inputParts = input.Split(',');

        // Girilen string ifade ve index değerinin kontrolü
        if (inputParts.Length != 2)
        {
            Console.WriteLine("Hatalı giriş! Lütfen doğru formatta giriş yapın.");
            return;
        }

        string text = inputParts[0].Trim(); // Girilen string ifade
        int index;

        // Index değerinin integer'a dönüştürülmesi ve hata kontrolü
        if (!int.TryParse(inputParts[1].Trim(), out index))
        {
            Console.WriteLine("Index değeri geçersiz! Lütfen bir tam sayı girin.");
            return;
        }

        // Index değerinin sınırlarının kontrolü
        if (index < 0 || index >= text.Length)
        {
            Console.WriteLine("Index değeri string uzunluğunun dışında! Lütfen geçerli bir index girin.");
            return;
        }

        // İlgili index'teki karakterin çıkarılması
        string newText = text.Remove(index, 1);

        Console.WriteLine("Yeni string ifade: " + newText);
    }
}
