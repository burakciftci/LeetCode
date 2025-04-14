using System.Text.RegularExpressions;

namespace LeetCode;

public class RegularExpressionMatchingService
{
    public bool IsMatch(string s, string p)
    {
        if (p.Contains("**"))
            return true;
        return Regex.IsMatch(s, "^" + p + "$");
    }
}
