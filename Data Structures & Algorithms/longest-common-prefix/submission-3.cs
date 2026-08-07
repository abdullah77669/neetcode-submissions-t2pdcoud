public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        
        if(strs.Length==1)
        {
            return strs[0];
        }
        string prefix="";
        if(strs.Length==0)
        {
            return "";
        }
        int len=strs[0].Length;
        if(len ==0)
        {
            return "";
        }

        for(int a=0;a<len;a++)
        {
            
            
             for(int b=1;b<strs.Length;b++)
             {
                if(strs[b].Length==0)
            {
                return "";
            }
            else if(a>=strs[b].Length)
            {
                return prefix;
            }
            else if(strs[0][a]!=strs[b][a])
            {
                return prefix;
            }
                else if(strs[0][a]==strs[b][a] && b==strs.Length-1)
                {
                    prefix=prefix+strs[0][a];
                }
                
             }
             
        }
        return prefix;

    }
}