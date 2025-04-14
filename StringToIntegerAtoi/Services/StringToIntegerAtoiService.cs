namespace LeetCode;

public class StringToIntegerAtoiService
{
    /// <summary>
    /// Converts a string to a 32-bit signed integer.
    /// It discards leading whitespaces, handles optional '+' or '-' signs,
    /// and stops parsing when a non-digit character is encountered.
    /// If the number exceeds the 32-bit integer range, it clamps to Int32.MaxValue or Int32.MinValue.
    /// </summary>
    /// <param name="s">The input string representing the number.</param>
    /// <returns>The parsed integer or the clamped value in case of overflow.</returns>
    public int MyAtoi(string s)
    {
        s = s.Trim();
        if (string.IsNullOrEmpty(s))
        {
            return 0;
        }

        int i = 0, num = 0, sign = 1;

        if (s[0] == '+' || s[0] == '-')
        {
            sign = (s[0] == '-') ? -1 : 1;
            i++;
        }

        while (i < s.Length && Char.IsDigit(s[i]))
        {
            int digit = s[i] - '0';
            if (num > (Int32.MaxValue - digit) / 10)
            {
                return (sign == 1) ? Int32.MaxValue : Int32.MinValue;
            }
            num = num * 10 + digit;
            i++;
        }

        return sign * num;
    }
}
