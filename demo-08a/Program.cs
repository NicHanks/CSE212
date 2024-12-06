namespace demo_08a;

// CSE 212 Lesson 8A 
// Use recursion to display a word forward and backwards.
public static class Program {
    private static void DisplayForwards(string word) {
    if (word.Length == 0) {
        return;
    } else {
        char x = word[0]; //  char x = word[0]; // x equalls the first character in the word. // x equals the first character in the word.
        string remainingWord = word.Substring(1); // removes the first letter of the word.
        Console.Write(x);
        DisplayForwards(remainingWord); // Recursive call without concatenation
    }
}

private static void DisplayBackwards(string word)
{
    int length = word.Length;
    if (length > 0)
    {
        char lastChar = word[length - 1];
        Console.WriteLine(lastChar);
        string substring = word.Substring(0, length - 1);
        DisplayBackwards(substring);
    }
}

    private static void Main() {
        DisplayForwards("Recursion");
        Console.WriteLine("=====================");
        DisplayBackwards("Recursion");

        // Notes about array/string Slicing:

        // word[a..] - Index 'a' to the end
        // word[..a] = Index 0 to 'a' (not including 'a')
        // word[..] = Include everything (copy the array)
        // word[a..b] = Index 'a' to 'b' (not including 'b')

        // When slicing a list, it creates a new array.  A common trick
        // to copy an array is to do: newArray = array[..]

    }
}