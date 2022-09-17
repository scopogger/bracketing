/// <summary>
/// 
/// This is a console app for converting unique chars to '(' and duped chars to ')'.
/// Case-insensitive.
/// 
/// Default testing inputs and outputs:
/// "din"      =>  "((("
/// "recede"   =>  "()()()"
/// "Success"  =>  ")())())"
/// "(( @"     =>  "))(("
/// 
/// </summary>

class Result
{
    public static string giveDupes(string text)
    {
        text = text.ToLower();   // Ignoring Lower- and Uppercase difference
        Dictionary<char, int> dict = new Dictionary<char, int>();

        foreach (char c in text)   // Filling dict with chars and their repeat-count
        {
            if (dict.ContainsKey(c))   // <-- Duped
                dict[c]++;
            else
                dict.Add(c, 1);   // <-- New unique one
        }

        string textOut = "";
        foreach (char c in text)
        {
            if (dict[c] > 1)
                textOut += ")";
            else
                textOut += "(";
        }

        return textOut;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        Console.WriteLine(">This app converts unique chars into '(' and duped chars into ')'");
        Console.WriteLine(">UPPER/lower cases count as the same");
        Console.WriteLine(">Ctrl+C to quit the app. (Cmd+C if your're using mac)");
        int qaExpertAchievement = 0;
        bool inTheLoop = true;
        while (inTheLoop)
        {
            Console.WriteLine("Enter text to work with:");
            string text = Console.ReadLine();

            Console.WriteLine(Result.giveDupes(text));   // Bracket'ification result

            if (qaExpertAchievement == 5)
                Console.WriteLine("More than 5 tests! O_o*");
            qaExpertAchievement++;
            Console.WriteLine();
        }
    }
}