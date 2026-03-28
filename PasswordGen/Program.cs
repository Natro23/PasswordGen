namespace PasswordGen;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Password Generator!");
        
        while (true)
        {
            Console.Write("Choose a length for your password: ");
            int length = int.Parse(Console.ReadLine());

            Console.Write("Include numbers? (y/n): ");
            bool includeNumbers = Console.ReadLine().ToLower() == "y";

            Console.Write("Include symbols? (y/n): ");
            bool includeSymbols = Console.ReadLine().ToLower() == "y";

            Generator generator = new Generator();
            string password = generator.Generate(length, includeNumbers, includeSymbols);
            Console.WriteLine($"Your password: {password}");

            Console.Write("Generate another? (y/n): ");
            string answer = Console.ReadLine();
            if (answer.ToLower() != "y") break;
        }

        Console.WriteLine("Goodbye!");
    }
}