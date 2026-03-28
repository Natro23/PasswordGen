namespace PasswordGen;

public class Generator
{
    private string characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
    private string numbers = "0123456789";
    private string specialSymbols = "!@#$%^&*()_+-=";
    private Random random = new Random();
    public string Generate(int length, bool includeNumbers, bool includeSymbols)
    {
        string pool = characters;
    
        if (includeNumbers) pool += numbers;
        if (includeSymbols) pool += specialSymbols;
    
        string password = "";
        for (int i = 0; i < length; i++)
        {
            password += pool[random.Next(pool.Length)];
        }
        return password;
    }
}
