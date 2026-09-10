public class Solution {
    public int Compress(char[] chars) {
        
        if(chars.Length==1)
        return 1;

        
        char a=chars[0];       
        int repeat=1;
        
        int write=1;

        for(int i=1;i<chars.Length;i++)
        {
            if(chars[i]==a)
            repeat++;

            else if(repeat>1)
            {

                foreach(char c in repeat.ToString())
                {
                chars[write++]=c;
                }
                a=chars[i];
                chars[write++]=chars[i];
                repeat=1;
                
            }
            else
            {
                chars[write++]=chars[i];
                a=chars[i];
                repeat=1;
            }

        }
        if(repeat!=1)
        {
            foreach(char c in repeat.ToString())
            chars[write++]=c;
        }
        
        return write;

    }
}