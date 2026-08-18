public class Solution {
    public int MaxLengthBetweenEqualCharacters(string s) {
        if(s.Length==1)
        return -1;

        if(s.Length==2 && s[0]!=s[1])
        return -1;

        else if(s.Length==2)
        return 0;

        HashSet<char> freq=new HashSet<char>();
        int diff=-1;

        for(int i=0;i<s.Length;i++)
        {
            if(freq.Contains(s[i]) )
            {
                int first=s.IndexOf(s[i]);
                
                diff=Math.Max(diff,i-first-1);
                               
            }
            else
            freq.Add(s[i]);
        }
        return diff;
    }
}