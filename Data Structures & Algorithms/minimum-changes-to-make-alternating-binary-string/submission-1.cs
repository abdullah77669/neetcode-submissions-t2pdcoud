public class Solution {
    public int MinOperations(string s) {
        
      int count1=0,count2=0;
      char expected1='0',expected2='0';

      for(int i=0;i<s.Length;i++)
      {
        if(i%2==1 )
        {
            expected1='0';
            expected2='1';
        }
        else 
        {
            expected1='1';
            expected2='0';
        }
        if(s[i]!=expected1)
        {
            count1++;
        }
        if(s[i]!=expected2)
        {
            count2++;
            
        }
        
      }
      /*for(int i=0;i<s.Length;i++)
      {
        if(i%2==1 && s[i]=='1')
        {
            count2++;
        }
        else if(i%2==0 && s[i]=='0')
        {
            count2++;
        }
        
      }*/
      return Math.Min(count1,count2);
        }
        
    }
