public class Solution {
    public int MaxDifference(string s) {
        int odd=0,even =100000;
        System.Collections.Generic.HashSet<char> freq=new System.Collections.Generic.HashSet<char>();
        char[] char1=s.ToCharArray();
        Array.Sort(char1);
        string result=new string(char1);
        for(int i=0;i<result.Length;i++)
        {
            if(freq.Contains(result[i]))
             continue;

            int temp=1;
            

            
            freq.Add(result[i]);
             for(int j=i+1;j<result.Length;j++)
             {
                if(result[i]==result[j])
                {
                    temp++;
                    
                }
                else
                {
                    break;
                }
                
             }
             if(temp%2==0)
             {
                if(temp<even)
                even=temp;
             }
             else
             {
                if(temp>odd)
                {
                    odd=temp;
                }
             }
        }
        return odd-even;
    }
}