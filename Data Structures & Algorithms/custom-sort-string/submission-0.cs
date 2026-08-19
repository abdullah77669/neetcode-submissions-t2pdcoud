public class Solution
{
    public string CustomSortString(string order, string s)
    {
        char[] chars = s.ToCharArray();
        bool[] check = new bool[s.Length];

        int position = 0;

        for (int i = 0; i < order.Length; i++)
        {
            for (int j = 0; j < chars.Length; j++)
            {
                if (chars[j] == order[i] && !check[j])
                {
                    char temp = chars[position];
                    chars[position] = chars[j];
                    chars[j] = temp;

                    check[position] = true;
                    position++;
                }
            }
        }

        return new string(chars);
    }
}