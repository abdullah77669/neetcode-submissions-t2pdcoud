public class Solution {
    public bool WordPattern(string pattern, string s) {
        int count=0;
        for(int j=0;j<s.Length;j++)
        {
            if(s[j]==' ')
            {
                count++;
            }
        }
        if(pattern.Length!=count+1)
        {
            return false;
        }
        System.Collections.Hashtable follow=new System.Collections.Hashtable();
        int ptr=0;
        System.Collections.Hashtable follow2=new System.Collections.Hashtable();
        string temp="";

        for(int i=0;i<pattern.Length;i++)
        {
            while(ptr<s.Length && s[ptr]!=' ')
                {
                    temp+=s[ptr];
                    ptr++;
                }
            if(follow.ContainsKey(pattern[i]))
            {
                
               
             if((string)follow[pattern[i]]!=temp )
                {
                    return false;
                }
             if((char)follow2[temp]!=pattern[i])
                {
                    return false;
                }
            }
            else 
            {
                
                
                if(follow2.ContainsKey(temp))
                return false;

                follow.Add(pattern[i],temp);
                follow2.Add(temp,pattern[i]);
            }
            temp=string.Empty;
                if(ptr<s.Length && s[ptr]==' ')
                ptr++;
        }
        return true;
    }
}