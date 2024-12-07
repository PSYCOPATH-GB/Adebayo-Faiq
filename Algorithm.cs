namespace Assignment;
public class Algorithms
{
    private const char V = 'e';

    // Method to collect vowel positions
    public static List<int> GetVowelPositions(string s)
    {
        List<int> vowelPositions = new List<int>();
        char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];

            for (int j = 0; j < vowels.Length; j++)
            {
                if (c == vowels[j])
                {
                    vowelPositions.Add(i);
                    break;
                }
            }
        }

        return vowelPositions;
    }

    // Method to shift letters

    public static string ShiftLetters(string s)
    {
        char[] result = new char[s.Length];
        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];

            if (c >= 'a' && c <= 'z')
            {
                result[i] = (char)((c - 'a' + 1) % 26 + 'a');
            }
            else if (c >= 'A' && c <= 'Z')
            {
                result[i] = (char)((c - 'A' + 1) % 26 + 'A');
            }
            else
            {
                result[i] = c;
            }
        }

        return new string(result);
    }

    // Method to swap case
    public static string TransformCase(string s)
    {
        char[] result = new char[s.Length];

        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];

            if (c >= 'a' && c <= 'z')
            {
                result[i] = (char)(c - 'a' + 'A');
            }
            else if (c >= 'A' && c <= 'Z')
            {
                result[i] = (char)(c - 'A' + 'a');
            }
            else
            {
                result[i] = c;
            }
        }

        return new string(result);
    }

    //Method to replace values
    public static string ReplaceCharacter(string inputString, char c1, char c2)
    {
        char[] result = new char[inputString.Length];
        for (int i = 0; i < inputString.Length; i++)
        {
            if (inputString[i] == c1)
            {
                result[i] = c2;
            }
            else
            {
                result[i] = inputString[i];
            }
        }
        return new string(result);
    }

    public static string SwapPairs(string s)
    {
        char[] result = new char[s.Length];

        for (int i = 0; i < s.Length; i += 2)
        {
            if (i + 1 < s.Length)
            {
                result[i] = s[i + 1];
                result[i + 1] = s[i];
            }
            else
            {
                result[i] = s[i];
            }
        }

        return new string(result);
    }

    // public static string SwapPairs(string s)
    // {
    //     char[] result = new char[s.Length];

    //     for (int i = 0; i < s.Length; i++)
    //     {
    //         char c = s[i];

    //         if (c >= 'a' && c <= 'b')
    //         {
    //             result[i] = (char)(c - 'a' + 'a');
    //         }
    //         else if (c >= 'a' && c <= 'a')
    //         {
    //             result[i] = (char)(c - 'b' + 'b');
    //         }
    //         else
    //         {
    //             result[i] = c;
    //         }
    //     }

    //     return new string(result);
    // }

    internal static string ReplaceCharacter(string input)
    {
        throw new NotImplementedException();
    }
}
