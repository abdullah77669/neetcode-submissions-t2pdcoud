public class Solution {
    public int NumUniqueEmails(string[] emails) {
        if (emails.Length==1)
        { 
            return 1;
        }
        int result=0;
        string[] compare=new string[emails.Length];
        for(int i=0;i<emails.Length;i++)
        {
            for(int j=0;j<emails[i].Length;j++)
            {
                if(emails[i][j]=='+' )
                {
                    while(emails[i][j]!='@')
                    {
                        j++;
                    }
                    compare[i] += "@";
                    string add=emails[i].Substring(j+1);
                    compare[i]+=add;
                    break;
                }
                else if(emails[i][j]=='.' )
                {
                    continue;
                }
                else if(emails[i][j]=='@')
                {
                    compare[i] += "@";
                    string add=emails[i].Substring(j+1);
                    compare[i]+=add;
                    break;
                }
                compare[i]+= emails[i][j];
            }
        }
        HashSet<string> uniqueEmails = new HashSet<string>(compare);
        return uniqueEmails.Count;
    }
}