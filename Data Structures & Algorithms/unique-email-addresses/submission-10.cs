public class Solution
{
public int NumUniqueEmails(string[] emails)
{
if (emails.Length == 1)
{
return 1;
}

    string[] compare = new string[emails.Length];

    for (int i = 0; i < emails.Length; i++)
    {
        for (int j = 0; j < emails[i].Length; j++)
        {
            if (emails[i][j] == '@')
            {
                compare[i] += emails[i].Substring(j + 1);
                break;
            }
            else if (emails[i][j] == '+')
            {
                while (emails[i][j] != '@')
                {
                    j++;
                }

                compare[i] += emails[i].Substring(j + 1);
                break;
            }
            else if (emails[i][j] == '.')
            {
                continue;
            }

            compare[i] += emails[i][j];
        }
    }

    HashSet<string> uniqueEmail = new HashSet<string>();

    uniqueEmail.UnionWith(compare);

    return uniqueEmail.Count;
}
}