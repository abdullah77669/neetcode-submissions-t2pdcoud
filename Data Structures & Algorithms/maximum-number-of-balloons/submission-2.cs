public class Solution {
    public int MaxNumberOfBalloons(string text) {
        

        int b=0,a=0,l=0,n=0,o=0;
        for (int i=0;i<text.Length;i++)
        {
            if(text[i]=='b')
            {
                b++;
            }
            else if(text[i]=='a')
            {
                a++;
            }
            else if(text[i]=='l')
            {
                l++;
            }
            else if(text[i]=='o')
            {
                o++;
            }
            else if(text[i]=='n')
            {
                n++;
            }
        }
        
        l=l/2;
        o=o/2;
        
        int resultcount=Math.Min(b,a);
        resultcount=Math.Min(resultcount,l);
        resultcount=Math.Min(resultcount,o);
        resultcount=Math.Min(resultcount,n);

        return resultcount;



    }
}