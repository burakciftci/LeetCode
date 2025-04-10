namespace LeetCode;

public class ZigZagConversionService
{
    /// <summary>
    /// Converts a string into a zigzag pattern on a given number of rows,
    /// then reads the characters row by row to form a new string.
    /// Time Complexity: O(n)
    /// Space Complexity: O(n)
    /// </summary>
    public string Convert(string s, int numRows)
    {
        if (numRows == 1)
        {
            return s;
        }

        Span<char> result = stackalloc char[s.Length];

        var resultIndex = 0;
        var period = numRows * 2 - 2;

        for (int row = 0; row < numRows; row++)
        {
            var increment = 2 * row;

            for (int i = row; i < s.Length; i += increment)
            {
                result[resultIndex++] = s[i];

                if (increment != period)
                {
                    increment = period - increment;
                }
            }
        }

        return result.ToString();
    }
}
