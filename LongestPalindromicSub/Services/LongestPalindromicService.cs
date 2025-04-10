namespace LeetCode;

public class LongestPalindromicService
{
    /// <summary>
    /// Finds the longest palindromic substring in a given string using Manacher's Algorithm.
    /// Time Complexity: O(n)
    /// Space Complexity: O(n)
    /// </summary>
    public string ManachersAlgorithm(string s)
    {
        string T = "^#" + string.Join("#", s.ToCharArray()) + "#$";
        int n = T.Length;
        int[] P = new int[n];
        int C = 0, R = 0;

        for (int i = 1; i < n - 1; i++)
        {
            P[i] = (R > i) ? Math.Min(R - i, P[2 * C - i]) : 0;
            while (T[i + 1 + P[i]] == T[i - 1 - P[i]])
                P[i]++;

            if (i + P[i] > R)
            {
                C = i;
                R = i + P[i];
            }
        }

        int max_len = P.Max();
        int center_index = Array.IndexOf(P, max_len);
        return s.Substring((center_index - max_len) / 2, max_len);
    }
}
