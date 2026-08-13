public class Solution {
    public int MinOperations(string s) {
        
      int count1=0,count2=0;

      for(int i=0;i<s.Length;i++)
      {
        if(i%2==1 && s[i]=='0')
        {
            count1++;
        }
        else if(i%2==0 && s[i]=='1')
        {
            count1++;
        }
        
      }
      for(int i=0;i<s.Length;i++)
      {
        if(i%2==1 && s[i]=='1')
        {
            count2++;
        }
        else if(i%2==0 && s[i]=='0')
        {
            count2++;
        }
        
      }
      return Math.Min(count1,count2);
        }
        
    }
