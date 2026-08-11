public class Solution {
    public int AppendCharacters(string s, string t) {
        int i=0,j=0;

        while(i<s.Length)
        {
            if(j<t.Length && s[i]==t[j])
            {
                j++;
            }
            
            i++;
        }
        if(j==t.Length)
        {
            return 0;
        }
        
            int count=0;
            while(j<t.Length)
            {
                count++;
                j++;
            }
            return count;
        

    }
}