using Microsoft.VisualBasic;

namespace teach_05;

/*
 * CSE212 
 * (c) BYU-Idaho
 * 05-Teach - Problem 1
 * 
 * It is a violation of BYU-Idaho Honor Code to post or share this code with others or 
 * to post it online.  Storage into a personal and private repository (e.g. private
 * GitHub repository, unshared Google Drive folder) is acceptable.
 *
 */
public static class UniqueLetters {
    public static void Run() {
        var test1 = "abcdefghjiklmnopqrstuvwxyz"; // Expect True because all letters unique
        Console.WriteLine(AreUniqueLettersSETTING(test1));

        var test2 = "abcdefghjiklanopqrstuvwxyz"; // Expect False because 'a' is repeated
        Console.WriteLine(AreUniqueLetters(test2));

        var test3 = "";
        Console.WriteLine(AreUniqueLetters(test3)); // Expect True because its an empty string
    }

    /// <summary>Determine if there are any duplicate letters in the text provided</summary>
    /// <param name="text">Text to check for duplicate letters</param>
    /// <returns>true if all letters are unique, otherwise false</returns>
    private static HashSet<string> _set1 = new HashSet<string>(){};

    private static bool AreUniqueLettersSETTING(string text) {
        foreach (char i in text) {
            string j;
            j = i.ToString();
            _set1.Add(j);
        }
        return true;
    }
    private static bool AreUniqueLetters(string text) {
        // // TODO Problem 1 - Replace the O(n^2) algorithm to use sets and O(n) efficiency

        var set2 = new HashSet<string>(){text};

        var set3 = _set1.Intersect(set2).ToHashSet(); 
        if (set3.Count() != 0) { //(if not 0, then that means there was an intersect)
            var set4 = _set1.Union(set2).ToHashSet();
            _set1 = set4;
            return true;
        } else {
            foreach(var elem in set3) {
                Console.WriteLine($"These are not unique: {elem}");
            }
            return false;
        }
        

        // for (var i = 0; i < text.Length; ++i) {
        //     for (var j = 0; j < text.Length; ++j) {
        //         // Don't want to compare to yourself ... that will always result in a match
        //         if (i != j && text[i] == text[j])
        //             return false;
        //     }
        // }

        //return true;
    }
}