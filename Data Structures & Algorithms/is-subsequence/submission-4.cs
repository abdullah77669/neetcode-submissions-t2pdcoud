public class Solution {
    public bool IsSubsequence(string s, string t) {
        if(s.Length>t.Length )
        {
            return false;
        }
        if( s.Length==0)
        {
            return true;
        }

        int i=0,j=0;
        while(j<t.Length)
        {

            if(i!=s.Length && s[i]==t[j] )
            {
                i=i+1;
            }
            j=j+1;
           
           
        }
        if(i==s.Length)
        {
            return true;
        }
        return false;

    }
}