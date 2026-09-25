public class Solution {
    public int LengthOfLongestSubstring(string s) {
       if(s.Length==0)
       return 0;
       if(string.IsNullOrWhiteSpace(s))
       return 1;
       string temp=string.Empty;
       int len=0,result=0;
       int left=0,right=0;

       for(int i=0;i<s.Length;i++)
       {
        if(temp.Contains(s[i])==true)
        {
            //result=Math.Max(result,len);
            right=i-1;
            while(temp.Contains(s[i]))
            {
               left++;
               temp=s.Substring(left,right-left+1);
            }
            temp+=s[i];
            len=temp.Length;
            result=Math.Max(result,len);
        }
        else
        {
            temp+=s[i];
            len++;
            result=Math.Max(result,len);
        }
       }
       if(result==0)
       return len;
       return result;
    }
}
