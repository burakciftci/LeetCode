namespace SlidingTechnique;

public class SlidingTechniqueService
{
    /// <summary>
    /// Finds the maximum sum of any contiguous subarray of size 'k' in the given array using the sliding window technique.
    /// </summary>
    /// <param name="arr">The input array of integers.</param>
    /// <param name="n">The number of elements in the array.</param>
    /// <param name="k">The size of the subarray (window) to consider.</param>
    /// <returns>The maximum sum of any contiguous subarray of size 'k'. Returns -1 if 'n' is less than or equal to 'k'.</returns>

    public int MaxSum(int[] arr, int n, int k)
    {
        if (n <= k)
        {
            Console.WriteLine("Invalid");
            return -1;
        }

        int maxSum = 0;
        for (int i = 0; i < k; i++)
            maxSum += arr[i];

        int windowSum = maxSum;
        for (int i = k; i < n; i++)
        {
            windowSum += arr[i] - arr[i - k];
            maxSum = Math.Max(windowSum, maxSum);
        }

        return maxSum;

    }

    /// <summary>
    /// Finds the length of the longest substring without repeating characters.
    /// Implements the sliding window technique using a dictionary to track character positions.
    /// </summary>
    /// <param name="s">The input string.</param>
    /// <returns>The length of the longest substring that contains no repeating characters.</returns>
    public int LengthOfLongestSubstring(string s)
    {
        Dictionary<char, int> seen = new Dictionary<char, int>();
        int i = 0, res = 0;

        for (int j = 0; j < s.Length; j++)
        {
            char currentChar = s[j];
            if (seen.ContainsKey(currentChar))
                i = Math.Max(i, seen[currentChar] + 1);
            seen[currentChar] = j;
            res = Math.Max(res, j - i + 1);
        }
        return res;
    }
}
