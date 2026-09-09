public class Solution {
    public bool ValidWordAbbreviation(string word, string abbr) {
        
        int a=0;
        string b="";
        for(int i=0;i<word.Length;i++)
        {
            if(a>=abbr.Length)
            return false;
            if(char.IsDigit(abbr[a])==false)
            {
                if(abbr[a]!=word[i])
                return false;
                a++;
            }
            else if(abbr[a]=='0')
            return false;

            else
            {
                while(a<abbr.Length && char.IsDigit(abbr[a]))
                {
                   b+=abbr[a];
                   a++;
                }
                int num=int.Parse(b);
                b="";
                
                if(word.Length<i+num)
                return false;

                i+=num-1;                
            }
        }
        return a==abbr.Length;
    }
}