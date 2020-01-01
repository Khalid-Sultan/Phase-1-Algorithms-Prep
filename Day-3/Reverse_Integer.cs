public class Solution
{
    public int Reverse(int x)
    {
        int reverse = 0;
        while (x != 0)
        {
            int rem = x % 10;
            if (reverse > int.MaxValue / 10) return 0;
            if (reverse < int.MinValue / 10) return 0;
            x /= 10;
            reverse = reverse * 10 + rem;
        }

        return reverse;
    }
}