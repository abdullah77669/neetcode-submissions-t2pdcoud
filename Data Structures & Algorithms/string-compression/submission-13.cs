public class Solution {
    public int Compress(char[] chars) {
        
        if(chars.Length==1)
        return 1;

        string result="";
        char a=chars[0];
        result+=a;
        int repeat=1;

        for(int i=1;i<chars.Length;i++)
        {
            if(chars[i]==a)
            repeat++;

            else if(repeat>1)
            {
                
                result+=repeat.ToString();
                result+=chars[i];
                a=chars[i];
                repeat=1;
            }
            else
            {
                result+=chars[i];
                a=chars[i];
                repeat=1;
            }

        }
        if(repeat!=1)
        result+=repeat.ToString();

        for(int j=0;j<result.Length;j++)
        {
            chars[j]=result[j];
        }
        return result.Length;

    }
}