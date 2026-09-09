public class Solution {
    public bool ValidWordAbbreviation(string word, string abbr) {

        int a = 0;
        string b = "";

        for (int i = 0; i < word.Length; i++)
        {
            if (a >= abbr.Length)
                return false;

            if (!char.IsDigit(abbr[a]))
            {
                if (abbr[a] != word[i])
                    return false;

                a++;
            }
            else if (abbr[a] == '0')
            {
                return false;
            }
            else
            {
                while (a < abbr.Length && char.IsDigit(abbr[a]))
                {
                    b += abbr[a];
                    a++;
                }

                int num = int.Parse(b);
                b = "";

                i += num - 1;

                if (i >= word.Length)
                    return false;
            }
        }

        return a == abbr.Length;
    }
}