public class Program
{
    static void Main(string[] args)
    {
        Console.Write("Input: ");
        string input = Console.ReadLine();

        string output = MoveFirstCharacterToEnd(input);

        Console.WriteLine("Output: " + output);
    }

    static string MoveFirstCharacterToEnd(string input)
    {
        char firstChar = input[0];
        string result = input.Substring(1);
        result += firstChar;
        return result;
    }
}
