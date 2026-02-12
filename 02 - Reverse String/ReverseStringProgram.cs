using System.Diagnostics;

namespace _02___Reverse_String
{
    internal class ReverseStringProgram
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
                Console.WriteLine("Usage: Program <string1> [<string2>...]");
            else
                for (int i = 0; i < args.Length; ++i)
                {
                    String s = args[i].ToLower();
                    String r = ReverseString(s);
                    if (IsPalindrome(s, r))
                        Console.WriteLine($"{s} - {r} - is a palindrome");
                    else
                        Console.WriteLine($"{s} - {r} - is not a palindrome");
                }
        }

        private static string ReverseString(string s)
        {
            String r = "";
            for (int i = 0; i < s.Length; ++i)
                r = s[i] + r;
            return r;
        }

        private static bool IsPalindrome(string l, string r)
        {
            if (l.Length != r.Length)
                return false;
            for (int i = 0; i < l.Length; ++i)
                if (l[i] != r[i])
                    return false;
            return true;
        }
    }
}
