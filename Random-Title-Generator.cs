private static readonly Random random = new Random();

/// <summary>
/// Generates a random string of the specified length.
/// </summary>
/// <param name="length">The length of the generated string.</param>
/// <returns>A random string of the specified length.</returns>
public static string GenerateRandomString(int length)
{
    const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
    return new string(Enumerable.Repeat(chars, length)
        .Select(s => s[random.Next(s.Length)]).ToArray());
}

// Example usage:
// Sets the title of the console window to a random string of length 20.
Console.Title = GenerateRandomString(20);