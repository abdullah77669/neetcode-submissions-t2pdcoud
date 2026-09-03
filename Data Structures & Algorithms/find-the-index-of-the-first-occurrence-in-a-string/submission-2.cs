public class Solution {
    public int StrStr(string haystack, string needle) {
        for (int i=0;i<haystack.Length;i++)
        {
            if(haystack[i]==needle[0])
            {
                int temp=i,a=0;
                while(temp<haystack.Length && a<needle.Length && haystack[temp]==needle[a])
                {
                    if(a<needle.Length-1)
                    {
                    temp++;
                    a++;
                    }
                    else 
                    return i;
                }

                

                
            }
            if(i>=haystack.Length)
            break;
        }
        return -1;
    }
}