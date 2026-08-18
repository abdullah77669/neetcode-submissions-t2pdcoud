public class Solution {
    public int FirstUniqChar(string s) {
        Dictionary<char,int> freq=new Dictionary<char,int>();

        for(int i=0;i<s.Length;i++)
        {
            if(!freq.ContainsKey(s[i]))
            freq.Add(s[i],0);

            freq[s[i]]++;
        }
        int position=100000;

        foreach(var kv in freq)
        {
            if(kv.Value==1)
            {
                int temp=s.IndexOf(kv.Key);
                position=Math.Min(position,temp);
            }
        }
        if(position==100000)
        return -1;
        
        return position;
    }
}