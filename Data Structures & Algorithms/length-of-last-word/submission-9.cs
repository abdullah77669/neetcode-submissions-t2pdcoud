public class Solution {
    public int LengthOfLastWord(string s) {
        if(s.Length==0)
        {
            return 0;
        }
        int lastLen=0;

        for(int a=s.Length-1;a>=0;a--)
        {
            if(s[a]==' ' && lastLen==0)
            continue;

            else if(s[a]!=' ')
            {
                lastLen++;

            }
            else if(s[a]==' ' && lastLen!=0)
            break;
        }
        
        return lastLen;

    }
}