namespace LeetCode;

public class PalindromeNumberService
{
    public bool IsPalindrome(int x)
    {
        int result = 0,temp = x;

        while( temp > 0)
        {
            var remainder = temp % 10;
            result = result * 10 + remainder;
            temp/=10;
        }

        return result == x;
    }
}
