namespace LeetCode;

public class ReverseIntegerService
{
    /// <summary>
    /// Reverses the digits of a 32-bit signed integer.
    /// Returns 0 if the reversed integer overflows beyond the range of Int32.
    /// </summary>
    /// <param name="x">The integer to be reversed.</param>
    /// <returns>The reversed integer, or 0 if the result overflows.</returns>F
    public int Reverse(int x)
    {
        var result = 0;
        while (x != 0)
        {
            var remainder = x % 10;
            var temp = result * 10 + remainder;
            if ((temp - remainder) / 10 != result) return 0;
            result = temp;
            x /= 10;
        }

        return result;
    }
}
