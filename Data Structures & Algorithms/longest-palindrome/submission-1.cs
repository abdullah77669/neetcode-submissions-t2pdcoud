public class Solution {
    public int LongestPalindrome(string s) {
        if(s.Length==1)
        {
            return 1;
        }
        
        Dictionary<char,int> freq=new Dictionary<char,int>();

        for(int i=0;i<s.Length;i++)
        {
            if(!freq.ContainsKey(s[i]))
            {
                freq.Add(s[i],0);
            }
            freq[s[i]]++;
        }

        int oddCount=0,output=0;

        foreach(var key in freq)
        {
            if(key.Value % 2==0)
                output+=key.Value;
            else
            {
                output += key.Value - 1;
                oddCount = 1;
            }
        }
        return output + oddCount;
    }
}