public class Solution {
    public bool IsIsomorphic(string s, string t) {
        
        if(s.Length!=t.Length)
        {
            return false;
        }
        System.Collections.Hashtable ht1=new System.Collections.Hashtable();
        System.Collections.Hashtable ht2 = new System.Collections.Hashtable();

        for(int i=0;i<s.Length;i++)
        {
            if(ht1.ContainsKey(s[i]))
            {
                if(t[i]==(char)ht1[s[i]])
                {
                    continue;
                }
                return false;


            }
            if(ht2.ContainsKey(t[i]))
            {
                if(s[i]==(char)ht2[t[i]])
                {
                    continue;
                }
                return false;
            }
            
            else
            {
                ht1.Add(s[i],t[i]);
                ht2.Add(t[i],s[i]);
            }
        }

        return true;
    }
}