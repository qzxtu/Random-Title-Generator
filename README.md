
# Random-Title-Generator

This code is a C# method that generates a random string of characters. It uses a constant string of characters (uppercase letters A-Z and digits 0-9) and the Random class to select a random character from the string, repeating this process for the desired length of the random string. The resulting string can be used as a title or in other applications. The code is efficient and easy to use, making it a useful addition to any C# project.

## Deployment
- Instead of using Enumerable. Repeat to repeat the chars string length times, you could use a StringBuilder to build the random string more efficiently:
```c#
public static string GenerateRandomString(int length)
{
    const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
    var sb = new StringBuilder(length);
    for (int i = 0; i < length; i++)
    {
        sb.Append(chars[random.Next(chars.Length)]);
    }
    return sb.ToString();
}

```
- If you're generating many random strings, you may want to reuse the same Random instance instead of creating a new one each time. This can improve performance and reduce memory usage:
```c#
private static readonly Random random = new Random();

public static string GenerateRandomString(int length)
{
    const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
    var sb = new StringBuilder(length);
    for (int i = 0; i < length; i++)
    {
        sb.Append(chars[random.Next(chars.Length)]);
    }
    return sb.ToString();
}

// Example usage:
// Sets the title of the console window to a random string of length 20.
Console.Title = GenerateRandomString(20);

// Generate 10 random strings of length 5.
for (int i = 0; i < 10; i++)
{
    var randomString = GenerateRandomString(5);
    Console.WriteLine(randomString);
}

```

- If you're generating very long random strings (e.g. thousands of characters), using a char[] array instead of a StringBuilder can be even more efficient:
```c#
private static readonly Random random = new Random();

public static string GenerateRandomString(int length)
{
    const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
    var randomChars = new char[length];
    for (int i = 0; i < length; i++)
    {
        randomChars[i] = chars[random.Next(chars.Length)];
    }
    return new string(randomChars);
}

```


## Authors

- [@qzxtu](https://www.github.com/qzxtu)

## Support

 [![PayPal](https://img.shields.io/badge/PayPal-00457C?style=for-the-badge&logo=paypal&logoColor=white)](https://paypal.me/nova355killer)   
 [![Ko-Fi](https://img.shields.io/badge/kofi-00457C?style=for-the-badge&logo=ko-fi&logoColor=white)](https://ko-fi.com/nova355)
