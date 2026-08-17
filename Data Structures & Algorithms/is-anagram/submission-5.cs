public class Solution {
    public bool IsAnagram(string s, string t) {

      Dictionary<char,int> freq1=new Dictionary<char,int>();

      Dictionary<char,int> freq2=new Dictionary<char,int>();
      if(s.Length!=t.Length)
      return false;
      for(int i=0;i<s.Length;i++)
      {
        if(freq1.ContainsKey(s[i]))
        {
            freq1[s[i]]++;
        }
        else
        {
            freq1.Add(s[i],1);
        }
        if(freq2.ContainsKey(t[i]))
        {
            freq2[t[i]]++;
        }
        else
        {
            freq2.Add(t[i],1);
        }

      }
      bool same= freq1.Count== freq2.Count && freq1.All(x=> freq2.TryGetValue(x.Key, out var value) && value==x.Value);
      return same;

    }
}
